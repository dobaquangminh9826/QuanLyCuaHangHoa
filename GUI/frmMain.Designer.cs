using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnFlower = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSubLogo = new System.Windows.Forms.Label();
            this.lblMainLogo = new System.Windows.Forms.Label();
            this.picLogoIcon = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.lblWelcomeMain = new System.Windows.Forms.Label();
            this.panelStats1 = new System.Windows.Forms.Panel();
            this.lblStat1Num = new System.Windows.Forms.Label();
            this.lblStat1Title = new System.Windows.Forms.Label();
            this.picStat1 = new System.Windows.Forms.PictureBox();
            this.panelStats2 = new System.Windows.Forms.Panel();
            this.lblStat2Num = new System.Windows.Forms.Label();
            this.lblStat2Title = new System.Windows.Forms.Label();
            this.picStat2 = new System.Windows.Forms.PictureBox();
            this.panelStats3 = new System.Windows.Forms.Panel();
            this.lblStat3Num = new System.Windows.Forms.Label();
            this.lblStat3Title = new System.Windows.Forms.Label();
            this.picStat3 = new System.Windows.Forms.PictureBox();
            this.panelStats4 = new System.Windows.Forms.Panel();
            this.lblStat4Num = new System.Windows.Forms.Label();
            this.lblStat4Title = new System.Windows.Forms.Label();
            this.picStat4 = new System.Windows.Forms.PictureBox();
            this.panelRecentOrders = new System.Windows.Forms.Panel();
            this.lnkViewAllOrders = new System.Windows.Forms.LinkLabel();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.colMaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecentOrdersTitle = new System.Windows.Forms.Label();
            this.panelTopFlowers = new System.Windows.Forms.Panel();
            this.lnkViewAllFlowers = new System.Windows.Forms.LinkLabel();
            this.lblTopFlowersTitle = new System.Windows.Forms.Label();
            this.panelFlower1 = new System.Windows.Forms.Panel();
            this.lblFlower1Sales = new System.Windows.Forms.Label();
            this.lblFlower1Name = new System.Windows.Forms.Label();
            this.picFlower1 = new System.Windows.Forms.PictureBox();
            this.panelFlower2 = new System.Windows.Forms.Panel();
            this.lblFlower2Sales = new System.Windows.Forms.Label();
            this.lblFlower2Name = new System.Windows.Forms.Label();
            this.picFlower2 = new System.Windows.Forms.PictureBox();
            this.panelFlower3 = new System.Windows.Forms.Panel();
            this.lblFlower3Sales = new System.Windows.Forms.Label();
            this.lblFlower3Name = new System.Windows.Forms.Label();
            this.picFlower3 = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoIcon)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.panelStats1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat1)).BeginInit();
            this.panelStats2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat2)).BeginInit();
            this.panelStats3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat3)).BeginInit();
            this.panelStats4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat4)).BeginInit();
            this.panelRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.panelTopFlowers.SuspendLayout();
            this.panelFlower1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlower1)).BeginInit();
            this.panelFlower2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlower2)).BeginInit();
            this.panelFlower3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlower3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.lblTime);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnChangePass);
            this.panelSidebar.Controls.Add(this.btnStatistics);
            this.panelSidebar.Controls.Add(this.btnOrder);
            this.panelSidebar.Controls.Add(this.btnSale);
            this.panelSidebar.Controls.Add(this.btnStaff);
            this.panelSidebar.Controls.Add(this.btnCategory);
            this.panelSidebar.Controls.Add(this.btnFlower);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(15, 690);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(255, 30);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Thứ Hai, 13/10/2025 14:32";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 525);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "      Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChangePass.ForeColor = System.Drawing.Color.DimGray;
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(0, 480);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnChangePass.Size = new System.Drawing.Size(220, 40);
            this.btnChangePass.TabIndex = 8;
            this.btnChangePass.Text = "      Đổi mật khẩu";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStatistics.ForeColor = System.Drawing.Color.DimGray;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 435);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(220, 40);
            this.btnStatistics.TabIndex = 7;
            this.btnStatistics.Text = "      Thống kê";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrder.ForeColor = System.Drawing.Color.DimGray;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 390);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(220, 40);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "      Quản lý đơn hàng";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSale.ForeColor = System.Drawing.Color.DimGray;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 345);
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSale.Size = new System.Drawing.Size(220, 40);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "      Quản lý bán hàng";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStaff.ForeColor = System.Drawing.Color.DimGray;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 300);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(220, 40);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "      Quản lý nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCategory.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 255);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(220, 40);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "      Quản lý danh mục";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnFlower
            // 
            this.btnFlower.FlatAppearance.BorderSize = 0;
            this.btnFlower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlower.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFlower.ForeColor = System.Drawing.Color.DimGray;
            this.btnFlower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlower.Location = new System.Drawing.Point(0, 210);
            this.btnFlower.Name = "btnFlower";
            this.btnFlower.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFlower.Size = new System.Drawing.Size(220, 40);
            this.btnFlower.TabIndex = 2;
            this.btnFlower.Text = "      Quản lý hoa";
            this.btnFlower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlower.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 165);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "      Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnSearch);
            this.panelLogo.Controls.Add(this.lblSubLogo);
            this.panelLogo.Controls.Add(this.lblMainLogo);
            this.panelLogo.Controls.Add(this.picLogoIcon);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 150);
            this.panelLogo.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(220, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "      Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSubLogo
            // 
            this.lblSubLogo.AutoSize = true;
            this.lblSubLogo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubLogo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubLogo.Location = new System.Drawing.Point(68, 62);
            this.lblSubLogo.Name = "lblSubLogo";
            this.lblSubLogo.Size = new System.Drawing.Size(176, 28);
            this.lblSubLogo.TabIndex = 2;
            this.lblSubLogo.Text = "Hoa tươi mỗi ngày";
            // 
            // lblMainLogo
            // 
            this.lblMainLogo.AutoSize = true;
            this.lblMainLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMainLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMainLogo.Location = new System.Drawing.Point(67, 38);
            this.lblMainLogo.Name = "lblMainLogo";
            this.lblMainLogo.Size = new System.Drawing.Size(207, 38);
            this.lblMainLogo.TabIndex = 1;
            this.lblMainLogo.Text = "Cửa Hàng Hoa";
            // 
            // picLogoIcon
            // 
            this.picLogoIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.picLogoIcon.Location = new System.Drawing.Point(22, 38);
            this.picLogoIcon.Name = "picLogoIcon";
            this.picLogoIcon.Size = new System.Drawing.Size(40, 40);
            this.picLogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoIcon.TabIndex = 0;
            this.picLogoIcon.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelHeader.Controls.Add(this.lblAdminName);
            this.panelHeader.Controls.Add(this.picAdminAvatar);
            this.panelHeader.Controls.Add(this.lblWelcomeSub);
            this.panelHeader.Controls.Add(this.lblWelcomeMain);
            this.panelHeader.Location = new System.Drawing.Point(240, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1020, 110);
            this.panelHeader.TabIndex = 1;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdminName.Location = new System.Drawing.Point(925, 45);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(90, 32);
            this.lblAdminName.TabIndex = 3;
            this.lblAdminName.Text = "Admin";
            // 
            // picAdminAvatar
            // 
            this.picAdminAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAdminAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.picAdminAvatar.Location = new System.Drawing.Point(880, 39);
            this.picAdminAvatar.Name = "picAdminAvatar";
            this.picAdminAvatar.Size = new System.Drawing.Size(32, 32);
            this.picAdminAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdminAvatar.TabIndex = 2;
            this.picAdminAvatar.TabStop = false;
            // 
            // lblWelcomeSub
            // 
            this.lblWelcomeSub.AutoSize = true;
            this.lblWelcomeSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblWelcomeSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcomeSub.Location = new System.Drawing.Point(25, 62);
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblWelcomeSub.Size = new System.Drawing.Size(405, 31);
            this.lblWelcomeSub.TabIndex = 1;
            this.lblWelcomeSub.Text = "Chúc bạn một ngày làm việc hiệu quả!";
            // 
            // lblWelcomeMain
            // 
            this.lblWelcomeMain.AutoSize = true;
            this.lblWelcomeMain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblWelcomeMain.Location = new System.Drawing.Point(23, 22);
            this.lblWelcomeMain.Name = "lblWelcomeMain";
            this.lblWelcomeMain.Size = new System.Drawing.Size(327, 51);
            this.lblWelcomeMain.TabIndex = 0;
            this.lblWelcomeMain.Text = "Xin chào, Admin!";
            // 
            // panelStats1
            // 
            this.panelStats1.BackColor = System.Drawing.Color.White;
            this.panelStats1.Controls.Add(this.lblStat1Num);
            this.panelStats1.Controls.Add(this.lblStat1Title);
            this.panelStats1.Controls.Add(this.picStat1);
            this.panelStats1.Location = new System.Drawing.Point(240, 150);
            this.panelStats1.Name = "panelStats1";
            this.panelStats1.Size = new System.Drawing.Size(240, 110);
            this.panelStats1.TabIndex = 2;
            // 
            // lblStat1Num
            // 
            this.lblStat1Num.AutoSize = true;
            this.lblStat1Num.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStat1Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStat1Num.Location = new System.Drawing.Point(95, 22);
            this.lblStat1Num.Name = "lblStat1Num";
            this.lblStat1Num.Size = new System.Drawing.Size(54, 62);
            this.lblStat1Num.TabIndex = 0;
            this.lblStat1Num.Text = "0";
            // 
            // lblStat1Title
            // 
            this.lblStat1Title.AutoSize = true;
            this.lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStat1Title.ForeColor = System.Drawing.Color.Gray;
            this.lblStat1Title.Location = new System.Drawing.Point(97, 66);
            this.lblStat1Title.Name = "lblStat1Title";
            this.lblStat1Title.Size = new System.Drawing.Size(147, 32);
            this.lblStat1Title.TabIndex = 1;
            this.lblStat1Title.Text = "Tổng số hoa";
            // 
            // picStat1
            // 
            this.picStat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.picStat1.Location = new System.Drawing.Point(20, 27);
            this.picStat1.Name = "picStat1";
            this.picStat1.Size = new System.Drawing.Size(56, 56);
            this.picStat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStat1.TabIndex = 2;
            this.picStat1.TabStop = false;
            // 
            // panelStats2
            // 
            this.panelStats2.BackColor = System.Drawing.Color.White;
            this.panelStats2.Controls.Add(this.lblStat2Num);
            this.panelStats2.Controls.Add(this.lblStat2Title);
            this.panelStats2.Controls.Add(this.picStat2);
            this.panelStats2.Location = new System.Drawing.Point(500, 150);
            this.panelStats2.Name = "panelStats2";
            this.panelStats2.Size = new System.Drawing.Size(240, 110);
            this.panelStats2.TabIndex = 3;
            // 
            // lblStat2Num
            // 
            this.lblStat2Num.AutoSize = true;
            this.lblStat2Num.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStat2Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStat2Num.Location = new System.Drawing.Point(95, 22);
            this.lblStat2Num.Name = "lblStat2Num";
            this.lblStat2Num.Size = new System.Drawing.Size(54, 62);
            this.lblStat2Num.TabIndex = 0;
            this.lblStat2Num.Text = "0";
            // 
            // lblStat2Title
            // 
            this.lblStat2Title.AutoSize = true;
            this.lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStat2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblStat2Title.Location = new System.Drawing.Point(97, 66);
            this.lblStat2Title.Name = "lblStat2Title";
            this.lblStat2Title.Size = new System.Drawing.Size(221, 32);
            this.lblStat2Title.TabIndex = 1;
            this.lblStat2Title.Text = "Đơn hàng hôm nay";
            // 
            // picStat2
            // 
            this.picStat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.picStat2.Location = new System.Drawing.Point(20, 27);
            this.picStat2.Name = "picStat2";
            this.picStat2.Size = new System.Drawing.Size(56, 56);
            this.picStat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStat2.TabIndex = 2;
            this.picStat2.TabStop = false;
            // 
            // panelStats3
            // 
            this.panelStats3.BackColor = System.Drawing.Color.White;
            this.panelStats3.Controls.Add(this.lblStat3Num);
            this.panelStats3.Controls.Add(this.lblStat3Title);
            this.panelStats3.Controls.Add(this.picStat3);
            this.panelStats3.Location = new System.Drawing.Point(760, 150);
            this.panelStats3.Name = "panelStats3";
            this.panelStats3.Size = new System.Drawing.Size(240, 110);
            this.panelStats3.TabIndex = 4;
            // 
            // lblStat3Num
            // 
            this.lblStat3Num.AutoSize = true;
            this.lblStat3Num.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStat3Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStat3Num.Location = new System.Drawing.Point(95, 26);
            this.lblStat3Num.Name = "lblStat3Num";
            this.lblStat3Num.Size = new System.Drawing.Size(68, 51);
            this.lblStat3Num.TabIndex = 0;
            this.lblStat3Num.Text = "0đ";
            // 
            // lblStat3Title
            // 
            this.lblStat3Title.AutoSize = true;
            this.lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStat3Title.ForeColor = System.Drawing.Color.Gray;
            this.lblStat3Title.Location = new System.Drawing.Point(97, 66);
            this.lblStat3Title.Name = "lblStat3Title";
            this.lblStat3Title.Size = new System.Drawing.Size(229, 32);
            this.lblStat3Title.TabIndex = 1;
            this.lblStat3Title.Text = "Doanh thu hôm nay";
            // 
            // picStat3
            // 
            this.picStat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.picStat3.Location = new System.Drawing.Point(20, 27);
            this.picStat3.Name = "picStat3";
            this.picStat3.Size = new System.Drawing.Size(56, 56);
            this.picStat3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStat3.TabIndex = 2;
            this.picStat3.TabStop = false;
            // 
            // panelStats4
            // 
            this.panelStats4.BackColor = System.Drawing.Color.White;
            this.panelStats4.Controls.Add(this.lblStat4Num);
            this.panelStats4.Controls.Add(this.lblStat4Title);
            this.panelStats4.Controls.Add(this.picStat4);
            this.panelStats4.Location = new System.Drawing.Point(1020, 150);
            this.panelStats4.Name = "panelStats4";
            this.panelStats4.Size = new System.Drawing.Size(240, 110);
            this.panelStats4.TabIndex = 5;
            // 
            // lblStat4Num
            // 
            this.lblStat4Num.AutoSize = true;
            this.lblStat4Num.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStat4Num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblStat4Num.Location = new System.Drawing.Point(95, 22);
            this.lblStat4Num.Name = "lblStat4Num";
            this.lblStat4Num.Size = new System.Drawing.Size(54, 62);
            this.lblStat4Num.TabIndex = 0;
            this.lblStat4Num.Text = "0";
            // 
            // lblStat4Title
            // 
            this.lblStat4Title.AutoSize = true;
            this.lblStat4Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStat4Title.ForeColor = System.Drawing.Color.Gray;
            this.lblStat4Title.Location = new System.Drawing.Point(97, 66);
            this.lblStat4Title.Name = "lblStat4Title";
            this.lblStat4Title.Size = new System.Drawing.Size(124, 32);
            this.lblStat4Title.TabIndex = 1;
            this.lblStat4Title.Text = "Nhân viên";
            // 
            // picStat4
            // 
            this.picStat4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.picStat4.Location = new System.Drawing.Point(20, 27);
            this.picStat4.Name = "picStat4";
            this.picStat4.Size = new System.Drawing.Size(56, 56);
            this.picStat4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStat4.TabIndex = 2;
            this.picStat4.TabStop = false;
            // 
            // panelRecentOrders
            // 
            this.panelRecentOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRecentOrders.BackColor = System.Drawing.Color.White;
            this.panelRecentOrders.Controls.Add(this.lnkViewAllOrders);
            this.panelRecentOrders.Controls.Add(this.dgvRecentOrders);
            this.panelRecentOrders.Controls.Add(this.lblRecentOrdersTitle);
            this.panelRecentOrders.Location = new System.Drawing.Point(240, 280);
            this.panelRecentOrders.Name = "panelRecentOrders";
            this.panelRecentOrders.Size = new System.Drawing.Size(620, 420);
            this.panelRecentOrders.TabIndex = 6;
            // 
            // lnkViewAllOrders
            // 
            this.lnkViewAllOrders.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.lnkViewAllOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkViewAllOrders.AutoSize = true;
            this.lnkViewAllOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lnkViewAllOrders.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.lnkViewAllOrders.Location = new System.Drawing.Point(520, 19);
            this.lnkViewAllOrders.Name = "lnkViewAllOrders";
            this.lnkViewAllOrders.Size = new System.Drawing.Size(149, 31);
            this.lnkViewAllOrders.TabIndex = 1;
            this.lnkViewAllOrders.TabStop = true;
            this.lnkViewAllOrders.Text = "Xem tất cả →";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AllowUserToDeleteRows = false;
            this.dgvRecentOrders.AllowUserToResizeRows = false;
            this.dgvRecentOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentOrders.ColumnHeadersHeight = 40;
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDon,
            this.colKhachHang,
            this.colNgayDat,
            this.colTongTien,
            this.colTrangThai});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentOrders.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecentOrders.EnableHeadersVisualStyles = false;
            this.dgvRecentOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvRecentOrders.Location = new System.Drawing.Point(20, 55);
            this.dgvRecentOrders.MultiSelect = false;
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersVisible = false;
            this.dgvRecentOrders.RowHeadersWidth = 72;
            this.dgvRecentOrders.RowTemplate.Height = 38;
            this.dgvRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentOrders.Size = new System.Drawing.Size(580, 345);
            this.dgvRecentOrders.TabIndex = 2;
            // 
            // colMaDon
            // 
            this.colMaDon.FillWeight = 14F;
            this.colMaDon.HeaderText = "Mã đơn";
            this.colMaDon.MinimumWidth = 9;
            this.colMaDon.Name = "colMaDon";
            this.colMaDon.ReadOnly = true;
            // 
            // colKhachHang
            // 
            this.colKhachHang.FillWeight = 26F;
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.MinimumWidth = 9;
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.ReadOnly = true;
            // 
            // colNgayDat
            // 
            this.colNgayDat.FillWeight = 20F;
            this.colNgayDat.HeaderText = "Ngày đặt";
            this.colNgayDat.MinimumWidth = 9;
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.FillWeight = 20F;
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.MinimumWidth = 9;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FillWeight = 20F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 9;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // lblRecentOrdersTitle
            // 
            this.lblRecentOrdersTitle.AutoSize = true;
            this.lblRecentOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblRecentOrdersTitle.Location = new System.Drawing.Point(20, 15);
            this.lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            this.lblRecentOrdersTitle.Size = new System.Drawing.Size(260, 38);
            this.lblRecentOrdersTitle.TabIndex = 0;
            this.lblRecentOrdersTitle.Text = "Đơn hàng gần đây";
            // 
            // panelTopFlowers
            // 
            this.panelTopFlowers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopFlowers.BackColor = System.Drawing.Color.White;
            this.panelTopFlowers.Controls.Add(this.lnkViewAllFlowers);
            this.panelTopFlowers.Controls.Add(this.lblTopFlowersTitle);
            this.panelTopFlowers.Controls.Add(this.panelFlower1);
            this.panelTopFlowers.Controls.Add(this.panelFlower2);
            this.panelTopFlowers.Controls.Add(this.panelFlower3);
            this.panelTopFlowers.Location = new System.Drawing.Point(880, 280);
            this.panelTopFlowers.Name = "panelTopFlowers";
            this.panelTopFlowers.Size = new System.Drawing.Size(380, 420);
            this.panelTopFlowers.TabIndex = 7;
            // 
            // lnkViewAllFlowers
            // 
            this.lnkViewAllFlowers.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.lnkViewAllFlowers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkViewAllFlowers.AutoSize = true;
            this.lnkViewAllFlowers.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lnkViewAllFlowers.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.lnkViewAllFlowers.Location = new System.Drawing.Point(280, 19);
            this.lnkViewAllFlowers.Name = "lnkViewAllFlowers";
            this.lnkViewAllFlowers.Size = new System.Drawing.Size(149, 31);
            this.lnkViewAllFlowers.TabIndex = 1;
            this.lnkViewAllFlowers.TabStop = true;
            this.lnkViewAllFlowers.Text = "Xem tất cả →";
            // 
            // lblTopFlowersTitle
            // 
            this.lblTopFlowersTitle.AutoSize = true;
            this.lblTopFlowersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopFlowersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTopFlowersTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTopFlowersTitle.Name = "lblTopFlowersTitle";
            this.lblTopFlowersTitle.Size = new System.Drawing.Size(195, 38);
            this.lblTopFlowersTitle.TabIndex = 0;
            this.lblTopFlowersTitle.Text = "Hoa bán chạy";
            // 
            // panelFlower1
            // 
            this.panelFlower1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelFlower1.Controls.Add(this.lblFlower1Sales);
            this.panelFlower1.Controls.Add(this.lblFlower1Name);
            this.panelFlower1.Controls.Add(this.picFlower1);
            this.panelFlower1.Location = new System.Drawing.Point(20, 55);
            this.panelFlower1.Name = "panelFlower1";
            this.panelFlower1.Size = new System.Drawing.Size(340, 105);
            this.panelFlower1.TabIndex = 2;
            // 
            // lblFlower1Sales
            // 
            this.lblFlower1Sales.AutoSize = true;
            this.lblFlower1Sales.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFlower1Sales.ForeColor = System.Drawing.Color.Gray;
            this.lblFlower1Sales.Location = new System.Drawing.Point(106, 58);
            this.lblFlower1Sales.Name = "lblFlower1Sales";
            this.lblFlower1Sales.Size = new System.Drawing.Size(110, 31);
            this.lblFlower1Sales.TabIndex = 2;
            this.lblFlower1Sales.Text = "Đã bán: 0";
            // 
            // lblFlower1Name
            // 
            this.lblFlower1Name.AutoSize = true;
            this.lblFlower1Name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFlower1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFlower1Name.Location = new System.Drawing.Point(105, 24);
            this.lblFlower1Name.Name = "lblFlower1Name";
            this.lblFlower1Name.Size = new System.Drawing.Size(175, 36);
            this.lblFlower1Name.TabIndex = 1;
            this.lblFlower1Name.Text = "Hoa hồng đỏ";
            // 
            // picFlower1
            // 
            this.picFlower1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.picFlower1.Location = new System.Drawing.Point(15, 15);
            this.picFlower1.Name = "picFlower1";
            this.picFlower1.Size = new System.Drawing.Size(75, 75);
            this.picFlower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlower1.TabIndex = 0;
            this.picFlower1.TabStop = false;
            // 
            // panelFlower2
            // 
            this.panelFlower2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelFlower2.Controls.Add(this.lblFlower2Sales);
            this.panelFlower2.Controls.Add(this.lblFlower2Name);
            this.panelFlower2.Controls.Add(this.picFlower2);
            this.panelFlower2.Location = new System.Drawing.Point(20, 175);
            this.panelFlower2.Name = "panelFlower2";
            this.panelFlower2.Size = new System.Drawing.Size(340, 105);
            this.panelFlower2.TabIndex = 3;
            // 
            // lblFlower2Sales
            // 
            this.lblFlower2Sales.AutoSize = true;
            this.lblFlower2Sales.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFlower2Sales.ForeColor = System.Drawing.Color.Gray;
            this.lblFlower2Sales.Location = new System.Drawing.Point(106, 58);
            this.lblFlower2Sales.Name = "lblFlower2Sales";
            this.lblFlower2Sales.Size = new System.Drawing.Size(110, 31);
            this.lblFlower2Sales.TabIndex = 2;
            this.lblFlower2Sales.Text = "Đã bán: 0";
            // 
            // lblFlower2Name
            // 
            this.lblFlower2Name.AutoSize = true;
            this.lblFlower2Name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFlower2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFlower2Name.Location = new System.Drawing.Point(105, 24);
            this.lblFlower2Name.Name = "lblFlower2Name";
            this.lblFlower2Name.Size = new System.Drawing.Size(241, 36);
            this.lblFlower2Name.TabIndex = 1;
            this.lblFlower2Name.Text = "Hoa hướng dương";
            // 
            // picFlower2
            // 
            this.picFlower2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.picFlower2.Location = new System.Drawing.Point(15, 15);
            this.picFlower2.Name = "picFlower2";
            this.picFlower2.Size = new System.Drawing.Size(75, 75);
            this.picFlower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlower2.TabIndex = 0;
            this.picFlower2.TabStop = false;
            // 
            // panelFlower3
            // 
            this.panelFlower3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelFlower3.Controls.Add(this.lblFlower3Sales);
            this.panelFlower3.Controls.Add(this.lblFlower3Name);
            this.panelFlower3.Controls.Add(this.picFlower3);
            this.panelFlower3.Location = new System.Drawing.Point(20, 295);
            this.panelFlower3.Name = "panelFlower3";
            this.panelFlower3.Size = new System.Drawing.Size(340, 105);
            this.panelFlower3.TabIndex = 4;
            // 
            // lblFlower3Sales
            // 
            this.lblFlower3Sales.AutoSize = true;
            this.lblFlower3Sales.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFlower3Sales.ForeColor = System.Drawing.Color.Gray;
            this.lblFlower3Sales.Location = new System.Drawing.Point(106, 58);
            this.lblFlower3Sales.Name = "lblFlower3Sales";
            this.lblFlower3Sales.Size = new System.Drawing.Size(110, 31);
            this.lblFlower3Sales.TabIndex = 2;
            this.lblFlower3Sales.Text = "Đã bán: 0";
            // 
            // lblFlower3Name
            // 
            this.lblFlower3Name.AutoSize = true;
            this.lblFlower3Name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFlower3Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFlower3Name.Location = new System.Drawing.Point(105, 24);
            this.lblFlower3Name.Name = "lblFlower3Name";
            this.lblFlower3Name.Size = new System.Drawing.Size(128, 36);
            this.lblFlower3Name.TabIndex = 1;
            this.lblFlower3Name.Text = "Hoa tulip";
            // 
            // picFlower3
            // 
            this.picFlower3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.picFlower3.Location = new System.Drawing.Point(15, 15);
            this.picFlower3.Name = "picFlower3";
            this.picFlower3.Size = new System.Drawing.Size(75, 75);
            this.picFlower3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlower3.TabIndex = 0;
            this.picFlower3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelTopFlowers);
            this.Controls.Add(this.panelRecentOrders);
            this.Controls.Add(this.panelStats4);
            this.Controls.Add(this.panelStats3);
            this.Controls.Add(this.panelStats2);
            this.Controls.Add(this.panelStats1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Hoa - Trang chủ";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoIcon)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.panelStats1.ResumeLayout(false);
            this.panelStats1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat1)).EndInit();
            this.panelStats2.ResumeLayout(false);
            this.panelStats2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat2)).EndInit();
            this.panelStats3.ResumeLayout(false);
            this.panelStats3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat3)).EndInit();
            this.panelStats4.ResumeLayout(false);
            this.panelStats4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStat4)).EndInit();
            this.panelRecentOrders.ResumeLayout(false);
            this.panelRecentOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.panelTopFlowers.ResumeLayout(false);
            this.panelTopFlowers.PerformLayout();
            this.panelFlower1.ResumeLayout(false);
            this.panelFlower1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlower1)).EndInit();
            this.panelFlower2.ResumeLayout(false);
            this.panelFlower2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlower2)).EndInit();
            this.panelFlower3.ResumeLayout(false);
            this.panelFlower3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlower3)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogoIcon;
        private System.Windows.Forms.Label lblMainLogo;
        private System.Windows.Forms.Label lblSubLogo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFlower;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnStatistics;
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