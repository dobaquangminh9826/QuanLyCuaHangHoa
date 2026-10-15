using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        private static readonly CultureInfo ViVN = new CultureInfo("vi-VN");
        private readonly Timer clockTimer = new Timer { Interval = 1000 };

        // Chức vụ của người dùng đang đăng nhập (truyền từ frmDangNhap)
        private readonly string chucVu;

        // Constructor mặc định để Visual Studio Designer mở được form
        public frmMain() : this(string.Empty)
        {
        }

        public frmMain(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;

            Load += frmMain_Load;
            Resize += (s, e) => LayoutDashboard();
            dgvRecentOrders.CellFormatting += DgvRecentOrders_CellFormatting;
            clockTimer.Tick += (s, e) => UpdateClock();

            // Điều hướng sang các form chức năng
            btnFlower.Click += (s, e) => MoFormQuanLyHoa();
            lnkViewAllFlowers.LinkClicked += (s, e) => MoFormQuanLyHoa();

            ShowUserRole();
        }

        // Hiện chức vụ ở góc phải header, giữ nguyên khoảng cách với mép phải
        private void ShowUserRole()
        {
            if (string.IsNullOrWhiteSpace(chucVu)) return;

            lblAdminName.Text = chucVu;
            lblAdminName.Left = panelHeader.Width - 20 - lblAdminName.Width;
            picAdminAvatar.Left = lblAdminName.Left - 12 - picAdminAvatar.Width;

            // Phân quyền (ví dụ): chỉ cho quản lý xem nhân viên và thống kê
            // bool laQuanLy = chucVu == "Quản lý";
            // btnStaff.Visible = laQuanLy;
            // btnReport.Visible = laQuanLy;
        }

        // Mở form Quản lý hoa (hiện chồng lên frmMain, đóng lại là quay về trang chủ)
        private void MoFormQuanLyHoa()
        {
            using (frmQuanLyHoa frm = new frmQuanLyHoa())
            {
                frm.ShowDialog(this);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LayoutDashboard();
            UpdateClock();
            clockTimer.Start();
            LoadSampleOrders();
        }

        // Tự co giãn bố cục theo kích thước cửa sổ, tránh bị cắt mất phần bên phải
        private void LayoutDashboard()
        {
            const int left = 240, right = 20, gap = 20, top = 280, bottom = 20;
            int contentWidth = ClientSize.Width - left - right;
            int height = ClientSize.Height - top - bottom;
            if (contentWidth < 600 || height < 200) return;

            SuspendLayout();

            panelHeader.SetBounds(left, 20, contentWidth, 110);

            Panel[] cards = { panelStats1, panelStats2, panelStats3, panelStats4 };
            int cardW = (contentWidth - 3 * gap) / 4;
            for (int i = 0; i < cards.Length; i++)
                cards[i].SetBounds(left + i * (cardW + gap), 150, cardW, 110);

            int flowersW = Math.Max(340, contentWidth * 3 / 10);
            int ordersW = contentWidth - flowersW - gap;
            panelRecentOrders.SetBounds(left, top, ordersW, height);
            panelTopFlowers.SetBounds(left + ordersW + gap, top, flowersW, height);

            int innerW = flowersW - 40;
            panelFlower1.Width = panelFlower2.Width = panelFlower3.Width = innerW;

            ResumeLayout(true);
        }

        private void UpdateClock()
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm", ViVN);
        }

        // Dữ liệu mẫu, sau này thay bằng dữ liệu từ database
        private void LoadSampleOrders()
        {
            dgvRecentOrders.Rows.Clear();
            dgvRecentOrders.Rows.Add("DH001", "Nguyễn Văn An", "13/10/2025", "850.000đ", "Hoàn thành");
            dgvRecentOrders.Rows.Add("DH002", "Trần Thị Bình", "13/10/2025", "1.200.000đ", "Đang giao");
            dgvRecentOrders.Rows.Add("DH003", "Lê Minh Châu", "12/10/2025", "450.000đ", "Chờ xác nhận");
            dgvRecentOrders.Rows.Add("DH004", "Phạm Quốc Dũng", "12/10/2025", "2.300.000đ", "Hoàn thành");
            dgvRecentOrders.Rows.Add("DH005", "Hoàng Thu Hà", "11/10/2025", "680.000đ", "Đã hủy");
            dgvRecentOrders.ClearSelection();
        }

        // Tô màu cột Trạng thái
        private void DgvRecentOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colTrangThai.Index || e.Value == null) return;

            switch (e.Value.ToString())
            {
                case "Hoàn thành":
                    e.CellStyle.ForeColor = Color.FromArgb(46, 125, 50);
                    break;
                case "Đang giao":
                    e.CellStyle.ForeColor = Color.FromArgb(25, 118, 210);
                    break;
                case "Chờ xác nhận":
                    e.CellStyle.ForeColor = Color.FromArgb(239, 108, 0);
                    break;
                case "Đã hủy":
                    e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);
                    break;
            }
        }
    }
}
