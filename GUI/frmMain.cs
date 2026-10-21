using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        private static readonly CultureInfo ViVN = new CultureInfo("vi-VN");
        private readonly Timer clockTimer = new Timer { Interval = 1000 };

        // Thông tin người đang đăng nhập (truyền từ frmDangNhap)
        private readonly string chucVu;
        private readonly string hoTen;
        private readonly string tenDangNhap;

        // frmDangNhap đọc cờ này để biết người dùng bấm "Đăng xuất" hay chỉ tắt cửa sổ
        public bool DaDangXuat { get; private set; }

        // Nhãn báo trống khi chưa có dữ liệu
        private Label lblNoOrders;
        private Label lblNoFlowers;

        // Constructor mặc định để Visual Studio Designer mở được form
        public frmMain() : this(string.Empty, string.Empty, string.Empty)
        {
        }

        public frmMain(string chucVu, string hoTen) : this(chucVu, hoTen, string.Empty)
        {
        }

        public frmMain(string chucVu, string hoTen, string tenDangNhap)
        {
            InitializeComponent();
            this.chucVu = chucVu;
            this.hoTen = hoTen;
            this.tenDangNhap = tenDangNhap;

            TaoNhanTrong();

            Load += frmMain_Load;
            FormClosed += (s, e) => clockTimer.Stop();
            Resize += (s, e) => LayoutDashboard();
            dgvRecentOrders.CellFormatting += DgvRecentOrders_CellFormatting;
            clockTimer.Tick += (s, e) => UpdateClock();

            // Điều hướng sang các chức năng
            btnHome.Click += (s, e) => LoadTrangChu();
            btnSearch.Click += (s, e) => MoFormTimKiem();
            btnFlower.Click += (s, e) => MoFormQuanLyHoa();
            btnCategory.Click += (s, e) => MoFormQuanLyDanhMuc();
            btnStaff.Click += (s, e) => MoFormQuanLyNhanVien();
            btnSale.Click += (s, e) => MoFormQuanLyBanHang();
            btnOrder.Click += (s, e) => MoFormQuanLyBanHang();
            btnChangePass.Click += (s, e) => MoFormDoiMatKhau();
            btnLogout.Click += (s, e) => DangXuat();
            lnkViewAllFlowers.LinkClicked += (s, e) => MoFormQuanLyHoa();
            lnkViewAllOrders.LinkClicked += (s, e) => MoFormQuanLyBanHang();

            ShowUserRole();
        }

        // =====================================================
        // KHỞI TẠO GIAO DIỆN
        // =====================================================

        // Tạo 2 nhãn "trống" nằm đè lên vùng bảng / danh sách, mặc định ẩn
        private void TaoNhanTrong()
        {
            lblNoOrders = new Label
            {
                Text = "Không có đơn hàng gần đây",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10.5F),
                ForeColor = Color.Gray,
                Location = dgvRecentOrders.Location,
                Size = dgvRecentOrders.Size,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Visible = false
            };
            panelRecentOrders.Controls.Add(lblNoOrders);

            lblNoFlowers = new Label
            {
                Text = "Chưa có hoa bán chạy",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10.5F),
                ForeColor = Color.Gray,
                Location = new Point(20, 55),
                Size = new Size(panelTopFlowers.Width - 40, panelTopFlowers.Height - 75),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Visible = false
            };
            panelTopFlowers.Controls.Add(lblNoFlowers);
        }

        // Hiện chức vụ ở góc phải header, giữ nguyên khoảng cách với mép phải
        private void ShowUserRole()
        {
            if (string.IsNullOrWhiteSpace(chucVu)) return;

            lblWelcomeMain.Text = "Xin chào, " +
                (string.IsNullOrWhiteSpace(hoTen) ? chucVu : hoTen) + "!";

            lblAdminName.Text = chucVu;
            lblAdminName.Left = panelHeader.Width - 20 - lblAdminName.Width;
            picAdminAvatar.Left = lblAdminName.Left - 12 - picAdminAvatar.Width;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadHinhAnh();
            LayoutDashboard();
            UpdateClock();
            clockTimer.Start();
            LoadTrangChu();
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

        // =====================================================
        // NẠP DỮ LIỆU TRANG CHỦ
        // =====================================================

        // Nạp lại toàn bộ dữ liệu trang chủ
        private void LoadTrangChu()
        {
            LoadThongKe();

            try { LoadDonHangGanDay(); }
            catch (Exception ex) { BaoLoi("đơn hàng gần đây", ex); }

            try { LoadHoaBanChay(); }
            catch (Exception ex) { BaoLoi("hoa bán chạy", ex); }
        }

        private void BaoLoi(string noiDung, Exception ex)
        {
            MessageBox.Show("Không tải được " + noiDung + ": " + ex.Message, "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // 4 thẻ thống kê: tổng số hoa, đơn hàng hôm nay, doanh thu hôm nay, nhân viên
        private void LoadThongKe()
        {
            try
            {
                lblStat1Num.Text = FlowerBUS.DemSoHoa().ToString();
            }
            catch (Exception ex)
            {
                lblStat1Num.Text = "0";
                BaoLoi("tổng số hoa", ex);
            }

            try
            {
                lblStat2Num.Text = DonHangBUS.DemDonHomNay().ToString();
                lblStat3Num.Text = DonHangBUS.DoanhThuHomNay().ToString("N0", ViVN) + "đ";
            }
            catch (Exception ex)
            {
                lblStat2Num.Text = "0";
                lblStat3Num.Text = "0đ";
                BaoLoi("số liệu đơn hàng hôm nay", ex);
            }

            try
            {
                lblStat4Num.Text = NhanVienBUS.DemSoNhanVien().ToString();
            }
            catch (Exception ex)
            {
                lblStat4Num.Text = "0";
                BaoLoi("số lượng nhân viên", ex);
            }
        }

        // "Đơn hàng gần đây": 5 đơn mới nhất từ form Quản lý bán hàng
        private void LoadDonHangGanDay()
        {
            dgvRecentOrders.Rows.Clear();

            List<DonHangDTO> ds = DonHangBUS.LayDonHangGanDay(5);
            foreach (DonHangDTO dh in ds)
            {
                dgvRecentOrders.Rows.Add(
                    dh.MaDon,
                    dh.KhachHang,
                    dh.NgayDat.ToString("dd/MM/yyyy"),
                    dh.TongTien.ToString("N0", ViVN) + "đ",
                    dh.TrangThai);
            }
            dgvRecentOrders.ClearSelection();

            bool coDon = ds.Count > 0;
            dgvRecentOrders.Visible = coDon;
            lblNoOrders.Visible = !coDon;
        }

        // "Hoa bán chạy": top 3 hoa theo số lượng đã bán
        private void LoadHoaBanChay()
        {
            Panel[] panels = { panelFlower1, panelFlower2, panelFlower3 };
            Label[] names = { lblFlower1Name, lblFlower2Name, lblFlower3Name };
            Label[] sales = { lblFlower1Sales, lblFlower2Sales, lblFlower3Sales };

            List<HoaBanChayDTO> ds = DonHangBUS.LayHoaBanChay(panels.Length);
            for (int i = 0; i < panels.Length; i++)
            {
                bool co = i < ds.Count;
                panels[i].Visible = co;
                if (co)
                {
                    names[i].Text = ds[i].TenHoa;
                    sales[i].Text = "Đã bán: " + ds[i].DaBan;
                }
            }

            lblNoFlowers.Visible = ds.Count == 0;
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

        // =====================================================
        // ĐIỀU HƯỚNG SANG CÁC FORM CHỨC NĂNG
        // =====================================================

        // Mở form Tìm kiếm
        private void MoFormTimKiem()
        {
            MessageBox.Show("Chức năng Tìm kiếm đang được phát triển.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mở form Quản lý hoa (hiện chồng lên frmMain, đóng lại là quay về trang chủ)
        private void MoFormQuanLyHoa()
        {
            using (frmQuanLyHoa frm = new frmQuanLyHoa())
            {
                frm.ShowDialog(this);
            }
            LoadTrangChu();
        }

        // Mở form Quản lý danh mục
        private void MoFormQuanLyDanhMuc()
        {
            using (frmQuanLyDanhMuc frm = new frmQuanLyDanhMuc())
            {
                frm.ShowDialog(this);
            }
        }

        // Mở form Quản lý nhân viên
        private void MoFormQuanLyNhanVien()
        {
             using (frmQuanLyNhanVien frm = new frmQuanLyNhanVien())
            {
                frm.ShowDialog();
            }
        }

        // Mở form Quản lý bán hàng, đóng lại thì nạp lại trang chủ để thấy đơn mới
        private void MoFormQuanLyBanHang()
        {
            using (frmQuanLyBanHang frm = new frmQuanLyBanHang())
            {
                frm.ShowDialog();
            }
        }

        // Mở form Đổi mật khẩu
        private void MoFormDoiMatKhau()
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Không xác định được tài khoản đang đăng nhập.\nHãy đăng xuất rồi đăng nhập lại.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmDoiMatKhau frm = new frmDoiMatKhau(tenDangNhap))
            {
                frm.ShowDialog(this);
            }
        }

        // Đăng xuất: đóng trang chủ, frmDangNhap sẽ hiện lại (xem frmDangNhap.btnDangNhap_Click)
        private void DangXuat()
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DaDangXuat = true;   // phải gán TRƯỚC khi Close
            Close();
        }

        // =====================================================
        // HÌNH ẢNH
        // =====================================================

        // Lấy ảnh từ Resources theo tên; trả về null nếu chưa thêm ảnh (không gây lỗi)
        private static Image LayAnh(string ten)
        {
            return Properties.Resources.ResourceManager.GetObject(ten) as Image;
        }

        // Gắn icon vào nút menu. Chữ trên nút đã có sẵn khoảng trắng đầu dòng để chừa chỗ cho icon
        private void GanIconNut(Button btn, string tenAnh, int size = 22)
        {
            Image img = LayAnh(tenAnh);
            if (img == null) return;

            btn.Image = new Bitmap(img, new Size(size, size));
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleLeft;
        }

        // Gắn ảnh vào PictureBox, giữ nguyên tỉ lệ
        private void GanAnhPic(PictureBox pic, string tenAnh)
        {
            Image img = LayAnh(tenAnh);
            if (img == null) return;

            pic.Image = img;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Gắn ảnh nhỏ vào giữa ô vuông màu (giữ nền pastel xung quanh)
        private void GanAnhThe(PictureBox pic, string tenAnh, int size = 32)
        {
            Image img = LayAnh(tenAnh);
            if (img == null) return;

            pic.Image = new Bitmap(img, new Size(size, size));
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void LoadHinhAnh()
        {
            // Logo
            GanAnhPic(picLogoIcon, "logo");

            // Menu bên trái
            GanIconNut(btnSearch, "icon_timkiem");
            GanIconNut(btnHome, "icon_home");
            GanIconNut(btnFlower, "icon_hoa");
            GanIconNut(btnCategory, "icon_danhmuc");
            GanIconNut(btnStaff, "icon_nhanvien");
            GanIconNut(btnSale, "icon_banhang");
            GanIconNut(btnOrder, "icon_donhang");
            GanIconNut(btnStatistics, "icon_thongke");
            GanIconNut(btnChangePass, "icon_matkhau");
            GanIconNut(btnLogout, "icon_dangxuat");

            // 4 thẻ thống kê
            GanAnhThe(picStat1, "stat_hoa");
            GanAnhThe(picStat2, "stat_donhang");
            GanAnhThe(picStat3, "stat_doanhthu");
            GanAnhThe(picStat4, "stat_nhanvien");
            GanAnhThe(picAdminAvatar, "avatar_admin");
        }
    }
}