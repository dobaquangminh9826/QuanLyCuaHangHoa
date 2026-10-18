using System;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class frmDoiMatKhau : Form
    {
        private readonly string _taiKhoan;

        public frmDoiMatKhau(string taiKhoan)
        {
            InitializeComponent();
            _taiKhoan = taiKhoan;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Trim giống form đăng nhập để đăng nhập lại không bị lỗi
            string cu = txtMatKhauCu.Text.Trim();
            string moi = txtMatKhauMoi.Text.Trim();
            string xacNhan = txtXacNhan.Text.Trim();

            if (cu.Length == 0 || moi.Length == 0 || xacNhan.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!NhanVienBUS.KiemTraMatKhau(_taiKhoan, cu))
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauCu.Clear();
                    txtMatKhauCu.Focus();
                    return;
                }
                if (moi.Length < 6)
                {
                    MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauMoi.Focus();
                    return;
                }
                if (moi == cu)
                {
                    MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauMoi.Focus();
                    return;
                }
                if (moi != xacNhan)
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtXacNhan.Focus();
                    return;
                }

                if (NhanVienBUS.DoiMatKhau(_taiKhoan, moi))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại, vui lòng thử lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}