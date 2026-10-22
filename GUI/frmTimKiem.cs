using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmTimKiem : Form
    {
        private string currentTab = "Hoa";
        private string connectionString = @"Data Source=localhost;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";
        public frmTimKiem()
        {
            InitializeComponent();
            if (txtTimKiem != null)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Gray;
            }
            DangKySuKienClick();
        }
        private void DangKySuKienClick()
        {
            if (btnHoa != null) btnHoa.Click += (s, e) => ChuyenTab("Hoa");
            if (btnKhachHang != null) btnKhachHang.Click += (s, e) => ChuyenTab("KhachHang");
            if (btnHoaDon != null) btnHoaDon.Click += (s, e) => ChuyenTab("HoaDon");

            if (btnTimKiem != null) btnTimKiem.Click += btnTimKiem_Click;
            if (btnLamMoi != null) btnLamMoi.Click += btnLamMoi_Click;
        }
        private void LoadDataFromSQL(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgKetQua.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChuyenTab(string tabName)
        {
            currentTab = tabName;
            dtgKetQua.DataSource = null;
            dtgKetQua.Rows.Clear();
            dtgKetQua.Columns.Clear();

            if (tabName == "Hoa")
            {
                txtTimKiem.Text = "";
            }
            else if (tabName == "KhachHang")
            {
                txtTimKiem.Text = "";
            }
            else if (tabName == "HoaDon")
            {
                txtTimKiem.Text = "";
            }

            txtTimKiem.ForeColor = Color.Gray;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword) || keyword.Contains("Nhập"))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!");
                return;
            }

            string query = "";

            if (currentTab == "Hoa")
            {
                query = @"SELECT MaHoa AS [Mã hoa],
                         TenHoa AS [Tên hoa],
                         MaDanhMuc AS [Mã danh mục],
                         GiaBan AS [Giá bán],
                         SoLuongTon AS [Số lượng tồn]
                  FROM Hoa
                  WHERE MaHoa LIKE @keyword
                     OR TenHoa LIKE @keyword";
            }
            else if (currentTab == "KhachHang")
            {
                query = @"SELECT MaKH AS [Mã khách hàng],
                         HoTen AS [Họ tên],
                         SoDienThoai AS [Số điện thoại]
                  FROM KhachHang
                  WHERE MaKH LIKE @keyword
                     OR HoTen LIKE @keyword";
            }
            else if (currentTab == "HoaDon")
            {
                query = @"SELECT MaHD AS [Mã hóa đơn],
                         NgayLap AS [Ngày lập],
                         MaNV AS [Mã nhân viên],
                         MaKH AS [Mã khách hàng],
                         TongTien AS [Tổng tiền]
                  FROM HoaDon
                  WHERE MaHD LIKE @keyword
                     OR MaKH LIKE @keyword";
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgKetQua.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu phù hợp!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }    
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            dtgKetQua.DataSource = null;
            dtgKetQua.Rows.Clear();
            dtgKetQua.Columns.Clear();
        }
    }
}
