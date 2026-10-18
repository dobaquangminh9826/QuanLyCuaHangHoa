using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class frmDangNhap
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
            panelLeft = new Panel();
            lblCopyright = new Label();
            lblWelcomeSub = new Label();
            lblWelcome = new Label();
            lblSubLogo = new Label();
            lblMainLogo = new Label();
            picLogoIcon = new PictureBox();
            panelRight = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            chkHienMatKhau = new CheckBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTaiKhoan = new TextBox();
            lblTaiKhoan = new Label();
            lblSubTitle = new Label();
            lblTitle = new Label();

            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoIcon).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();

            // panelLeft
            panelLeft.BackColor = Color.FromArgb(253, 242, 242);
            panelLeft.Controls.Add(lblCopyright);
            panelLeft.Controls.Add(lblWelcomeSub);
            panelLeft.Controls.Add(lblWelcome);
            panelLeft.Controls.Add(lblSubLogo);
            panelLeft.Controls.Add(lblMainLogo);
            panelLeft.Controls.Add(picLogoIcon);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(400, 600);
            panelLeft.TabIndex = 0;

            // picLogoIcon
            picLogoIcon.BackColor = Color.White;
            picLogoIcon.Location = new Point(40, 160);
            picLogoIcon.Name = "picLogoIcon";
            picLogoIcon.Size = new Size(64, 64);
            picLogoIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoIcon.TabIndex = 0;
            picLogoIcon.TabStop = false;

            // lblMainLogo
            lblMainLogo.AutoSize = true;
            lblMainLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMainLogo.ForeColor = Color.FromArgb(40, 40, 40);
            lblMainLogo.Location = new Point(116, 164);
            lblMainLogo.Name = "lblMainLogo";
            lblMainLogo.Size = new Size(200, 32);
            lblMainLogo.TabIndex = 1;
            lblMainLogo.Text = "Cửa Hàng Hoa";

            // lblSubLogo
            lblSubLogo.AutoSize = true;
            lblSubLogo.Font = new Font("Segoe UI", 10F);
            lblSubLogo.ForeColor = Color.Gray;
            lblSubLogo.Location = new Point(118, 200);
            lblSubLogo.Name = "lblSubLogo";
            lblSubLogo.Size = new Size(130, 19);
            lblSubLogo.TabIndex = 2;
            lblSubLogo.Text = "Hoa tươi mỗi ngày";

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(224, 98, 103);
            lblWelcome.Location = new Point(40, 300);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(240, 32);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Chào mừng trở lại!";

            // lblWelcomeSub
            lblWelcomeSub.Font = new Font("Segoe UI", 11F);
            lblWelcomeSub.ForeColor = Color.DimGray;
            lblWelcomeSub.Location = new Point(42, 345);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(320, 60);
            lblWelcomeSub.TabIndex = 4;
            lblWelcomeSub.Text = "Đăng nhập để quản lý hoa, đơn hàng và nhân viên của cửa hàng.";

            // lblCopyright
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 9.5F);
            lblCopyright.ForeColor = Color.Gray;
            lblCopyright.Location = new Point(40, 550);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(160, 17);
            lblCopyright.TabIndex = 5;
            lblCopyright.Text = "© 2026 Cửa Hàng Hoa";

            // panelRight
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(btnThoat);
            panelRight.Controls.Add(btnDangNhap);
            panelRight.Controls.Add(chkHienMatKhau);
            panelRight.Controls.Add(txtMatKhau);
            panelRight.Controls.Add(lblMatKhau);
            panelRight.Controls.Add(txtTaiKhoan);
            panelRight.Controls.Add(lblTaiKhoan);
            panelRight.Controls.Add(lblSubTitle);
            panelRight.Controls.Add(lblTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(400, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(600, 600);
            panelRight.TabIndex = 1;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitle.Location = new Point(80, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng nhập";

            // lblSubTitle
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 11F);
            lblSubTitle.ForeColor = Color.Gray;
            lblSubTitle.Location = new Point(83, 145);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(250, 20);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Vui lòng nhập thông tin tài khoản";

            // lblTaiKhoan
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTaiKhoan.ForeColor = Color.FromArgb(60, 60, 60);
            lblTaiKhoan.Location = new Point(83, 205);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(70, 19);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "Tài khoản";

            // txtTaiKhoan
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 12F);
            txtTaiKhoan.Location = new Point(80, 230);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(440, 29);
            txtTaiKhoan.TabIndex = 0;

            // lblMatKhau
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.FromArgb(60, 60, 60);
            lblMatKhau.Location = new Point(83, 285);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(66, 19);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";

            // txtMatKhau
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(80, 310);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(440, 29);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;

            // chkHienMatKhau
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Font = new Font("Segoe UI", 10F);
            chkHienMatKhau.ForeColor = Color.DimGray;
            chkHienMatKhau.Location = new Point(82, 355);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(130, 23);
            chkHienMatKhau.TabIndex = 2;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;

            // btnDangNhap
            btnDangNhap.BackColor = Color.FromArgb(224, 98, 103);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(80, 405);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(440, 48);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;

            // btnThoat
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 11F);
            btnThoat.ForeColor = Color.DimGray;
            btnThoat.Location = new Point(80, 465);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(440, 48);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;

            // frmDangNhap
            AcceptButton = btnDangNhap;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Cửa Hàng Hoa";

            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoIcon).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private PictureBox picLogoIcon;
        private Label lblMainLogo;
        private Label lblSubLogo;
        private Label lblWelcome;
        private Label lblWelcomeSub;
        private Label lblCopyright;
        private Label lblTitle;
        private Label lblSubTitle;
        private Label lblTaiKhoan;
        private Label lblMatKhau;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox chkHienMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}