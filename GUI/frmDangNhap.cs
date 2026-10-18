using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            LoadHinhAnh();
        }


        // Kiểm tra mật khẩu hiện tại theo tài khoản
        public static bool KiemTraMatKhau(string taiKhoan, string matKhau)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";
            SqlParameter[] parameters = {
        new SqlParameter("@tk", taiKhoan),
        new SqlParameter("@mk", matKhau)
        };
            DataTable dt = Database.GetData(query, parameters);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        // Đổi mật khẩu theo tài khoản
        public static bool DoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            string query = "UPDATE NhanVien SET MatKhau = @mk WHERE TaiKhoan = @tk";
            SqlParameter[] parameters = {
        new SqlParameter("@tk", taiKhoan),
        new SqlParameter("@mk", matKhauMoi)
        };
            return Database.ExecuteNonQuery(query, parameters);
        }
        // Lấy ảnh từ Resources theo tên; trả về null nếu chưa có (không gây lỗi)
        private static Image LayAnh(string ten)
        {
            return Properties.Resources.ResourceManager.GetObject(ten) as Image;
        }

        private void GanAnhPic(PictureBox pic, string tenAnh)
        {
            Image img = LayAnh(tenAnh);
            if (img == null) return;

            pic.Image = img;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void LoadHinhAnh()
        {
            GanAnhPic(picLogoIcon, "logo");
        }

        // =====================================================
        // NÚT ĐĂNG NHẬP
        // =====================================================
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (taiKhoan.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }

            if (matKhau.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            DataTable dt;
            try
            {
                dt = NhanVienBUS.DangNhap(taiKhoan, matKhau);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối hoặc xử lý đăng nhập: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!",
                    "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            // Đăng nhập thành công: lấy thông tin từ SQL
            string chucVu = Convert.ToString(dt.Rows[0]["ChucVu"]);
            string hoTen = Convert.ToString(dt.Rows[0]["HoTen"]);

            // Ưu tiên tên đăng nhập trả về từ SQL (đúng hoa/thường), không có thì dùng chữ vừa gõ
            string tenDangNhap = dt.Columns.Contains("TaiKhoan")
                  ? Convert.ToString(dt.Rows[0]["TaiKhoan"])
                  : taiKhoan;

            bool dangXuat;
            using (frmMain mainForm = new frmMain(chucVu, hoTen, tenDangNhap))
            {
                mainForm.ShowDialog();
                dangXuat = mainForm.DaDangXuat;
            }

            if (dangXuat)
            {
                // Bấm "Đăng xuất" ở trang chủ: quay lại màn hình đăng nhập với ô trống
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                chkHienMatKhau.Checked = false;
                Show();
                txtTaiKhoan.Focus();
            }
            else
            {
                // Tắt cửa sổ chính bằng nút X: thoát chương trình
                Close();
            }
        }

        // =====================================================
        // NÚT THOÁT
        // =====================================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =====================================================
        // HIỆN / ẨN MẬT KHẨU
        // =====================================================
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }
    }
}