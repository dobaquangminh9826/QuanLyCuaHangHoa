using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmLichSuBanHang : Form
    {
        private string connectionString = @"Data Source=LAPTOP-1JDF0EDQ;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";

        public frmLichSuBanHang()
        {
            InitializeComponent();
            dtpTuNgay.Value = DateTime.Now.AddDays(-7);
            dtpDenNgay.Value = DateTime.Now;
            TaiDanhSachHoaDon();
        }

        private void TaiDanhSachHoaDon()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT MaHD AS [Mã Đơn], NgayLap AS [Ngày Lập], TenKhach AS [Tên Khách], 
                                            SoDienThoai AS [SĐT], 
                                            NoiDungThiep AS [Nội Dung Thiệp / Băng Rôn], 
                                            PhuongThucTT AS [Thanh Toán], TongTien AS [Tổng Tiền]
                                     FROM HoaDon 
                                     WHERE CAST(NgayLap AS DATE) >= @TuNgay AND CAST(NgayLap AS DATE) <= @DenNgay ";

                    if (!string.IsNullOrEmpty(txtSDT.Text.Trim()))
                    {
                        query += " AND SoDienThoai LIKE @SDT ";
                    }
                    query += " ORDER BY NgayLap DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                        cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);
                        if (!string.IsNullOrEmpty(txtSDT.Text.Trim()))
                            cmd.Parameters.AddWithValue("@SDT", "%" + txtSDT.Text.Trim() + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvHoaDon.DataSource = dt;
                    }
                }

                if (dgvHoaDon.Columns.Contains("Tổng Tiền"))
                    dgvHoaDon.Columns["Tổng Tiền"].DefaultCellStyle.Format = "#,##0 VNĐ";

                dgvChiTiet.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu hóa đơn: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            TaiDanhSachHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object val = dgvHoaDon.Rows[e.RowIndex].Cells["Mã Đơn"].Value;
                if (val != null)
                {
                    string maHD = val.ToString();
                    TaiChiTietHoaDon(maHD);
                }
            }
        }

        private void TaiChiTietHoaDon(string maHD)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT h.TenHoa AS [Tên Sản Phẩm], 
                                            ct.SoLuong AS [Số Lượng], 
                                            ct.DonGia AS [Đơn Giá], 
                                            (ct.SoLuong * ct.DonGia) AS [Thành Tiền]
                                     FROM ChiTietHoaDon ct
                                     JOIN Hoa h ON ct.MaHoa = h.MaHoa
                                     WHERE ct.MaHD = @MaHD";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvChiTiet.DataSource = dt;
                    }
                }

                if (dgvChiTiet.Columns.Contains("Đơn Giá"))
                    dgvChiTiet.Columns["Đơn Giá"].DefaultCellStyle.Format = "#,##0 VNĐ";
                if (dgvChiTiet.Columns.Contains("Thành Tiền"))
                    dgvChiTiet.Columns["Thành Tiền"].DefaultCellStyle.Format = "#,##0 VNĐ";

                dgvChiTiet.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy chi tiết hóa đơn: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiTiet_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}