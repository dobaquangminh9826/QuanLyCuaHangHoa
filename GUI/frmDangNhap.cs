using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            LoadHinhAnh();
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

            // Đăng nhập thành công: mở trang chủ, truyền chức vụ lấy từ SQL
            string chucVu = Convert.ToString(dt.Rows[0]["ChucVu"]);
            string hoTen = Convert.ToString(dt.Rows[0]["HoTen"]);

            Hide();
            using (frmMain mainForm = new frmMain(chucVu, hoTen))
            {
                mainForm.ShowDialog();
            }
            Close();
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