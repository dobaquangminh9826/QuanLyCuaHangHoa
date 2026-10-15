using System.Drawing;

namespace WindowsFormsApp1.GUI
{
    partial class frmQuanLyHoa
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

            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            btnTroVe = new Button();
            panelForm = new Panel();
            lblFormTitle = new Label();
            lblTenHoa = new Label();
            txtTenHoa = new TextBox();
            lblDanhMuc = new Label();
            cboDanhMuc = new ComboBox();
            lblGiaBan = new Label();
            txtGiaBan = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panelList = new Panel();
            lblListTitle = new Label();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvHoa = new DataGridView();

            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoa).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.FromArgb(253, 242, 242);
            panelHeader.Controls.Add(btnTroVe);
            panelHeader.Controls.Add(lblSubTitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(20, 20);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1240, 80);
            panelHeader.TabIndex = 0;
            // 
            // btnTroVe
            // 
            btnTroVe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTroVe.BackColor = Color.White;
            btnTroVe.Cursor = Cursors.Hand;
            btnTroVe.FlatAppearance.BorderColor = Color.FromArgb(224, 98, 103);
            btnTroVe.FlatAppearance.BorderSize = 1;
            btnTroVe.FlatStyle = FlatStyle.Flat;
            btnTroVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTroVe.ForeColor = Color.FromArgb(224, 98, 103);
            btnTroVe.Location = new Point(1040, 20);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(180, 40);
            btnTroVe.TabIndex = 2;
            btnTroVe.Text = "←  Trở về trang chủ";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitle.Location = new Point(23, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý hoa";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9.5F);
            lblSubTitle.ForeColor = Color.DimGray;
            lblSubTitle.Location = new Point(25, 50);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(250, 17);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Thêm, sửa, xóa và tra cứu sản phẩm hoa";
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(btnLamMoi);
            panelForm.Controls.Add(btnXoa);
            panelForm.Controls.Add(btnSua);
            panelForm.Controls.Add(btnThem);
            panelForm.Controls.Add(txtSoLuong);
            panelForm.Controls.Add(lblSoLuong);
            panelForm.Controls.Add(txtGiaBan);
            panelForm.Controls.Add(lblGiaBan);
            panelForm.Controls.Add(cboDanhMuc);
            panelForm.Controls.Add(lblDanhMuc);
            panelForm.Controls.Add(txtTenHoa);
            panelForm.Controls.Add(lblTenHoa);
            panelForm.Controls.Add(lblFormTitle);
            panelForm.Location = new Point(20, 120);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(380, 580);
            panelForm.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblFormTitle.Location = new Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(110, 21);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Thông tin hoa";
            // 
            // lblTenHoa
            // 
            lblTenHoa.AutoSize = true;
            lblTenHoa.Font = new Font("Segoe UI", 9.5F);
            lblTenHoa.ForeColor = Color.DimGray;
            lblTenHoa.Location = new Point(25, 62);
            lblTenHoa.Name = "lblTenHoa";
            lblTenHoa.Size = new Size(52, 17);
            lblTenHoa.TabIndex = 1;
            lblTenHoa.Text = "Tên hoa";
            // 
            // txtTenHoa
            // 
            txtTenHoa.BorderStyle = BorderStyle.FixedSingle;
            txtTenHoa.Font = new Font("Segoe UI", 10F);
            txtTenHoa.Location = new Point(25, 84);
            txtTenHoa.MaxLength = 100;
            txtTenHoa.Name = "txtTenHoa";
            txtTenHoa.Size = new Size(330, 25);
            txtTenHoa.TabIndex = 2;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.Font = new Font("Segoe UI", 9.5F);
            lblDanhMuc.ForeColor = Color.DimGray;
            lblDanhMuc.Location = new Point(25, 130);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(61, 17);
            lblDanhMuc.TabIndex = 3;
            lblDanhMuc.Text = "Danh mục";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.BackColor = Color.White;
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.FlatStyle = FlatStyle.Flat;
            cboDanhMuc.Font = new Font("Segoe UI", 10F);
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(25, 152);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(330, 25);
            cboDanhMuc.TabIndex = 4;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 9.5F);
            lblGiaBan.ForeColor = Color.DimGray;
            lblGiaBan.Location = new Point(25, 198);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(64, 17);
            lblGiaBan.TabIndex = 5;
            lblGiaBan.Text = "Giá bán (đ)";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BorderStyle = BorderStyle.FixedSingle;
            txtGiaBan.Font = new Font("Segoe UI", 10F);
            txtGiaBan.Location = new Point(25, 220);
            txtGiaBan.MaxLength = 12;
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(330, 25);
            txtGiaBan.TabIndex = 6;
            txtGiaBan.TextAlign = HorizontalAlignment.Right;
            txtGiaBan.KeyPress += txtSo_KeyPress;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 9.5F);
            lblSoLuong.ForeColor = Color.DimGray;
            lblSoLuong.Location = new Point(25, 266);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(83, 17);
            lblSoLuong.TabIndex = 7;
            lblSoLuong.Text = "Số lượng tồn";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Font = new Font("Segoe UI", 10F);
            txtSoLuong.Location = new Point(25, 288);
            txtSoLuong.MaxLength = 9;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(330, 25);
            txtSoLuong.TabIndex = 8;
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            txtSoLuong.KeyPress += txtSo_KeyPress;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(224, 98, 103);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(25, 350);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 42);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(25, 118, 210);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(195, 350);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 42);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(198, 40, 40);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(25, 402);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 42);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(120, 120, 120);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(195, 402);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(160, 42);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panelList
            // 
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.BackColor = Color.White;
            panelList.Controls.Add(dgvHoa);
            panelList.Controls.Add(txtTimKiem);
            panelList.Controls.Add(lblTimKiem);
            panelList.Controls.Add(lblListTitle);
            panelList.Location = new Point(420, 120);
            panelList.Name = "panelList";
            panelList.Size = new Size(840, 580);
            panelList.TabIndex = 2;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblListTitle.Location = new Point(20, 15);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(113, 21);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Danh sách hoa";
            // 
            // lblTimKiem
            // 
            lblTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9.5F);
            lblTimKiem.ForeColor = Color.DimGray;
            lblTimKiem.Location = new Point(490, 19);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(58, 17);
            lblTimKiem.TabIndex = 1;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(555, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(265, 25);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvHoa
            // 
            dgvHoa.AllowUserToAddRows = false;
            dgvHoa.AllowUserToDeleteRows = false;
            dgvHoa.AllowUserToResizeRows = false;
            dgvHoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoa.BackgroundColor = Color.White;
            dgvHoa.BorderStyle = BorderStyle.None;
            dgvHoa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(253, 242, 242);
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            headerStyle.ForeColor = Color.FromArgb(80, 80, 80);
            headerStyle.SelectionBackColor = Color.FromArgb(253, 242, 242);
            headerStyle.SelectionForeColor = Color.FromArgb(80, 80, 80);
            headerStyle.WrapMode = DataGridViewTriState.True;
            dgvHoa.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvHoa.ColumnHeadersHeight = 40;
            dgvHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            cellStyle.SelectionBackColor = Color.FromArgb(253, 237, 237);
            cellStyle.SelectionForeColor = Color.FromArgb(60, 60, 60);
            cellStyle.WrapMode = DataGridViewTriState.False;
            dgvHoa.DefaultCellStyle = cellStyle;
            dgvHoa.EnableHeadersVisualStyles = false;
            dgvHoa.GridColor = Color.FromArgb(235, 235, 235);
            dgvHoa.Location = new Point(20, 55);
            dgvHoa.MultiSelect = false;
            dgvHoa.Name = "dgvHoa";
            dgvHoa.ReadOnly = true;
            dgvHoa.RowHeadersVisible = false;
            dgvHoa.RowHeadersWidth = 72;
            dgvHoa.RowTemplate.Height = 38;
            dgvHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoa.Size = new Size(800, 505);
            dgvHoa.TabIndex = 3;
            dgvHoa.CellClick += dgvHoa_CellClick;
            // 
            // frmQuanLyHoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 245, 245);
            CancelButton = btnTroVe;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelList);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1000, 600);
            Name = "frmQuanLyHoa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý hoa";
            Load += frmQuanLyHoa_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoa).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTenHoa;
        private System.Windows.Forms.TextBox txtTenHoa;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvHoa;
        #endregion
    }
}
