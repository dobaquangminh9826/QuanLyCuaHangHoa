using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmThongKeSoLuongHoa : Form
    {
        private readonly string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";
        private readonly Color hong = Color.FromArgb(233, 78, 145);
        private readonly Color hongNhat = Color.FromArgb(252, 234, 242);
        private readonly Color chu = Color.FromArgb(92, 35, 68);

        public frmThongKeSoLuongHoa()
        {
            InitializeComponent();

            this.Load += frmThongKeSoLuongHoa_Load;

            cmbHinhThuc.SelectedIndexChanged += cmbHinhThuc_SelectedIndexChanged;
            btnThongKe.Click += btnThongKe_Click;
            btnDatLai.Click += btnDatLai_Click;
            btnQuayLai.Click += btnQuayLai_Click;
        }

        private void frmThongKeSoLuongHoa_Load(object sender, EventArgs e)
        {
            // Thiết lập danh sách lọc
            cmbHinhThuc.Items.Clear();
            cmbHinhThuc.Items.Add("Theo ngày");
            cmbHinhThuc.Items.Add("Theo tháng");
            cmbHinhThuc.Items.Add("Theo năm");
            cmbHinhThuc.SelectedIndex = 0;

            // Thiết lập ngày
            dtpChonNgay.Format = DateTimePickerFormat.Custom;
            dtpChonNgay.CustomFormat = "dd/MM/yyyy";
            dtpChonNgay.ShowUpDown = false;
            dtpChonNgay.Value = DateTime.Today;

            // Thiết lập năm
            numChonNam.Minimum = 2000;
            numChonNam.Maximum = 2100;
            numChonNam.Value = DateTime.Today.Year;

            // Thiết lập bảng
            dgvSoLuongHoa.ReadOnly = true;
            dgvSoLuongHoa.AllowUserToAddRows = false;
            dgvSoLuongHoa.AllowUserToDeleteRows = false;
            dgvSoLuongHoa.AutoGenerateColumns = true;
            dgvSoLuongHoa.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvSoLuongHoa.MultiSelect = false;
            dgvSoLuongHoa.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoLuongHoa.RowHeadersVisible = false;

            CapNhatBoLoc();
            ThongKeSoLuongHoa();
        }

        // Thay đổi giao diện khi chọn ngày, tháng hoặc năm
        private void cmbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatBoLoc();
        }

        private void CapNhatBoLoc()
        {
            string hinhThuc = cmbHinhThuc.Text;

            if (hinhThuc == "Theo năm")
            {
                // Chỉ hiển thị ô chọn năm
                lblChonNgay.Visible = false;
                dtpChonNgay.Visible = false;

                lblChonNam.Visible = true;
                numChonNam.Visible = true;
                lblChonNam.Text = "Chọn năm:";
            }
            else if (hinhThuc == "Theo tháng")
            {
                // Hiển thị ô chọn tháng/năm
                lblChonNgay.Visible = true;
                dtpChonNgay.Visible = true;

                lblChonNam.Visible = false;
                numChonNam.Visible = false;

                lblChonNgay.Text = "Chọn tháng:";
                dtpChonNgay.Format = DateTimePickerFormat.Custom;
                dtpChonNgay.CustomFormat = "MM/yyyy";
                dtpChonNgay.ShowUpDown = true;
            }
            else
            {
                // Hiển thị ô chọn ngày/tháng/năm
                lblChonNgay.Visible = true;
                dtpChonNgay.Visible = true;

                lblChonNam.Visible = false;
                numChonNam.Visible = false;

                lblChonNgay.Text = "Chọn ngày:";
                dtpChonNgay.Format = DateTimePickerFormat.Custom;
                dtpChonNgay.CustomFormat = "dd/MM/yyyy";
                dtpChonNgay.ShowUpDown = false;
            }
        }

        // Xác định khoảng thời gian thống kê
        private void LayKhoangNgay(
            out DateTime tuNgay,
            out DateTime denNgay)
        {
            string hinhThuc = cmbHinhThuc.Text;

            if (hinhThuc == "Theo năm")
            {
                int nam = Convert.ToInt32(numChonNam.Value);

                tuNgay = new DateTime(nam, 1, 1);
                denNgay = tuNgay.AddYears(1);
            }
            else if (hinhThuc == "Theo tháng")
            {
                int thang = dtpChonNgay.Value.Month;
                int nam = dtpChonNgay.Value.Year;

                tuNgay = new DateTime(nam, thang, 1);
                denNgay = tuNgay.AddMonths(1);
            }
            else
            {
                tuNgay = dtpChonNgay.Value.Date;
                denNgay = tuNgay.AddDays(1);
            }
        }

        // Tạo câu lệnh SQL có tham số thời gian
        private SqlCommand TaoLenh(
            string sql,
            DateTime tuNgay,
            DateTime denNgay,
            SqlConnection ketNoi)
        {
            SqlCommand lenh = new SqlCommand(sql, ketNoi);

            lenh.Parameters.Add("@TuNgay", SqlDbType.DateTime).Value = tuNgay;
            lenh.Parameters.Add("@DenNgay", SqlDbType.DateTime).Value = denNgay;

            return lenh;
        }

        // Thực hiện thống kê
        private void ThongKeSoLuongHoa()
        {
            DateTime tuNgay;
            DateTime denNgay;

            LayKhoangNgay(out tuNgay, out denNgay);

            try
            {
                using (SqlConnection ketNoi =
                    new SqlConnection(chuoiKetNoi))
                {
                    ketNoi.Open();

                    // 1. Tổng số lượng hoa đã bán
                    string sqlTongSoLuong = @"
                        SELECT ISNULL(SUM(ct.SoLuong), 0)
                        FROM ChiTietHoaDon ct
                        INNER JOIN HoaDon hd ON ct.MaHD = hd.MaHD
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay;";

                    using (SqlCommand lenh = TaoLenh(
                        sqlTongSoLuong, tuNgay, denNgay, ketNoi))
                    {
                        decimal tongSoLuong =
                            Convert.ToDecimal(lenh.ExecuteScalar());

                        lblValSoLuongBan.Text = tongSoLuong.ToString("N0");
                    }

                    // 2. Số mã hoa đã bán
                    string sqlSoLoai = @"
                        SELECT COUNT(DISTINCT ct.MaHoa)
                        FROM ChiTietHoaDon ct
                        INNER JOIN HoaDon hd ON ct.MaHD = hd.MaHD
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay;";

                    using (SqlCommand lenh = TaoLenh(
                        sqlSoLoai, tuNgay, denNgay, ketNoi))
                    {
                        int soLoai =
                            Convert.ToInt32(lenh.ExecuteScalar());

                        lblValSoLoai.Text = soLoai.ToString("N0");
                    }

                    // 3. Hoa bán chạy nhất
                    string sqlBanChay = @"
                        SELECT TOP 1
                            ct.MaHoa,
                            ISNULL(dm.TenDanhMuc, N'Chưa phân loại') AS TenDanhMuc,
                            SUM(ct.SoLuong) AS TongBan
                        FROM ChiTietHoaDon ct
                        INNER JOIN HoaDon hd ON ct.MaHD = hd.MaHD
                        LEFT JOIN Hoa h ON ct.MaHoa = h.MaHoa
                        LEFT JOIN DanhMuc dm ON h.MaDanhMuc = dm.MaDanhMuc
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay
                        GROUP BY ct.MaHoa, dm.TenDanhMuc
                        ORDER BY SUM(ct.SoLuong) DESC, ct.MaHoa;";

                    using (SqlCommand lenh = TaoLenh(
                        sqlBanChay, tuNgay, denNgay, ketNoi))
                    using (SqlDataReader doc = lenh.ExecuteReader())
                    {
                        if (doc.Read())
                        {
                            lblValBanChay.Text =
                                doc["MaHoa"].ToString() + " - " +
                                doc["TenDanhMuc"].ToString();
                        }
                        else
                        {
                            lblValBanChay.Text = "Chưa có dữ liệu";
                        }
                    }

                    // 4. Trung bình số lượng bán mỗi ngày có phát sinh bán
                    string sqlTrungBinh = @"
                        SELECT
                            CASE
                                WHEN COUNT(DISTINCT CONVERT(date, hd.NgayLap)) = 0
                                    THEN 0
                                ELSE
                                    CAST(SUM(ct.SoLuong) AS FLOAT)
                                    / COUNT(DISTINCT CONVERT(date, hd.NgayLap))
                            END
                        FROM ChiTietHoaDon ct
                        INNER JOIN HoaDon hd ON ct.MaHD = hd.MaHD
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay;";

                    using (SqlCommand lenh = TaoLenh(
                        sqlTrungBinh, tuNgay, denNgay, ketNoi))
                    {
                        decimal trungBinh =
                            Convert.ToDecimal(lenh.ExecuteScalar());

                        lblValTrungBinh.Text = trungBinh.ToString("N2");
                    }

                    // 5. Bảng xếp hạng hoa bán chạy
                    string sqlBang = @"
                        SELECT
                            ct.MaHoa AS [Mã hoa],
                            ISNULL(dm.TenDanhMuc, N'Chưa phân loại') AS [Danh mục],
                            SUM(ct.SoLuong) AS [Số lượng bán],
                            CAST(SUM(ct.ThanhTien) AS DECIMAL(18, 2)) AS [Doanh thu]
                        FROM ChiTietHoaDon ct
                        INNER JOIN HoaDon hd ON ct.MaHD = hd.MaHD
                        LEFT JOIN Hoa h ON ct.MaHoa = h.MaHoa
                        LEFT JOIN DanhMuc dm ON h.MaDanhMuc = dm.MaDanhMuc
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay
                        GROUP BY ct.MaHoa, dm.TenDanhMuc
                        ORDER BY SUM(ct.SoLuong) DESC, ct.MaHoa;";

                    using (SqlCommand lenh = TaoLenh(
                        sqlBang, tuNgay, denNgay, ketNoi))
                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(lenh))
                    {
                        DataTable bang = new DataTable();
                        adapter.Fill(bang);

                        dgvSoLuongHoa.DataSource = bang;
                    }

                    DinhDangBang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thống kê số lượng hoa.\n\n" +
                    "Vui lòng kiểm tra kết nối database và cấu trúc các bảng " +
                    "Hoa, DanhMuc, HoaDon, ChiTietHoaDon.\n\n" +
                    "Chi tiết: " + ex.Message,
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Định dạng bảng
        private void DinhDangBang()
        {
            if (dgvSoLuongHoa.Columns.Count == 0)
                return;

            dgvSoLuongHoa.EnableHeadersVisualStyles = false;

            dgvSoLuongHoa.ColumnHeadersDefaultCellStyle.BackColor = hong;
            dgvSoLuongHoa.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;
            dgvSoLuongHoa.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvSoLuongHoa.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);
            dgvSoLuongHoa.DefaultCellStyle.SelectionBackColor = hongNhat;
            dgvSoLuongHoa.DefaultCellStyle.SelectionForeColor = chu;

            dgvSoLuongHoa.RowTemplate.Height = 30;

            if (dgvSoLuongHoa.Columns.Contains("Số lượng bán"))
            {
                dgvSoLuongHoa.Columns["Số lượng bán"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvSoLuongHoa.Columns.Contains("Doanh thu"))
            {
                dgvSoLuongHoa.Columns["Doanh thu"]
                    .DefaultCellStyle.Format = "N0";
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeSoLuongHoa();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            cmbHinhThuc.SelectedIndex = 0;
            dtpChonNgay.Value = DateTime.Today;
            numChonNam.Value = DateTime.Today.Year;

            CapNhatBoLoc();
            ThongKeSoLuongHoa();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}