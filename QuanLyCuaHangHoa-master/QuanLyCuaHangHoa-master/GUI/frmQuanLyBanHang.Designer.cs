namespace WindowsFormsApp1.GUI
{
    partial class frmQuanLyBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyBanHang));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupSanPham = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelThanhToan = new System.Windows.Forms.Panel();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.lblTamTinhVal = new System.Windows.Forms.Label();
            this.lblPhiShip = new System.Windows.Forms.Label();
            this.nudPhiShip = new System.Windows.Forms.NumericUpDown();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.cbPhuongThucTT = new System.Windows.Forms.ComboBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienVal = new System.Windows.Forms.Label();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panelCRM = new System.Windows.Forms.Panel();
            this.groupDichVu = new System.Windows.Forms.GroupBox();
            this.lblLoiChuc = new System.Windows.Forms.Label();
            this.txtLoiChuc = new System.Windows.Forms.TextBox();
            this.groupKhachHang = new System.Windows.Forms.GroupBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.panelGioHang = new System.Windows.Forms.Panel();
            this.groupGioHang = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhiShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.panelCRM.SuspendLayout();
            this.groupDichVu.SuspendLayout();
            this.groupKhachHang.SuspendLayout();
            this.panelGioHang.SuspendLayout();
            this.groupGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.btnLichSu);
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1707, 80);
            this.panelHeader.TabIndex = 2;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblSubTitle.Location = new System.Drawing.Point(28, 49);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(432, 20);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Phần mềm bán hàng, chăm sóc khách hàng và xử lý đơn đặt hoa";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "POS - DỊCH VỤ HOA CAO CẤP";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupSanPham);
            this.panelLeft.Controls.Add(this.panelSearch);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 80);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.panelLeft.Size = new System.Drawing.Size(733, 806);
            this.panelLeft.TabIndex = 1;
            // 
            // groupSanPham
            // 
            this.groupSanPham.Controls.Add(this.dgvSanPham);
            this.groupSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupSanPham.Location = new System.Drawing.Point(16, 88);
            this.groupSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSanPham.Name = "groupSanPham";
            this.groupSanPham.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupSanPham.Size = new System.Drawing.Size(701, 703);
            this.groupSanPham.TabIndex = 0;
            this.groupSanPham.TabStop = false;
            this.groupSanPham.Text = "  Kho Sản Phẩm  ";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.Location = new System.Drawing.Point(13, 35);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(675, 656);
            this.dgvSanPham.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnThemVaoGio);
            this.panelSearch.Controls.Add(this.nudSoLuong);
            this.panelSearch.Controls.Add(this.lblSoLuong);
            this.panelSearch.Controls.Add(this.txtTimKiem);
            this.panelSearch.Controls.Add(this.lblTimKiem);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(16, 15);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(701, 73);
            this.panelSearch.TabIndex = 1;
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnThemVaoGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoGio.FlatAppearance.BorderSize = 0;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(440, 15);
            this.btnThemVaoGio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(247, 42);
            this.btnThemVaoGio.TabIndex = 0;
            this.btnThemVaoGio.Text = "+ THÊM VÀO GIỎ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudSoLuong.Location = new System.Drawing.Point(360, 21);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(67, 29);
            this.nudSoLuong.TabIndex = 1;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.Location = new System.Drawing.Point(327, 26);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(29, 20);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "SL:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiem.Location = new System.Drawing.Point(100, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 29);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.Location = new System.Drawing.Point(11, 26);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(82, 20);
            this.lblTimKiem.TabIndex = 4;
            this.lblTimKiem.Text = "TÌM KIẾM:";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelThanhToan);
            this.panelRight.Controls.Add(this.panelCRM);
            this.panelRight.Controls.Add(this.panelGioHang);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(733, 80);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.panelRight.Size = new System.Drawing.Size(974, 806);
            this.panelRight.TabIndex = 0;
            // 
            // panelThanhToan
            // 
            this.panelThanhToan.BackColor = System.Drawing.Color.White;
            this.panelThanhToan.Controls.Add(this.lblTamTinh);
            this.panelThanhToan.Controls.Add(this.lblTamTinhVal);
            this.panelThanhToan.Controls.Add(this.lblPhiShip);
            this.panelThanhToan.Controls.Add(this.nudPhiShip);
            this.panelThanhToan.Controls.Add(this.lblGiamGia);
            this.panelThanhToan.Controls.Add(this.nudGiamGia);
            this.panelThanhToan.Controls.Add(this.lblPhuongThuc);
            this.panelThanhToan.Controls.Add(this.cbPhuongThucTT);
            this.panelThanhToan.Controls.Add(this.lblTongTien);
            this.panelThanhToan.Controls.Add(this.lblTongTienVal);
            this.panelThanhToan.Controls.Add(this.btnXoaGioHang);
            this.panelThanhToan.Controls.Add(this.btnThanhToan);
            this.panelThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThanhToan.Location = new System.Drawing.Point(16, 470);
            this.panelThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelThanhToan.Name = "panelThanhToan";
            this.panelThanhToan.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelThanhToan.Size = new System.Drawing.Size(942, 321);
            this.panelThanhToan.TabIndex = 0;
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.AutoSize = true;
            this.lblTamTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTamTinh.Location = new System.Drawing.Point(27, 37);
            this.lblTamTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(87, 23);
            this.lblTamTinh.TabIndex = 0;
            this.lblTamTinh.Text = "Tạm tính:";
            // 
            // lblTamTinhVal
            // 
            this.lblTamTinhVal.AutoSize = true;
            this.lblTamTinhVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTamTinhVal.Location = new System.Drawing.Point(173, 37);
            this.lblTamTinhVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamTinhVal.Name = "lblTamTinhVal";
            this.lblTamTinhVal.Size = new System.Drawing.Size(70, 25);
            this.lblTamTinhVal.TabIndex = 1;
            this.lblTamTinhVal.Text = "0 VNĐ";
            // 
            // lblPhiShip
            // 
            this.lblPhiShip.AutoSize = true;
            this.lblPhiShip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhiShip.Location = new System.Drawing.Point(27, 86);
            this.lblPhiShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhiShip.Name = "lblPhiShip";
            this.lblPhiShip.Size = new System.Drawing.Size(134, 23);
            this.lblPhiShip.TabIndex = 2;
            this.lblPhiShip.Text = "Phí vận chuyển:";
            // 
            // nudPhiShip
            // 
            this.nudPhiShip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudPhiShip.Location = new System.Drawing.Point(173, 86);
            this.nudPhiShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPhiShip.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPhiShip.Name = "nudPhiShip";
            this.nudPhiShip.Size = new System.Drawing.Size(160, 30);
            this.nudPhiShip.TabIndex = 3;
            this.nudPhiShip.ValueChanged += new System.EventHandler(this.TinhTongTienEvent);
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGiamGia.Location = new System.Drawing.Point(27, 135);
            this.lblGiamGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(111, 23);
            this.lblGiamGia.TabIndex = 4;
            this.lblGiamGia.Text = "Giảm giá (-):";
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudGiamGia.Location = new System.Drawing.Point(173, 135);
            this.nudGiamGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudGiamGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(160, 30);
            this.nudGiamGia.TabIndex = 5;
            this.nudGiamGia.ValueChanged += new System.EventHandler(this.TinhTongTienEvent);
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhuongThuc.Location = new System.Drawing.Point(467, 37);
            this.lblPhuongThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(140, 23);
            this.lblPhuongThuc.TabIndex = 6;
            this.lblPhuongThuc.Text = "Thanh toán qua:";
            // 
            // cbPhuongThucTT
            // 
            this.cbPhuongThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhuongThucTT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPhuongThucTT.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản / QR",
            "Quẹt thẻ POS"});
            this.cbPhuongThucTT.Location = new System.Drawing.Point(627, 34);
            this.cbPhuongThucTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPhuongThucTT.Name = "cbPhuongThucTT";
            this.cbPhuongThucTT.Size = new System.Drawing.Size(279, 31);
            this.cbPhuongThucTT.TabIndex = 7;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTongTien.Location = new System.Drawing.Point(467, 98);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(256, 32);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "TỔNG THANH TOÁN:";
            // 
            // lblTongTienVal
            // 
            this.lblTongTienVal.AutoSize = true;
            this.lblTongTienVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTongTienVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.lblTongTienVal.Location = new System.Drawing.Point(460, 135);
            this.lblTongTienVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienVal.Name = "lblTongTienVal";
            this.lblTongTienVal.Size = new System.Drawing.Size(134, 50);
            this.lblTongTienVal.TabIndex = 9;
            this.lblTongTienVal.Text = "0 VNĐ";
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnXoaGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaGioHang.FlatAppearance.BorderSize = 0;
            this.btnXoaGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGioHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXoaGioHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnXoaGioHang.Location = new System.Drawing.Point(27, 222);
            this.btnXoaGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(200, 68);
            this.btnXoaGioHang.TabIndex = 10;
            this.btnXoaGioHang.Text = "XÓA GIỎ LÀM LẠI";
            this.btnXoaGioHang.UseVisualStyleBackColor = false;
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(253, 222);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(653, 68);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "HOÀN TẤT & LƯU HÓA ĐƠN (F9)";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panelCRM
            // 
            this.panelCRM.Controls.Add(this.groupDichVu);
            this.panelCRM.Controls.Add(this.groupKhachHang);
            this.panelCRM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCRM.Location = new System.Drawing.Point(16, 298);
            this.panelCRM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCRM.Name = "panelCRM";
            this.panelCRM.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelCRM.Size = new System.Drawing.Size(942, 172);
            this.panelCRM.TabIndex = 1;
            // 
            // groupDichVu
            // 
            this.groupDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.groupDichVu.Controls.Add(this.lblLoiChuc);
            this.groupDichVu.Controls.Add(this.txtLoiChuc);
            this.groupDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDichVu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupDichVu.Location = new System.Drawing.Point(440, 12);
            this.groupDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDichVu.Name = "groupDichVu";
            this.groupDichVu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDichVu.Size = new System.Drawing.Size(502, 160);
            this.groupDichVu.TabIndex = 0;
            this.groupDichVu.TabStop = false;
            this.groupDichVu.Text = "  Dịch Vụ Tặng / Băng Rôn  ";
            // 
            // lblLoiChuc
            // 
            this.lblLoiChuc.AutoSize = true;
            this.lblLoiChuc.Location = new System.Drawing.Point(20, 37);
            this.lblLoiChuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoiChuc.Name = "lblLoiChuc";
            this.lblLoiChuc.Size = new System.Drawing.Size(268, 21);
            this.lblLoiChuc.TabIndex = 0;
            this.lblLoiChuc.Text = "Nội dung thiệp / Chữ in băng rôn:";
            // 
            // txtLoiChuc
            // 
            this.txtLoiChuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoiChuc.Location = new System.Drawing.Point(24, 68);
            this.txtLoiChuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoiChuc.Multiline = true;
            this.txtLoiChuc.Name = "txtLoiChuc";
            this.txtLoiChuc.Size = new System.Drawing.Size(439, 67);
            this.txtLoiChuc.TabIndex = 1;
            // 
            // groupKhachHang
            // 
            this.groupKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.groupKhachHang.Controls.Add(this.lblSDT);
            this.groupKhachHang.Controls.Add(this.txtSDT);
            this.groupKhachHang.Controls.Add(this.lblTenKhach);
            this.groupKhachHang.Controls.Add(this.txtTenKhach);
            this.groupKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.groupKhachHang.Location = new System.Drawing.Point(0, 12);
            this.groupKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupKhachHang.Name = "groupKhachHang";
            this.groupKhachHang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupKhachHang.Size = new System.Drawing.Size(440, 160);
            this.groupKhachHang.TabIndex = 1;
            this.groupKhachHang.TabStop = false;
            this.groupKhachHang.Text = "  Thông Tin Khách Hàng  ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(20, 43);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(95, 21);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SĐT Khách:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(133, 39);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(279, 27);
            this.txtSDT.TabIndex = 1;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(20, 92);
            this.lblTenKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(92, 21);
            this.lblTenKhach.TabIndex = 2;
            this.lblTenKhach.Text = "Tên Khách:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhach.Location = new System.Drawing.Point(133, 89);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(279, 27);
            this.txtTenKhach.TabIndex = 3;
            // 
            // panelGioHang
            // 
            this.panelGioHang.Controls.Add(this.groupGioHang);
            this.panelGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGioHang.Location = new System.Drawing.Point(16, 15);
            this.panelGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGioHang.Name = "panelGioHang";
            this.panelGioHang.Size = new System.Drawing.Size(942, 283);
            this.panelGioHang.TabIndex = 2;
            // 
            // groupGioHang
            // 
            this.groupGioHang.Controls.Add(this.dgvGioHang);
            this.groupGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGioHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupGioHang.Location = new System.Drawing.Point(0, 0);
            this.groupGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupGioHang.Name = "groupGioHang";
            this.groupGioHang.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupGioHang.Size = new System.Drawing.Size(942, 283);
            this.groupGioHang.TabIndex = 0;
            this.groupGioHang.TabStop = false;
            this.groupGioHang.Text = "  Giỏ Hàng Thanh Toán  ";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGioHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGioHang.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGioHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.EnableHeadersVisualStyles = false;
            this.dgvGioHang.Location = new System.Drawing.Point(13, 35);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(916, 236);
            this.dgvGioHang.TabIndex = 0;
            // 
            // btnLichSu
            // 
            this.btnLichSu.BackColor = System.Drawing.Color.White;
            this.btnLichSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.ForeColor = System.Drawing.Color.Red;
            this.btnLichSu.Location = new System.Drawing.Point(1289, 15);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(188, 45);
            this.btnLichSu.TabIndex = 2;
            this.btnLichSu.Text = "🕒 LỊCH SỬ ĐƠN HÀNG";
            this.btnLichSu.UseVisualStyleBackColor = false;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(168, 177);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1515, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 129);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Bán Hàng - Dịch Vụ Hoa Cao Cấp";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelThanhToan.ResumeLayout(false);
            this.panelThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhiShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.panelCRM.ResumeLayout(false);
            this.groupDichVu.ResumeLayout(false);
            this.groupDichVu.PerformLayout();
            this.groupKhachHang.ResumeLayout(false);
            this.groupKhachHang.PerformLayout();
            this.panelGioHang.ResumeLayout(false);
            this.groupGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupSanPham;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelGioHang;
        private System.Windows.Forms.GroupBox groupGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;

        private System.Windows.Forms.Panel panelCRM;
        private System.Windows.Forms.GroupBox groupKhachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.GroupBox groupDichVu;
        private System.Windows.Forms.Label lblLoiChuc;
        private System.Windows.Forms.TextBox txtLoiChuc;

        private System.Windows.Forms.Panel panelThanhToan;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Label lblTamTinhVal;
        private System.Windows.Forms.Label lblPhiShip;
        private System.Windows.Forms.NumericUpDown nudPhiShip;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.ComboBox cbPhuongThucTT;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienVal;
        private System.Windows.Forms.Button btnXoaGioHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnLichSu;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}