using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            panelSidebar = new Panel();
            lblTime = new Label();
            btnLogout = new Button();
            btnChangePass = new Button();
            btnReport = new Button();
            btnOrder = new Button();
            btnStaff = new Button();
            btnCategory = new Button();
            btnFlower = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            lblSubLogo = new Label();
            lblMainLogo = new Label();
            picLogoIcon = new PictureBox();
            panelHeader = new Panel();
            lblAdminName = new Label();
            picAdminAvatar = new PictureBox();
            lblWelcomeSub = new Label();
            lblWelcomeMain = new Label();
            panelStats1 = new Panel();
            lblStat1Num = new Label();
            lblStat1Title = new Label();
            picStat1 = new PictureBox();
            panelStats2 = new Panel();
            lblStat2Num = new Label();
            lblStat2Title = new Label();
            picStat2 = new PictureBox();
            panelStats3 = new Panel();
            lblStat3Num = new Label();
            lblStat3Title = new Label();
            picStat3 = new PictureBox();
            panelStats4 = new Panel();
            lblStat4Num = new Label();
            lblStat4Title = new Label();
            picStat4 = new PictureBox();
            panelRecentOrders = new Panel();
            lnkViewAllOrders = new LinkLabel();
            dgvRecentOrders = new DataGridView();
            colMaDon = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            colNgayDat = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            lblRecentOrdersTitle = new Label();
            panelTopFlowers = new Panel();
            lnkViewAllFlowers = new LinkLabel();
            lblTopFlowersTitle = new Label();
            panelFlower1 = new Panel();
            lblFlower1Sales = new Label();
            lblFlower1Name = new Label();
            picFlower1 = new PictureBox();
            panelFlower2 = new Panel();
            lblFlower2Sales = new Label();
            lblFlower2Name = new Label();
            picFlower2 = new PictureBox();
            panelFlower3 = new Panel();
            lblFlower3Sales = new Label();
            lblFlower3Name = new Label();
            picFlower3 = new PictureBox();

            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoIcon).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdminAvatar).BeginInit();
            panelStats1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStat1).BeginInit();
            panelStats2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStat2).BeginInit();
            panelStats3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStat3).BeginInit();
            panelStats4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStat4).BeginInit();
            panelRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).BeginInit();
            panelTopFlowers.SuspendLayout();
            panelFlower1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower1).BeginInit();
            panelFlower2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower2).BeginInit();
            panelFlower3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower3).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(lblTime);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnChangePass);
            panelSidebar.Controls.Add(btnReport);
            panelSidebar.Controls.Add(btnOrder);
            panelSidebar.Controls.Add(btnStaff);
            panelSidebar.Controls.Add(btnCategory);
            panelSidebar.Controls.Add(btnFlower);
            panelSidebar.Controls.Add(btnHome);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 720);
            panelSidebar.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Gray;
            lblTime.Location = new Point(15, 690);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(160, 15);
            lblTime.TabIndex = 9;
            lblTime.Text = "Thứ Hai, 13/10/2025 14:32";
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.DimGray;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 480);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(220, 40);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "      Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI", 10F);
            btnChangePass.ForeColor = Color.DimGray;
            btnChangePass.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangePass.Location = new Point(0, 435);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Padding = new Padding(15, 0, 0, 0);
            btnChangePass.Size = new Size(220, 40);
            btnChangePass.TabIndex = 7;
            btnChangePass.Text = "      Đổi mật khẩu";
            btnChangePass.TextAlign = ContentAlignment.MiddleLeft;
            btnChangePass.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 10F);
            btnReport.ForeColor = Color.DimGray;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 390);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(15, 0, 0, 0);
            btnReport.Size = new Size(220, 40);
            btnReport.TabIndex = 6;
            btnReport.Text = "      Thống kê";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 10F);
            btnOrder.ForeColor = Color.DimGray;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(0, 345);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(15, 0, 0, 0);
            btnOrder.Size = new Size(220, 40);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "      Quản lý đơn hàng";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Segoe UI", 10F);
            btnStaff.ForeColor = Color.DimGray;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(0, 300);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(15, 0, 0, 0);
            btnStaff.Size = new Size(220, 40);
            btnStaff.TabIndex = 4;
            btnStaff.Text = "      Quản lý nhân viên";
            btnStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 10F);
            btnCategory.ForeColor = Color.DimGray;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 255);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(15, 0, 0, 0);
            btnCategory.Size = new Size(220, 40);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "      Quản lý danh mục";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnFlower
            // 
            btnFlower.FlatAppearance.BorderSize = 0;
            btnFlower.FlatStyle = FlatStyle.Flat;
            btnFlower.Font = new Font("Segoe UI", 10F);
            btnFlower.ForeColor = Color.DimGray;
            btnFlower.ImageAlign = ContentAlignment.MiddleLeft;
            btnFlower.Location = new Point(0, 210);
            btnFlower.Name = "btnFlower";
            btnFlower.Padding = new Padding(15, 0, 0, 0);
            btnFlower.Size = new Size(220, 40);
            btnFlower.TabIndex = 2;
            btnFlower.Text = "      Quản lý hoa";
            btnFlower.TextAlign = ContentAlignment.MiddleLeft;
            btnFlower.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(253, 237, 237);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(224, 98, 103);
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 165);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(15, 0, 0, 0);
            btnHome.Size = new Size(220, 40);
            btnHome.TabIndex = 1;
            btnHome.Text = "      Trang chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblSubLogo);
            panelLogo.Controls.Add(lblMainLogo);
            panelLogo.Controls.Add(picLogoIcon);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 150);
            panelLogo.TabIndex = 0;
            // 
            // lblSubLogo
            // 
            lblSubLogo.AutoSize = true;
            lblSubLogo.Font = new Font("Segoe UI", 8.5F);
            lblSubLogo.ForeColor = Color.Gray;
            lblSubLogo.Location = new Point(68, 62);
            lblSubLogo.Name = "lblSubLogo";
            lblSubLogo.Size = new Size(102, 15);
            lblSubLogo.TabIndex = 2;
            lblSubLogo.Text = "Hoa tươi mỗi ngày";
            // 
            // lblMainLogo
            // 
            lblMainLogo.AutoSize = true;
            lblMainLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMainLogo.ForeColor = Color.FromArgb(50, 50, 50);
            lblMainLogo.Location = new Point(67, 38);
            lblMainLogo.Name = "lblMainLogo";
            lblMainLogo.Size = new Size(121, 21);
            lblMainLogo.TabIndex = 1;
            lblMainLogo.Text = "Cửa Hàng Hoa";
            // 
            // picLogoIcon
            // 
            picLogoIcon.BackColor = Color.FromArgb(253, 237, 237);
            picLogoIcon.Location = new Point(22, 38);
            picLogoIcon.Name = "picLogoIcon";
            picLogoIcon.Size = new Size(40, 40);
            picLogoIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogoIcon.TabIndex = 0;
            picLogoIcon.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.FromArgb(253, 242, 242);
            panelHeader.Controls.Add(lblAdminName);
            panelHeader.Controls.Add(picAdminAvatar);
            panelHeader.Controls.Add(lblWelcomeSub);
            panelHeader.Controls.Add(lblWelcomeMain);
            panelHeader.Location = new Point(240, 20);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1020, 110);
            panelHeader.TabIndex = 1;
            // 
            // lblAdminName
            // 
            lblAdminName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdminName.Location = new Point(925, 45);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(47, 19);
            lblAdminName.TabIndex = 3;
            lblAdminName.Text = "Admin";
            // 
            // picAdminAvatar
            // 
            picAdminAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picAdminAvatar.BackColor = Color.FromArgb(224, 98, 103);
            picAdminAvatar.Location = new Point(880, 39);
            picAdminAvatar.Name = "picAdminAvatar";
            picAdminAvatar.Size = new Size(32, 32);
            picAdminAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdminAvatar.TabIndex = 2;
            picAdminAvatar.TabStop = false;
            // 
            // lblWelcomeSub
            // 
            lblWelcomeSub.AutoSize = true;
            lblWelcomeSub.Font = new Font("Segoe UI", 9.5F);
            lblWelcomeSub.ForeColor = Color.DimGray;
            lblWelcomeSub.Location = new Point(25, 62);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(228, 17);
            lblWelcomeSub.TabIndex = 1;
            lblWelcomeSub.Text = "Chúc bạn một ngày làm việc hiệu quả!";
            // 
            // lblWelcomeMain
            // 
            lblWelcomeMain.AutoSize = true;
            lblWelcomeMain.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcomeMain.ForeColor = Color.FromArgb(40, 40, 40);
            lblWelcomeMain.Location = new Point(23, 22);
            lblWelcomeMain.Name = "lblWelcomeMain";
            lblWelcomeMain.Size = new Size(190, 30);
            lblWelcomeMain.TabIndex = 0;
            lblWelcomeMain.Text = "Xin chào, Admin!";
            // 
            // panelStats1
            // 
            panelStats1.BackColor = Color.White;
            panelStats1.Controls.Add(lblStat1Num);
            panelStats1.Controls.Add(lblStat1Title);
            panelStats1.Controls.Add(picStat1);
            panelStats1.Location = new Point(240, 150);
            panelStats1.Name = "panelStats1";
            panelStats1.Size = new Size(240, 110);
            panelStats1.TabIndex = 2;
            // 
            // lblStat1Num
            // 
            lblStat1Num.AutoSize = true;
            lblStat1Num.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStat1Num.ForeColor = Color.FromArgb(40, 40, 40);
            lblStat1Num.Location = new Point(95, 22);
            lblStat1Num.Name = "lblStat1Num";
            lblStat1Num.Size = new Size(55, 37);
            lblStat1Num.TabIndex = 0;
            lblStat1Num.Text = "128";
            // 
            // lblStat1Title
            // 
            lblStat1Title.AutoSize = true;
            lblStat1Title.Font = new Font("Segoe UI", 10F);
            lblStat1Title.ForeColor = Color.Gray;
            lblStat1Title.Location = new Point(97, 66);
            lblStat1Title.Name = "lblStat1Title";
            lblStat1Title.Size = new Size(73, 19);
            lblStat1Title.TabIndex = 1;
            lblStat1Title.Text = "Tổng số hoa";
            // 
            // picStat1
            // 
            picStat1.BackColor = Color.FromArgb(253, 237, 237);
            picStat1.Location = new Point(20, 27);
            picStat1.Name = "picStat1";
            picStat1.Size = new Size(56, 56);
            picStat1.SizeMode = PictureBoxSizeMode.StretchImage;
            picStat1.TabIndex = 2;
            picStat1.TabStop = false;
            // 
            // panelStats2
            // 
            panelStats2.BackColor = Color.White;
            panelStats2.Controls.Add(lblStat2Num);
            panelStats2.Controls.Add(lblStat2Title);
            panelStats2.Controls.Add(picStat2);
            panelStats2.Location = new Point(500, 150);
            panelStats2.Name = "panelStats2";
            panelStats2.Size = new Size(240, 110);
            panelStats2.TabIndex = 3;
            // 
            // lblStat2Num
            // 
            lblStat2Num.AutoSize = true;
            lblStat2Num.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStat2Num.ForeColor = Color.FromArgb(40, 40, 40);
            lblStat2Num.Location = new Point(95, 22);
            lblStat2Num.Name = "lblStat2Num";
            lblStat2Num.Size = new Size(38, 37);
            lblStat2Num.TabIndex = 0;
            lblStat2Num.Text = "24";
            // 
            // lblStat2Title
            // 
            lblStat2Title.AutoSize = true;
            lblStat2Title.Font = new Font("Segoe UI", 10F);
            lblStat2Title.ForeColor = Color.Gray;
            lblStat2Title.Location = new Point(97, 66);
            lblStat2Title.Name = "lblStat2Title";
            lblStat2Title.Size = new Size(121, 19);
            lblStat2Title.TabIndex = 1;
            lblStat2Title.Text = "Đơn hàng hôm nay";
            // 
            // picStat2
            // 
            picStat2.BackColor = Color.FromArgb(232, 245, 233);
            picStat2.Location = new Point(20, 27);
            picStat2.Name = "picStat2";
            picStat2.Size = new Size(56, 56);
            picStat2.SizeMode = PictureBoxSizeMode.StretchImage;
            picStat2.TabIndex = 2;
            picStat2.TabStop = false;
            // 
            // panelStats3
            // 
            panelStats3.BackColor = Color.White;
            panelStats3.Controls.Add(lblStat3Num);
            panelStats3.Controls.Add(lblStat3Title);
            panelStats3.Controls.Add(picStat3);
            panelStats3.Location = new Point(760, 150);
            panelStats3.Name = "panelStats3";
            panelStats3.Size = new Size(240, 110);
            panelStats3.TabIndex = 4;
            // 
            // lblStat3Num
            // 
            lblStat3Num.AutoSize = true;
            lblStat3Num.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStat3Num.ForeColor = Color.FromArgb(40, 40, 40);
            lblStat3Num.Location = new Point(95, 26);
            lblStat3Num.Name = "lblStat3Num";
            lblStat3Num.Size = new Size(123, 30);
            lblStat3Num.TabIndex = 0;
            lblStat3Num.Text = "5.200.000đ";
            // 
            // lblStat3Title
            // 
            lblStat3Title.AutoSize = true;
            lblStat3Title.Font = new Font("Segoe UI", 10F);
            lblStat3Title.ForeColor = Color.Gray;
            lblStat3Title.Location = new Point(97, 66);
            lblStat3Title.Name = "lblStat3Title";
            lblStat3Title.Size = new Size(117, 19);
            lblStat3Title.TabIndex = 1;
            lblStat3Title.Text = "Doanh thu hôm nay";
            // 
            // picStat3
            // 
            picStat3.BackColor = Color.FromArgb(255, 243, 224);
            picStat3.Location = new Point(20, 27);
            picStat3.Name = "picStat3";
            picStat3.Size = new Size(56, 56);
            picStat3.SizeMode = PictureBoxSizeMode.StretchImage;
            picStat3.TabIndex = 2;
            picStat3.TabStop = false;
            // 
            // panelStats4
            // 
            panelStats4.BackColor = Color.White;
            panelStats4.Controls.Add(lblStat4Num);
            panelStats4.Controls.Add(lblStat4Title);
            panelStats4.Controls.Add(picStat4);
            panelStats4.Location = new Point(1020, 150);
            panelStats4.Name = "panelStats4";
            panelStats4.Size = new Size(240, 110);
            panelStats4.TabIndex = 5;
            // 
            // lblStat4Num
            // 
            lblStat4Num.AutoSize = true;
            lblStat4Num.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStat4Num.ForeColor = Color.FromArgb(40, 40, 40);
            lblStat4Num.Location = new Point(95, 22);
            lblStat4Num.Name = "lblStat4Num";
            lblStat4Num.Size = new Size(28, 37);
            lblStat4Num.TabIndex = 0;
            lblStat4Num.Text = "8";
            // 
            // lblStat4Title
            // 
            lblStat4Title.AutoSize = true;
            lblStat4Title.Font = new Font("Segoe UI", 10F);
            lblStat4Title.ForeColor = Color.Gray;
            lblStat4Title.Location = new Point(97, 66);
            lblStat4Title.Name = "lblStat4Title";
            lblStat4Title.Size = new Size(68, 19);
            lblStat4Title.TabIndex = 1;
            lblStat4Title.Text = "Nhân viên";
            // 
            // picStat4
            // 
            picStat4.BackColor = Color.FromArgb(227, 242, 253);
            picStat4.Location = new Point(20, 27);
            picStat4.Name = "picStat4";
            picStat4.Size = new Size(56, 56);
            picStat4.SizeMode = PictureBoxSizeMode.StretchImage;
            picStat4.TabIndex = 2;
            picStat4.TabStop = false;
            // 
            // panelRecentOrders
            // 
            panelRecentOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelRecentOrders.BackColor = Color.White;
            panelRecentOrders.Controls.Add(lnkViewAllOrders);
            panelRecentOrders.Controls.Add(dgvRecentOrders);
            panelRecentOrders.Controls.Add(lblRecentOrdersTitle);
            panelRecentOrders.Location = new Point(240, 280);
            panelRecentOrders.Name = "panelRecentOrders";
            panelRecentOrders.Size = new Size(620, 420);
            panelRecentOrders.TabIndex = 6;
            // 
            // lblRecentOrdersTitle
            // 
            lblRecentOrdersTitle.AutoSize = true;
            lblRecentOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecentOrdersTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblRecentOrdersTitle.Location = new Point(20, 15);
            lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            lblRecentOrdersTitle.Size = new Size(139, 21);
            lblRecentOrdersTitle.TabIndex = 0;
            lblRecentOrdersTitle.Text = "Đơn hàng gần đây";
            // 
            // lnkViewAllOrders
            // 
            lnkViewAllOrders.ActiveLinkColor = Color.FromArgb(224, 98, 103);
            lnkViewAllOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lnkViewAllOrders.AutoSize = true;
            lnkViewAllOrders.Font = new Font("Segoe UI", 9.5F);
            lnkViewAllOrders.LinkColor = Color.FromArgb(224, 98, 103);
            lnkViewAllOrders.Location = new Point(520, 19);
            lnkViewAllOrders.Name = "lnkViewAllOrders";
            lnkViewAllOrders.Size = new Size(80, 17);
            lnkViewAllOrders.TabIndex = 1;
            lnkViewAllOrders.TabStop = true;
            lnkViewAllOrders.Text = "Xem tất cả →";
            // 
            // dgvRecentOrders
            // 
            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.AllowUserToDeleteRows = false;
            dgvRecentOrders.AllowUserToResizeRows = false;
            dgvRecentOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.BackgroundColor = Color.White;
            dgvRecentOrders.BorderStyle = BorderStyle.None;
            dgvRecentOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(253, 242, 242);
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            headerStyle.ForeColor = Color.FromArgb(80, 80, 80);
            headerStyle.SelectionBackColor = Color.FromArgb(253, 242, 242);
            headerStyle.SelectionForeColor = Color.FromArgb(80, 80, 80);
            headerStyle.WrapMode = DataGridViewTriState.True;
            dgvRecentOrders.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvRecentOrders.ColumnHeadersHeight = 40;
            dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecentOrders.Columns.AddRange(new DataGridViewColumn[] { colMaDon, colKhachHang, colNgayDat, colTongTien, colTrangThai });
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            cellStyle.SelectionBackColor = Color.FromArgb(253, 237, 237);
            cellStyle.SelectionForeColor = Color.FromArgb(60, 60, 60);
            cellStyle.WrapMode = DataGridViewTriState.False;
            dgvRecentOrders.DefaultCellStyle = cellStyle;
            dgvRecentOrders.EnableHeadersVisualStyles = false;
            dgvRecentOrders.GridColor = Color.FromArgb(235, 235, 235);
            dgvRecentOrders.Location = new Point(20, 55);
            dgvRecentOrders.MultiSelect = false;
            dgvRecentOrders.Name = "dgvRecentOrders";
            dgvRecentOrders.ReadOnly = true;
            dgvRecentOrders.RowHeadersVisible = false;
            dgvRecentOrders.RowHeadersWidth = 72;
            dgvRecentOrders.RowTemplate.Height = 38;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentOrders.Size = new Size(580, 345);
            dgvRecentOrders.TabIndex = 2;
            // 
            // colMaDon
            // 
            colMaDon.FillWeight = 14F;
            colMaDon.HeaderText = "Mã đơn";
            colMaDon.MinimumWidth = 9;
            colMaDon.Name = "colMaDon";
            colMaDon.ReadOnly = true;
            // 
            // colKhachHang
            // 
            colKhachHang.FillWeight = 26F;
            colKhachHang.HeaderText = "Khách hàng";
            colKhachHang.MinimumWidth = 9;
            colKhachHang.Name = "colKhachHang";
            colKhachHang.ReadOnly = true;
            // 
            // colNgayDat
            // 
            colNgayDat.FillWeight = 20F;
            colNgayDat.HeaderText = "Ngày đặt";
            colNgayDat.MinimumWidth = 9;
            colNgayDat.Name = "colNgayDat";
            colNgayDat.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.FillWeight = 20F;
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 9;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.FillWeight = 20F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 9;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // panelTopFlowers
            // 
            panelTopFlowers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelTopFlowers.BackColor = Color.White;
            panelTopFlowers.Controls.Add(lnkViewAllFlowers);
            panelTopFlowers.Controls.Add(lblTopFlowersTitle);
            panelTopFlowers.Controls.Add(panelFlower1);
            panelTopFlowers.Controls.Add(panelFlower2);
            panelTopFlowers.Controls.Add(panelFlower3);
            panelTopFlowers.Location = new Point(880, 280);
            panelTopFlowers.Name = "panelTopFlowers";
            panelTopFlowers.Size = new Size(380, 420);
            panelTopFlowers.TabIndex = 7;
            // 
            // lblTopFlowersTitle
            // 
            lblTopFlowersTitle.AutoSize = true;
            lblTopFlowersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopFlowersTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblTopFlowersTitle.Location = new Point(20, 15);
            lblTopFlowersTitle.Name = "lblTopFlowersTitle";
            lblTopFlowersTitle.Size = new Size(104, 21);
            lblTopFlowersTitle.TabIndex = 0;
            lblTopFlowersTitle.Text = "Hoa bán chạy";
            // 
            // lnkViewAllFlowers
            // 
            lnkViewAllFlowers.ActiveLinkColor = Color.FromArgb(224, 98, 103);
            lnkViewAllFlowers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lnkViewAllFlowers.AutoSize = true;
            lnkViewAllFlowers.Font = new Font("Segoe UI", 9.5F);
            lnkViewAllFlowers.LinkColor = Color.FromArgb(224, 98, 103);
            lnkViewAllFlowers.Location = new Point(280, 19);
            lnkViewAllFlowers.Name = "lnkViewAllFlowers";
            lnkViewAllFlowers.Size = new Size(80, 17);
            lnkViewAllFlowers.TabIndex = 1;
            lnkViewAllFlowers.TabStop = true;
            lnkViewAllFlowers.Text = "Xem tất cả →";
            // 
            // panelFlower1
            // 
            panelFlower1.BackColor = Color.FromArgb(250, 250, 250);
            panelFlower1.Controls.Add(lblFlower1Sales);
            panelFlower1.Controls.Add(lblFlower1Name);
            panelFlower1.Controls.Add(picFlower1);
            panelFlower1.Location = new Point(20, 55);
            panelFlower1.Name = "panelFlower1";
            panelFlower1.Size = new Size(340, 105);
            panelFlower1.TabIndex = 2;
            // 
            // lblFlower1Name
            // 
            lblFlower1Name.AutoSize = true;
            lblFlower1Name.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFlower1Name.ForeColor = Color.FromArgb(40, 40, 40);
            lblFlower1Name.Location = new Point(105, 24);
            lblFlower1Name.Name = "lblFlower1Name";
            lblFlower1Name.Size = new Size(94, 20);
            lblFlower1Name.TabIndex = 1;
            lblFlower1Name.Text = "Hoa hồng đỏ";
            // 
            // lblFlower1Sales
            // 
            lblFlower1Sales.AutoSize = true;
            lblFlower1Sales.Font = new Font("Segoe UI", 9.5F);
            lblFlower1Sales.ForeColor = Color.Gray;
            lblFlower1Sales.Location = new Point(106, 58);
            lblFlower1Sales.Name = "lblFlower1Sales";
            lblFlower1Sales.Size = new Size(75, 17);
            lblFlower1Sales.TabIndex = 2;
            lblFlower1Sales.Text = "Đã bán: 120";
            // 
            // picFlower1
            // 
            picFlower1.BackColor = Color.FromArgb(253, 237, 237);
            picFlower1.Location = new Point(15, 15);
            picFlower1.Name = "picFlower1";
            picFlower1.Size = new Size(75, 75);
            picFlower1.SizeMode = PictureBoxSizeMode.Zoom;
            picFlower1.TabIndex = 0;
            picFlower1.TabStop = false;
            // 
            // panelFlower2
            // 
            panelFlower2.BackColor = Color.FromArgb(250, 250, 250);
            panelFlower2.Controls.Add(lblFlower2Sales);
            panelFlower2.Controls.Add(lblFlower2Name);
            panelFlower2.Controls.Add(picFlower2);
            panelFlower2.Location = new Point(20, 175);
            panelFlower2.Name = "panelFlower2";
            panelFlower2.Size = new Size(340, 105);
            panelFlower2.TabIndex = 3;
            // 
            // lblFlower2Name
            // 
            lblFlower2Name.AutoSize = true;
            lblFlower2Name.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFlower2Name.ForeColor = Color.FromArgb(40, 40, 40);
            lblFlower2Name.Location = new Point(105, 24);
            lblFlower2Name.Name = "lblFlower2Name";
            lblFlower2Name.Size = new Size(89, 20);
            lblFlower2Name.TabIndex = 1;
            lblFlower2Name.Text = "Hoa hướng dương";
            // 
            // lblFlower2Sales
            // 
            lblFlower2Sales.AutoSize = true;
            lblFlower2Sales.Font = new Font("Segoe UI", 9.5F);
            lblFlower2Sales.ForeColor = Color.Gray;
            lblFlower2Sales.Location = new Point(106, 58);
            lblFlower2Sales.Name = "lblFlower2Sales";
            lblFlower2Sales.Size = new Size(66, 17);
            lblFlower2Sales.TabIndex = 2;
            lblFlower2Sales.Text = "Đã bán: 95";
            // 
            // picFlower2
            // 
            picFlower2.BackColor = Color.FromArgb(255, 243, 224);
            picFlower2.Location = new Point(15, 15);
            picFlower2.Name = "picFlower2";
            picFlower2.Size = new Size(75, 75);
            picFlower2.SizeMode = PictureBoxSizeMode.Zoom;
            picFlower2.TabIndex = 0;
            picFlower2.TabStop = false;
            // 
            // panelFlower3
            // 
            panelFlower3.BackColor = Color.FromArgb(250, 250, 250);
            panelFlower3.Controls.Add(lblFlower3Sales);
            panelFlower3.Controls.Add(lblFlower3Name);
            panelFlower3.Controls.Add(picFlower3);
            panelFlower3.Location = new Point(20, 295);
            panelFlower3.Name = "panelFlower3";
            panelFlower3.Size = new Size(340, 105);
            panelFlower3.TabIndex = 4;
            // 
            // lblFlower3Name
            // 
            lblFlower3Name.AutoSize = true;
            lblFlower3Name.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFlower3Name.ForeColor = Color.FromArgb(40, 40, 40);
            lblFlower3Name.Location = new Point(105, 24);
            lblFlower3Name.Name = "lblFlower3Name";
            lblFlower3Name.Size = new Size(80, 20);
            lblFlower3Name.TabIndex = 1;
            lblFlower3Name.Text = "Hoa tulip";
            // 
            // lblFlower3Sales
            // 
            lblFlower3Sales.AutoSize = true;
            lblFlower3Sales.Font = new Font("Segoe UI", 9.5F);
            lblFlower3Sales.ForeColor = Color.Gray;
            lblFlower3Sales.Location = new Point(106, 58);
            lblFlower3Sales.Name = "lblFlower3Sales";
            lblFlower3Sales.Size = new Size(66, 17);
            lblFlower3Sales.TabIndex = 2;
            lblFlower3Sales.Text = "Đã bán: 78";
            // 
            // picFlower3
            // 
            picFlower3.BackColor = Color.FromArgb(243, 229, 245);
            picFlower3.Location = new Point(15, 15);
            picFlower3.Name = "picFlower3";
            picFlower3.Size = new Size(75, 75);
            picFlower3.SizeMode = PictureBoxSizeMode.Zoom;
            picFlower3.TabIndex = 0;
            picFlower3.TabStop = false;
            // 
            // frmMain
            // 
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 245, 245);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelTopFlowers);
            Controls.Add(panelRecentOrders);
            Controls.Add(panelStats4);
            Controls.Add(panelStats3);
            Controls.Add(panelStats2);
            Controls.Add(panelStats1);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            MinimumSize = new Size(1100, 650);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cửa Hàng Hoa - Trang chủ";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoIcon).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdminAvatar).EndInit();
            panelStats1.ResumeLayout(false);
            panelStats1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStat1).EndInit();
            panelStats2.ResumeLayout(false);
            panelStats2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStat2).EndInit();
            panelStats3.ResumeLayout(false);
            panelStats3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStat3).EndInit();
            panelStats4.ResumeLayout(false);
            panelStats4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStat4).EndInit();
            panelRecentOrders.ResumeLayout(false);
            panelRecentOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).EndInit();
            panelTopFlowers.ResumeLayout(false);
            panelTopFlowers.PerformLayout();
            panelFlower1.ResumeLayout(false);
            panelFlower1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower1).EndInit();
            panelFlower2.ResumeLayout(false);
            panelFlower2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower2).EndInit();
            panelFlower3.ResumeLayout(false);
            panelFlower3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower3).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogoIcon;
        private System.Windows.Forms.Label lblMainLogo;
        private System.Windows.Forms.Label lblSubLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFlower;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcomeMain;
        private System.Windows.Forms.Label lblWelcomeSub;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Panel panelStats1;
        private System.Windows.Forms.PictureBox picStat1;
        private System.Windows.Forms.Label lblStat1Title;
        private System.Windows.Forms.Label lblStat1Num;
        private System.Windows.Forms.Panel panelStats2;
        private System.Windows.Forms.Label lblStat2Num;
        private System.Windows.Forms.Label lblStat2Title;
        private System.Windows.Forms.PictureBox picStat2;
        private System.Windows.Forms.Panel panelStats3;
        private System.Windows.Forms.Label lblStat3Num;
        private System.Windows.Forms.Label lblStat3Title;
        private System.Windows.Forms.PictureBox picStat3;
        private System.Windows.Forms.Panel panelStats4;
        private System.Windows.Forms.Label lblStat4Num;
        private System.Windows.Forms.Label lblStat4Title;
        private System.Windows.Forms.PictureBox picStat4;
        private System.Windows.Forms.Panel panelRecentOrders;
        private System.Windows.Forms.Label lblRecentOrdersTitle;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.LinkLabel lnkViewAllOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel panelTopFlowers;
        private System.Windows.Forms.Label lblTopFlowersTitle;
        private System.Windows.Forms.LinkLabel lnkViewAllFlowers;
        private System.Windows.Forms.Panel panelFlower1;
        private System.Windows.Forms.PictureBox picFlower1;
        private System.Windows.Forms.Label lblFlower1Name;
        private System.Windows.Forms.Label lblFlower1Sales;
        private System.Windows.Forms.Panel panelFlower2;
        private System.Windows.Forms.Label lblFlower2Sales;
        private System.Windows.Forms.Label lblFlower2Name;
        private System.Windows.Forms.PictureBox picFlower2;
        private System.Windows.Forms.Panel panelFlower3;
        private System.Windows.Forms.Label lblFlower3Sales;
        private System.Windows.Forms.Label lblFlower3Name;
        private System.Windows.Forms.PictureBox picFlower3;
        #endregion
    }
}
