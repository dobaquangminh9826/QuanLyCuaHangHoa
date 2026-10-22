using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmThongKe : Form
    {
        // Khai báo chuỗi kết nối chuẩn
        private string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKeDoanhThu_Click(object sender, System.EventArgs e)
        {
            frmThongKeDoanhThu frm = new frmThongKeDoanhThu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadTongQuanData();
        }

        private void btnThongKeSoLuong_Click(object sender, System.EventArgs e)
        {
            frmThongKeSoLuongHoa frm = new frmThongKeSoLuongHoa();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadTongQuanData();
        }

        private void btnThongKeHoaDon_Click(object sender, System.EventArgs e)
        {
            frmThongKeHoaDon frm = new frmThongKeHoaDon();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadTongQuanData();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadTongQuanData();
        }

        private void LoadTongQuanData()
        {
            try
            {
                decimal tongDoanhThu = LayTongDoanhThu();
                int tongSoLuongHoa = LayTongSoLuongHoa();
                int tongHoaDon = LayTongSoLuongHoaDon();

                // Hiển thị lên giao diện
                lblDoanhThuValue.Text = string.Format("{0:N0} đ", tongDoanhThu);
                lblSoLuongValue.Text = tongSoLuongHoa.ToString("N0");
                lblHoaDonValue.Text = tongHoaDon.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu tổng quan: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1. Hàm lấy tổng doanh thu từ bảng Hóa đơn
        private decimal LayTongDoanhThu()
        {
            decimal doanhThu = 0;
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi)) // Đã sửa thành chuoiKetNoi
            {
                conn.Open();
                string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        decimal.TryParse(result.ToString(), out doanhThu);
                    }
                }
            }
            return doanhThu;
        }

        // 2. Hàm lấy tổng số lượng hoa đã bán từ bảng Chi Tiết Hóa Đơn
        private int LayTongSoLuongHoa()
        {
            int soLuong = 0;
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi)) // Đã sửa thành chuoiKetNoi
            {
                conn.Open();
                string query = "SELECT ISNULL(SUM(SoLuong), 0) FROM ChiTietHoaDon";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out soLuong);
                    }
                }
            }
            return soLuong;
        }

        // 3. Hàm lấy tổng số hóa đơn
        private int LayTongSoLuongHoaDon()
        {
            int soHoaDon = 0;
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi)) // Đã sửa thành chuoiKetNoi
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM HoaDon";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out soHoaDon);
                    }
                }
            }
            return soHoaDon;
        }

        private void btnThongKeDoanhThu_Click_1(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frm = new frmThongKeDoanhThu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadTongQuanData();
        }

        private void btnThongKeSoLuong_Click_1(object sender, EventArgs e)
        {
            frmThongKeSoLuongHoa frm = new frmThongKeSoLuongHoa();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadTongQuanData();
        }

        private void btnThongKeHoaDon_Click_1(object sender, EventArgs e)
        {
            frmThongKeHoaDon frm = new frmThongKeHoaDon();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadTongQuanData();
        }
    }
}