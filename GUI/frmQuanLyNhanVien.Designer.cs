namespace WindowsFormsApp1.GUI
{
    partial class frmQuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupThongTin = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cbLocChucVu = new System.Windows.Forms.ComboBox();
            this.lblLocChucVu = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupThongTin.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1533, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblSubTitle.Location = new System.Drawing.Point(28, 49);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(427, 20);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Cập nhật hồ sơ, phân quyền tài khoản nhân viên trong hệ thống";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ NHÂN VIÊN CỬA HÀNG";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupThongTin);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 80);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.panelLeft.Size = new System.Drawing.Size(560, 757);
            this.panelLeft.TabIndex = 1;
            // 
            // groupThongTin
            // 
            this.groupThongTin.BackColor = System.Drawing.Color.White;
            this.groupThongTin.Controls.Add(this.btnXoa);
            this.groupThongTin.Controls.Add(this.btnLamMoi);
            this.groupThongTin.Controls.Add(this.btnLuu);
            this.groupThongTin.Controls.Add(this.rbNu);
            this.groupThongTin.Controls.Add(this.rbNam);
            this.groupThongTin.Controls.Add(this.lblGioiTinh);
            this.groupThongTin.Controls.Add(this.cbChucVu);
            this.groupThongTin.Controls.Add(this.lblChucVu);
            this.groupThongTin.Controls.Add(this.txtMatKhau);
            this.groupThongTin.Controls.Add(this.lblMatKhau);
            this.groupThongTin.Controls.Add(this.txtTaiKhoan);
            this.groupThongTin.Controls.Add(this.lblTaiKhoan);
            this.groupThongTin.Controls.Add(this.txtSoDienThoai);
            this.groupThongTin.Controls.Add(this.lblSoDienThoai);
            this.groupThongTin.Controls.Add(this.txtHoTen);
            this.groupThongTin.Controls.Add(this.lblHoTen);
            this.groupThongTin.Controls.Add(this.txtMaNV);
            this.groupThongTin.Controls.Add(this.lblMaNV);
            this.groupThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.groupThongTin.Location = new System.Drawing.Point(16, 15);
            this.groupThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.groupThongTin.Size = new System.Drawing.Size(528, 727);
            this.groupThongTin.TabIndex = 0;
            this.groupThongTin.TabStop = false;
            this.groupThongTin.Text = "  Thông Tin Nhân Viên  ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnXoa.Location = new System.Drawing.Point(271, 578);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(233, 47);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "XÓA NV";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnLamMoi.Location = new System.Drawing.Point(24, 578);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(233, 47);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(24, 517);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(480, 49);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "LƯU THÔNG TIN";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbNu.Location = new System.Drawing.Point(240, 453);
            this.rbNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(52, 25);
            this.rbNu.TabIndex = 3;
            this.rbNu.Text = "Nữ";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbNam.Location = new System.Drawing.Point(133, 453);
            this.rbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(65, 25);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 455);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(76, 20);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý",
            "Cắm hoa chính",
            "Bán hàng",
            "Thu ngân",
            "Giao hàng"});
            this.cbChucVu.Location = new System.Drawing.Point(24, 406);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(479, 29);
            this.cbChucVu.TabIndex = 6;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChucVu.Location = new System.Drawing.Point(20, 382);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(71, 20);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMatKhau.Location = new System.Drawing.Point(24, 338);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '•';
            this.txtMatKhau.Size = new System.Drawing.Size(479, 29);
            this.txtMatKhau.TabIndex = 8;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.Location = new System.Drawing.Point(20, 314);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(81, 20);
            this.lblMatKhau.TabIndex = 9;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTaiKhoan.Location = new System.Drawing.Point(24, 271);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(479, 29);
            this.txtTaiKhoan.TabIndex = 10;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTaiKhoan.Location = new System.Drawing.Point(20, 246);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(93, 20);
            this.lblTaiKhoan.TabIndex = 11;
            this.lblTaiKhoan.Text = "Tài Khoản *:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(24, 203);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(479, 29);
            this.txtSoDienThoai.TabIndex = 12;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 178);
            this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(109, 20);
            this.lblSoDienThoai.TabIndex = 13;
            this.lblSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHoTen.Location = new System.Drawing.Point(24, 135);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(479, 29);
            this.txtHoTen.TabIndex = 14;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Location = new System.Drawing.Point(20, 111);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(93, 20);
            this.lblHoTen.TabIndex = 15;
            this.lblHoTen.Text = "Họ và Tên *:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaNV.Location = new System.Drawing.Point(24, 68);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(479, 29);
            this.txtMaNV.TabIndex = 16;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.Location = new System.Drawing.Point(20, 43);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(123, 20);
            this.lblMaNV.TabIndex = 17;
            this.lblMaNV.Text = "Mã Nhân Viên *:";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupDanhSach);
            this.panelRight.Controls.Add(this.panelFilter);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(560, 80);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.panelRight.Size = new System.Drawing.Size(973, 757);
            this.panelRight.TabIndex = 2;
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Controls.Add(this.dgvNhanVien);
            this.groupDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.groupDanhSach.Location = new System.Drawing.Point(16, 88);
            this.groupDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDanhSach.Name = "groupDanhSach";
            this.groupDanhSach.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupDanhSach.Size = new System.Drawing.Size(941, 654);
            this.groupDanhSach.TabIndex = 1;
            this.groupDanhSach.TabStop = false;
            this.groupDanhSach.Text = "  Danh Sách Nhân Viên  ";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(13, 35);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 32;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(915, 607);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.cbLocChucVu);
            this.panelFilter.Controls.Add(this.lblLocChucVu);
            this.panelFilter.Controls.Add(this.txtTimKiem);
            this.panelFilter.Controls.Add(this.lblTimKiem);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(16, 15);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(941, 73);
            this.panelFilter.TabIndex = 0;
            // 
            // cbLocChucVu
            // 
            this.cbLocChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocChucVu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbLocChucVu.FormattingEnabled = true;
            this.cbLocChucVu.Items.AddRange(new object[] {
            "Tất cả",
            "Nhân viên",
            "Quản lý",
            "Cắm hoa chính",
            "Bán hàng",
            "Thu ngân",
            "Giao hàng"});
            this.cbLocChucVu.Location = new System.Drawing.Point(587, 21);
            this.cbLocChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLocChucVu.Name = "cbLocChucVu";
            this.cbLocChucVu.Size = new System.Drawing.Size(319, 29);
            this.cbLocChucVu.TabIndex = 0;
            this.cbLocChucVu.SelectedIndexChanged += new System.EventHandler(this.cbLocChucVu_SelectedIndexChanged);
            // 
            // lblLocChucVu
            // 
            this.lblLocChucVu.AutoSize = true;
            this.lblLocChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLocChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLocChucVu.Location = new System.Drawing.Point(493, 26);
            this.lblLocChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocChucVu.Name = "lblLocChucVu";
            this.lblLocChucVu.Size = new System.Drawing.Size(79, 20);
            this.lblLocChucVu.TabIndex = 1;
            this.lblLocChucVu.Text = "CHỨC VỤ:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiem.Location = new System.Drawing.Point(107, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(345, 29);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTimKiem.Location = new System.Drawing.Point(16, 26);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(82, 20);
            this.lblTimKiem.TabIndex = 3;
            this.lblTimKiem.Text = "TÌM KIẾM:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 131;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 131;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 131;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 131;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 131;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 131;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 130;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 131;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 131;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 131;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 130;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 131;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Column14";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 915;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 131;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 130;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 131;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.Width = 131;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.Width = 131;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.Width = 130;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Column20";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.Width = 131;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "MaNV";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 915;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1533, 837);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Nhân Viên - Cửa Hàng Hoa";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupThongTin.ResumeLayout(false);
            this.groupThongTin.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupThongTin;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocChucVu;
        private System.Windows.Forms.ComboBox cbLocChucVu;
        private System.Windows.Forms.GroupBox groupDanhSach;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
    }
}