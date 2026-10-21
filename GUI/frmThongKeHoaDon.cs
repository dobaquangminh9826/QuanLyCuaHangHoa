using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmThongKeHoaDon : Form
    {
        private readonly string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";
        private ComboBox cmbQuy;
        private Label lblQuy;

        public frmThongKeHoaDon()
        {
            InitializeComponent();

            TaoComboBoxQuy();

            this.Load += frmThongKeHoaDon_Load;
            cmbHinhThuc.SelectedIndexChanged += cmbHinhThuc_SelectedIndexChanged;
            btnThongKe.Click += btnThongKe_Click;
            btnDatLai.Click += btnDatLai_Click;
            btnQuayLai.Click += btnQuayLai_Click;
        }

        // ==================== TAO BO CHON QUY ====================
        private void TaoComboBoxQuy()
        {
            lblQuy = new Label();
            lblQuy.Name = "lblQuy";
            lblQuy.Text = "Quý:";
            lblQuy.AutoSize = true;
            lblQuy.Location = new Point(310, 13);
            lblQuy.Font = new Font("Segoe UI", 9F);
            lblQuy.ForeColor = Color.FromArgb(13, 148, 136);
            lblQuy.Visible = false;

            cmbQuy = new ComboBox();
            cmbQuy.Name = "cmbQuy";
            cmbQuy.Location = new Point(350, 10);
            cmbQuy.Size = new Size(85, 26);
            cmbQuy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuy.Font = new Font("Segoe UI", 9F);
            cmbQuy.Items.AddRange(new object[]
            {
                "Quý I", "Quý II", "Quý III", "Quý IV"
            });
            cmbQuy.SelectedIndex = 0;
            cmbQuy.Visible = false;

            pnlBoLoc.Controls.Add(lblQuy);
            pnlBoLoc.Controls.Add(cmbQuy);

            lblQuy.BringToFront();
            cmbQuy.BringToFront();
        }

        // ==================== KHI MO FORM ====================
        private void frmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            dtpChonNgay.Format = DateTimePickerFormat.Custom;
            dtpChonNgay.CustomFormat = "dd/MM/yyyy";
            dtpChonNgay.Value = DateTime.Today;

            numChonNam.Minimum = 2000;
            numChonNam.Maximum = 2100;
            numChonNam.Value = DateTime.Today.Year;

            cmbHinhThuc.SelectedItem = "Theo ngày";

            if (cmbHinhThuc.SelectedIndex < 0)
                cmbHinhThuc.SelectedIndex = 0;

            dgvHoaDon.AutoGenerateColumns = true;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.RowHeadersVisible = false;

            CapNhatBoLoc();
            ThongKeHoaDon();
        }

        // ==================== THAY DOI HINH THUC LOC ====================
        private void cmbHinhThuc_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatBoLoc();
        }

        private void CapNhatBoLoc()
        {
            string hinhThuc = cmbHinhThuc.Text;

            lblChonNgay.Visible = false;
            dtpChonNgay.Visible = false;
            lblChonNam.Visible = false;
            numChonNam.Visible = false;
            lblQuy.Visible = false;
            cmbQuy.Visible = false;

            if (hinhThuc == "Theo ngày")
            {
                lblChonNgay.Text = "Ngày:";
                lblChonNgay.Location = new Point(310, 13);

                dtpChonNgay.Location = new Point(385, 10);
                dtpChonNgay.Size = new Size(105, 26);
                dtpChonNgay.CustomFormat = "dd/MM/yyyy";

                lblChonNgay.Visible = true;
                dtpChonNgay.Visible = true;
            }
            else if (hinhThuc == "Theo tháng")
            {
                lblChonNgay.Text = "Tháng:";
                lblChonNgay.Location = new Point(310, 13);

                dtpChonNgay.Location = new Point(385, 10);
                dtpChonNgay.Size = new Size(105, 26);
                dtpChonNgay.CustomFormat = "MM/yyyy";

                lblChonNgay.Visible = true;
                dtpChonNgay.Visible = true;
            }
            else if (hinhThuc == "Theo quý")
            {
                lblQuy.Location = new Point(310, 13);
                cmbQuy.Location = new Point(350, 10);

                lblChonNam.Text = "Năm:";
                lblChonNam.Location = new Point(450, 13);
                numChonNam.Location = new Point(500, 10);

                lblQuy.Visible = true;
                cmbQuy.Visible = true;
                lblChonNam.Visible = true;
                numChonNam.Visible = true;
            }
            else if (hinhThuc == "Theo năm")
            {
                lblChonNam.Text = "Năm:";
                lblChonNam.Location = new Point(310, 13);
                numChonNam.Location = new Point(370, 10);

                lblChonNam.Visible = true;
                numChonNam.Visible = true;
            }

            lblChonNgay.BringToFront();
            dtpChonNgay.BringToFront();
            lblChonNam.BringToFront();
            numChonNam.BringToFront();
            lblQuy.BringToFront();
            cmbQuy.BringToFront();
        }

        // ==================== LAY KHOANG NGAY ====================
        private void LayKhoangNgay(
            out DateTime tuNgay, out DateTime denNgayKeTiep)
        {
            string hinhThuc = cmbHinhThuc.Text;
            DateTime ngayChon = dtpChonNgay.Value.Date;

            if (hinhThuc == "Theo ngày")
            {
                tuNgay = ngayChon;
                denNgayKeTiep = tuNgay.AddDays(1);
            }
            else if (hinhThuc == "Theo tháng")
            {
                tuNgay = new DateTime(
                    ngayChon.Year, ngayChon.Month, 1);

                denNgayKeTiep = tuNgay.AddMonths(1);
            }
            else if (hinhThuc == "Theo quý")
            {
                int quy = cmbQuy.SelectedIndex + 1;
                int nam = (int)numChonNam.Value;
                int thangBatDau = (quy - 1) * 3 + 1;

                tuNgay = new DateTime(nam, thangBatDau, 1);
                denNgayKeTiep = tuNgay.AddMonths(3);
            }
            else
            {
                int nam = (int)numChonNam.Value;

                tuNgay = new DateTime(nam, 1, 1);
                denNgayKeTiep = tuNgay.AddYears(1);
            }
        }

        // ==================== NUT THONG KE ====================
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeHoaDon();
        }

        // ==================== NUT DAT LAI ====================
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            dtpChonNgay.Value = DateTime.Today;
            numChonNam.Value = DateTime.Today.Year;
            cmbQuy.SelectedIndex = 0;
            cmbHinhThuc.SelectedItem = "Theo ngày";

            CapNhatBoLoc();
            ThongKeHoaDon();
        }

        // ==================== NUT QUAY LAI ====================
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ==================== THONG KE HOA DON ====================
        private void ThongKeHoaDon()
        {
            DateTime tuNgay;
            DateTime denNgayKeTiep;

            LayKhoangNgay(out tuNgay, out denNgayKeTiep);

            try
            {
                using (SqlConnection ketNoi =
                    new SqlConnection(chuoiKetNoi))
                {
                    ketNoi.Open();

                    // 1. Tong so hoa don
                    string sqlSoHoaDon = @"
                        SELECT COUNT(*)
                        FROM HoaDon hd
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay";

                    int soHoaDon = 0;

                    using (SqlCommand lenh =
                        new SqlCommand(sqlSoHoaDon, ketNoi))
                    {
                        ThemThamSoNgay(lenh, tuNgay, denNgayKeTiep);
                        soHoaDon = Convert.ToInt32(lenh.ExecuteScalar());
                    }

                    // 2. Tong doanh thu tu chi tiet hoa don
                    string sqlDoanhThu = @"
                        SELECT ISNULL(SUM(ct.ThanhTien), 0)
                        FROM HoaDon hd
                        INNER JOIN ChiTietHoaDon ct
                            ON hd.MaHD = ct.MaHD
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay";

                    decimal tongDoanhThu = 0;

                    using (SqlCommand lenh =
                        new SqlCommand(sqlDoanhThu, ketNoi))
                    {
                        ThemThamSoNgay(lenh, tuNgay, denNgayKeTiep);
                        tongDoanhThu =
                            Convert.ToDecimal(lenh.ExecuteScalar());
                    }

                    // 3. Trung binh doanh thu moi hoa don
                    decimal trungBinh = soHoaDon > 0
                        ? tongDoanhThu / soHoaDon
                        : 0;

                    lblValSoHD.Text = soHoaDon.ToString("N0");
                    lblValDoanhThu.Text =
                        tongDoanhThu.ToString("N0") + " VNĐ";
                    lblValTrungBinh.Text =
                        trungBinh.ToString("N0") + " VNĐ";

                    // 4. Danh sach hoa don
                    // LEFT JOIN de hoa don chua co chi tiet van hien thi.
                    string sqlBang = @"
                        SELECT
                            hd.MaHD AS [Mã hóa đơn],
                            hd.NgayLap AS [Ngày lập],
                            hd.MaKH AS [Mã khách hàng],
                            ISNULL(SUM(ct.SoLuong), 0) AS [Số lượng hoa],
                            ISNULL(SUM(ct.ThanhTien), 0) AS [Tổng tiền]
                        FROM HoaDon hd
                        LEFT JOIN ChiTietHoaDon ct
                            ON hd.MaHD = ct.MaHD
                        WHERE hd.NgayLap >= @TuNgay
                          AND hd.NgayLap < @DenNgay
                        GROUP BY hd.MaHD, hd.NgayLap, hd.MaKH
                        ORDER BY hd.NgayLap DESC, hd.MaHD DESC";

                    using (SqlCommand lenh =
                        new SqlCommand(sqlBang, ketNoi))
                    {
                        ThemThamSoNgay(lenh, tuNgay, denNgayKeTiep);

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(lenh))
                        {
                            DataTable bang = new DataTable();
                            adapter.Fill(bang);
                            dgvHoaDon.DataSource = bang;
                        }
                    }

                    // 5. Dinh dang cot
                    if (dgvHoaDon.Columns["Ngày lập"] != null)
                    {
                        dgvHoaDon.Columns["Ngày lập"]
                            .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }

                    if (dgvHoaDon.Columns["Tổng tiền"] != null)
                    {
                        dgvHoaDon.Columns["Tổng tiền"]
                            .DefaultCellStyle.Format = "N0";
                    }

                    if (dgvHoaDon.Columns["Số lượng hoa"] != null)
                    {
                        dgvHoaDon.Columns["Số lượng hoa"]
                            .DefaultCellStyle.Format = "N0";
                    }

                    lblChiTietSub.Text =
                        "Thời gian: " + tuNgay.ToString("dd/MM/yyyy")
                        + " - " + denNgayKeTiep.AddDays(-1)
                            .ToString("dd/MM/yyyy");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể thống kê hóa đơn.\n\n"
                    + "Kiểm tra kết nối database và các cột "
                    + "MaHD, NgayLap, MaKH, SoLuong, ThanhTien.\n\n"
                    + "Chi tiết: " + ex.Message,
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đã xảy ra lỗi khi thống kê:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==================== THEM THAM SO NGAY ====================
        private void ThemThamSoNgay(
            SqlCommand lenh, DateTime tuNgay, DateTime denNgayKeTiep)
        {
            lenh.Parameters.Add(
                "@TuNgay", SqlDbType.DateTime).Value = tuNgay;

            lenh.Parameters.Add(
                "@DenNgay", SqlDbType.DateTime).Value = denNgayKeTiep;
        }
    }
}