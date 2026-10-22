using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmThongKeDoanhThu : Form
    {
        private readonly string chuoiKetNoi =
            @"Data Source=localhost;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";

        // ComboBox chọn quý được tạo bằng code
        private ComboBox cmbQuy;
        private Label lblQuy;

        public frmThongKeDoanhThu()
        {
            InitializeComponent();

            // Gắn sự kiện
            this.Load += frmThongKeDoanhThu_Load;
            btnThongKe.Click += btnThongKe_Click;
            btnDatLai.Click += btnDatLai_Click;
            btnQuayLai.Click += btnQuayLai_Click;
            cmbLoaiLoc.SelectedIndexChanged += cmbLoaiLoc_SelectedIndexChanged;

            TaoBoChonQuy();
        }

        // ==================== TẠO COMBOBOX CHỌN QUÝ ====================
        private void TaoBoChonQuy()
        {
            lblQuy = new Label();
            lblQuy.Name = "lblQuy";
            lblQuy.Text = "Chọn quý:";
            lblQuy.AutoSize = true;
            lblQuy.Font = new Font("Segoe UI", 9F);
            lblQuy.ForeColor = Color.FromArgb(92, 35, 68);
            lblQuy.Visible = false;

            cmbQuy = new ComboBox();
            cmbQuy.Name = "cmbQuy";
            cmbQuy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuy.Font = new Font("Segoe UI", 9F);
            cmbQuy.Items.AddRange(new object[]
            {
                "Quý I",
                "Quý II",
                "Quý III",
                "Quý IV"
            });
            cmbQuy.SelectedIndex = 0;
            cmbQuy.Visible = false;

            // Đặt ComboBox quý bên cạnh ô chọn năm
            lblQuy.Location = new Point(
                dtpDenNgay.Left, dtpDenNgay.Top + 3);

            cmbQuy.Location = new Point(
                dtpDenNgay.Left, dtpDenNgay.Top);

            cmbQuy.Size = dtpDenNgay.Size;

            pnlBoLoc.Controls.Add(lblQuy);
            pnlBoLoc.Controls.Add(cmbQuy);

            lblQuy.BringToFront();
            cmbQuy.BringToFront();
        }

        // ==================== KHỞI TẠO FORM ====================
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";

            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";

            // Mặc định lọc từ đầu tháng đến hôm nay
            dtpTuNgay.Value = new DateTime(
                DateTime.Today.Year, DateTime.Today.Month, 1);

            dtpDenNgay.Value = DateTime.Today;

            if (cmbLoaiLoc.Items.Count > 0)
                cmbLoaiLoc.SelectedIndex = 0;

            dgvDoanhThu.AutoGenerateColumns = true;
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThu.MultiSelect = false;
            dgvDoanhThu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.RowHeadersVisible = false;

            CapNhatGiaoDienLoc();
            ThongKeDoanhThu();
        }

        // ==================== THAY ĐỔI KIỂU LỌC ====================
        private void cmbLoaiLoc_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatGiaoDienLoc();
        }

        private void CapNhatGiaoDienLoc()
        {
            string loaiLoc = cmbLoaiLoc.Text;

            lblTu.Visible = true;
            dtpTuNgay.Visible = true;
            lblDen.Visible = true;
            dtpDenNgay.Visible = true;

            lblQuy.Visible = false;
            cmbQuy.Visible = false;

            // Ngày cụ thể
            if (loaiLoc == "Ngày cụ thể")
            {
                lblTu.Text = "Chọn ngày:";
                lblDen.Visible = false;
                dtpDenNgay.Visible = false;

                dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            }
            // Lọc theo tháng
            else if (loaiLoc == "Tháng")
            {
                lblTu.Text = "Chọn tháng:";
                lblDen.Visible = false;
                dtpDenNgay.Visible = false;

                dtpTuNgay.CustomFormat = "MM/yyyy";
            }
            // Lọc theo quý: chọn năm và chọn quý
            else if (loaiLoc == "Quý")
            {
                lblTu.Text = "Chọn năm:";
                lblDen.Visible = false;
                dtpDenNgay.Visible = false;

                dtpTuNgay.CustomFormat = "yyyy";

                lblQuy.Visible = true;
                cmbQuy.Visible = true;
                lblQuy.BringToFront();
                cmbQuy.BringToFront();
            }
            // Lọc theo năm
            else if (loaiLoc == "Năm")
            {
                lblTu.Text = "Chọn năm:";
                lblDen.Visible = false;
                dtpDenNgay.Visible = false;

                dtpTuNgay.CustomFormat = "yyyy";
            }
            // Lọc theo khoảng ngày
            else
            {
                lblTu.Text = "Từ ngày:";
                lblDen.Text = "Đến ngày:";

                dtpTuNgay.CustomFormat = "dd/MM/yyyy";
                dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            }
        }

        // ==================== NÚT THỐNG KÊ ====================
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
        }

        // ==================== NÚT ĐẶT LẠI ====================
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(
                DateTime.Today.Year, DateTime.Today.Month, 1);

            dtpDenNgay.Value = DateTime.Today;

            if (cmbLoaiLoc.Items.Count > 0)
                cmbLoaiLoc.SelectedIndex = 0;

            cmbQuy.SelectedIndex = 0;

            CapNhatGiaoDienLoc();
            ThongKeDoanhThu();
        }

        // ==================== NÚT QUAY LẠI ====================
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ==================== XÁC ĐỊNH KHOẢNG THỜI GIAN ====================
        private void LayKhoangThoiGian(
            out DateTime tuNgay, out DateTime denNgay)
        {
            DateTime ngayChon = dtpTuNgay.Value.Date;
            string loaiLoc = cmbLoaiLoc.Text;

            if (loaiLoc == "Ngày cụ thể")
            {
                tuNgay = ngayChon;
                denNgay = ngayChon;
            }
            else if (loaiLoc == "Tháng")
            {
                tuNgay = new DateTime(
                    ngayChon.Year, ngayChon.Month, 1);

                denNgay = tuNgay.AddMonths(1).AddDays(-1);
            }
            else if (loaiLoc == "Quý")
            {
                int quy = cmbQuy.SelectedIndex + 1;
                int thangBatDau = (quy - 1) * 3 + 1;

                tuNgay = new DateTime(
                    ngayChon.Year, thangBatDau, 1);

                denNgay = tuNgay.AddMonths(3).AddDays(-1);
            }
            else if (loaiLoc == "Năm")
            {
                tuNgay = new DateTime(ngayChon.Year, 1, 1);
                denNgay = new DateTime(ngayChon.Year, 12, 31);
            }
            else
            {
                tuNgay = dtpTuNgay.Value.Date;
                denNgay = dtpDenNgay.Value.Date;
            }
        }

        // ==================== THỐNG KÊ DOANH THU ====================
        private void ThongKeDoanhThu()
        {
            DateTime tuNgay;
            DateTime denNgay;

            LayKhoangThoiGian(out tuNgay, out denNgay);

            if (denNgay < tuNgay)
            {
                MessageBox.Show(
                    "Ngày kết thúc không được nhỏ hơn ngày bắt đầu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DateTime denNgayKeTiep = denNgay.AddDays(1);

            try
            {
                using (SqlConnection ketNoi =
                    new SqlConnection(chuoiKetNoi))
                {
                    ketNoi.Open();

                    // 1. Danh sách hóa đơn và tổng tiền từng hóa đơn
                    string sqlChiTiet = @"
                        SELECT
                            hd.MaHD AS [Mã hóa đơn],
                            hd.NgayLap AS [Ngày lập],
                            kh.HoTen AS [Khách hàng],
                            ISNULL(SUM(ct.ThanhTien), 0) AS [Tổng tiền]
                        FROM HoaDon hd
                        LEFT JOIN KhachHang kh
                            ON hd.MaKH = kh.MaKH
                        LEFT JOIN ChiTietHoaDon ct
                            ON hd.MaHD = ct.MaHD
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgayKeTiep
                        GROUP BY hd.MaHD, hd.NgayLap, kh.HoTen
                        ORDER BY hd.NgayLap DESC, hd.MaHD DESC";

                    using (SqlCommand lenh =
                        new SqlCommand(sqlChiTiet, ketNoi))
                    {
                        lenh.Parameters.Add(
                            "@TuNgay", SqlDbType.DateTime).Value = tuNgay;

                        lenh.Parameters.Add(
                            "@DenNgayKeTiep", SqlDbType.DateTime)
                            .Value = denNgayKeTiep;

                        using (SqlDataAdapter boNap =
                            new SqlDataAdapter(lenh))
                        {
                            DataTable bangDuLieu = new DataTable();
                            boNap.Fill(bangDuLieu);
                            dgvDoanhThu.DataSource = bangDuLieu;
                        }
                    }

                    // 2. Tổng số hóa đơn và tổng doanh thu
                    string sqlTongQuan = @"
                        SELECT
                            COUNT(DISTINCT hd.MaHD) AS SoHoaDon,
                            ISNULL(SUM(ct.ThanhTien), 0) AS TongDoanhThu
                        FROM HoaDon hd
                        LEFT JOIN ChiTietHoaDon ct
                            ON hd.MaHD = ct.MaHD
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgayKeTiep";

                    int soHoaDon = 0;
                    decimal tongDoanhThu = 0;

                    using (SqlCommand lenh =
                        new SqlCommand(sqlTongQuan, ketNoi))
                    {
                        lenh.Parameters.Add(
                            "@TuNgay", SqlDbType.DateTime).Value = tuNgay;

                        lenh.Parameters.Add(
                            "@DenNgayKeTiep", SqlDbType.DateTime)
                            .Value = denNgayKeTiep;

                        using (SqlDataReader doc = lenh.ExecuteReader())
                        {
                            if (doc.Read())
                            {
                                soHoaDon =
                                    Convert.ToInt32(doc["SoHoaDon"]);

                                tongDoanhThu =
                                    Convert.ToDecimal(doc["TongDoanhThu"]);
                            }
                        }
                    }

                    // 3. Doanh thu trung bình mỗi hóa đơn
                    decimal trungBinh = 0;

                    if (soHoaDon > 0)
                        trungBinh = tongDoanhThu / soHoaDon;

                    // 4. Hiển thị lên các thẻ thống kê
                    lblValSoHD.Text = soHoaDon.ToString("N0");

                    lblValDoanhThu.Text =
                        tongDoanhThu.ToString("#,##0") + " VNĐ";

                    lblValTrungBinh.Text =
                        trungBinh.ToString("#,##0") + " VNĐ";

                    // 5. Định dạng cột ngày và tiền
                    if (dgvDoanhThu.Columns["Ngày lập"] != null)
                    {
                        dgvDoanhThu.Columns["Ngày lập"]
                            .DefaultCellStyle.Format = "dd/MM/yyyy";
                    }

                    if (dgvDoanhThu.Columns["Tổng tiền"] != null)
                    {
                        dgvDoanhThu.Columns["Tổng tiền"]
                            .DefaultCellStyle.Format = "#,##0 'VNĐ'";

                        dgvDoanhThu.Columns["Tổng tiền"]
                            .DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight;
                    }

                    lblChiTietSub.Text =
                        "Thời gian: " + tuNgay.ToString("dd/MM/yyyy") +
                        " - " + denNgay.ToString("dd/MM/yyyy");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể truy vấn dữ liệu doanh thu.\n\n" +
                    "Hãy kiểm tra tên bảng, tên cột và kết nối SQL Server.\n\n" +
                    "Chi tiết: " + ex.Message,
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đã xảy ra lỗi khi thống kê doanh thu:\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}