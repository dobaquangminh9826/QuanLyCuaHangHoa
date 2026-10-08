using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI // Hoặc namespace WindowsFormsApp1 tùy dự án của bạn
{
    public partial class frmMain : Form
    {
        private string chucVuUser;

        // Cập nhật hàm khởi tạo nhận 1 tham số truyền vào
        public frmMain(string chucVu)
        {
            InitializeComponent();
            this.chucVuUser = chucVu;
        }

        // Tùy chọn: Thêm constructor mặc định để tránh lỗi thiết kế nếu cần
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblChucVu.Text = "Chức vụ: " + chucVuUser;
        }

        private void btnQuanLyHoa_Click(object sender, EventArgs e)
        {
            frmQuanLyHoa frm = new frmQuanLyHoa();
            frm.ShowDialog();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chức năng quản lý nhân viên đang được xây dựng!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        } 
    }
}