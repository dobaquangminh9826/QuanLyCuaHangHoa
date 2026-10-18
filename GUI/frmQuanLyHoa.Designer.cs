using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    partial class frmQuanLyHoa
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            panelHeader = new Panel();
            lblTitle = new Label();
            btnTroVe = new Button();
            panelInput = new Panel();
            lblTen = new Label();
            txtTenHoa = new TextBox();
            lblDanhMuc = new Label();
            cboDanhMuc = new ComboBox();
            lblGia = new Label();
            txtGiaBan = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panelList = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvHoa = new DataGridView();

            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoa).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(253, 242, 242);
            panelHeader.Controls.Add(btnTroVe);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 70);
            panelHeader.TabIndex = 0;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitle.Location = new Point(30, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý hoa";

            // btnTroVe
            btnTroVe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTroVe.BackColor = Color.White;
            btnTroVe.Cursor = Cursors.Hand;
            btnTroVe.FlatAppearance.BorderColor = Color.FromArgb(224, 98, 103);
            btnTroVe.FlatStyle = FlatStyle.Flat;
            btnTroVe.Font = new Font("Segoe UI", 10F);
            btnTroVe.ForeColor = Color.FromArgb(224, 98, 103);
            btnTroVe.Location = new Point(860, 18);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(110, 36);
            btnTroVe.TabIndex = 1;
            btnTroVe.Text = "← Trở về";
            btnTroVe.UseVisualStyleBackColor = false;
            btnTroVe.Click += btnTroVe_Click;

            // panelInput
            panelInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(btnLamMoi);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnSua);
            panelInput.Controls.Add(btnThem);
            panelInput.Controls.Add(txtSoLuong);
            panelInput.Controls.Add(lblSoLuong);
            panelInput.Controls.Add(txtGiaBan);
            panelInput.Controls.Add(lblGia);
            panelInput.Controls.Add(cboDanhMuc);
            panelInput.Controls.Add(lblDanhMuc);
            panelInput.Controls.Add(txtTenHoa);
            panelInput.Controls.Add(lblTen);
            panelInput.Location = new Point(30, 95);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(320, 570);
            panelInput.TabIndex = 1;

            // lblTen
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTen.ForeColor = Color.FromArgb(60, 60, 60);
            lblTen.Location = new Point(20, 20);
            lblTen.Name = "lblTen";
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên hoa";

            // txtTenHoa
            txtTenHoa.BorderStyle = BorderStyle.FixedSingle;
            txtTenHoa.Font = new Font("Segoe UI", 11F);
            txtTenHoa.Location = new Point(20, 44);
            txtTenHoa.Name = "txtTenHoa";
            txtTenHoa.Size = new Size(280, 27);
            txtTenHoa.TabIndex = 0;

            // lblDanhMuc
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanhMuc.ForeColor = Color.FromArgb(60, 60, 60);
            lblDanhMuc.Location = new Point(20, 92);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.TabIndex = 2;
            lblDanhMuc.Text = "Danh mục";

            // cboDanhMuc
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.FlatStyle = FlatStyle.Flat;
            cboDanhMuc.Font = new Font("Segoe UI", 11F);
            cboDanhMuc.Location = new Point(20, 116);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(280, 28);
            cboDanhMuc.TabIndex = 1;

            // lblGia
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGia.ForeColor = Color.FromArgb(60, 60, 60);
            lblGia.Location = new Point(20, 164);
            lblGia.Name = "lblGia";
            lblGia.TabIndex = 4;
            lblGia.Text = "Giá bán (đ)";

            // txtGiaBan
            txtGiaBan.BorderStyle = BorderStyle.FixedSingle;
            txtGiaBan.Font = new Font("Segoe UI", 11F);
            txtGiaBan.Location = new Point(20, 188);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(280, 27);
            txtGiaBan.TabIndex = 2;
            txtGiaBan.TextAlign = HorizontalAlignment.Right;
            txtGiaBan.KeyPress += txtSo_KeyPress;

            // lblSoLuong
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoLuong.ForeColor = Color.FromArgb(60, 60, 60);
            lblSoLuong.Location = new Point(20, 236);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.TabIndex = 6;
            lblSoLuong.Text = "Số lượng tồn";

            // txtSoLuong
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Font = new Font("Segoe UI", 11F);
            txtSoLuong.Location = new Point(20, 260);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(280, 27);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            txtSoLuong.KeyPress += txtSo_KeyPress;

            // btnThem
            btnThem.BackColor = Color.FromArgb(224, 98, 103);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 330);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(280, 42);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;

            // btnSua
            btnSua.BackColor = Color.FromArgb(25, 118, 210);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(20, 382);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(280, 42);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;

            // btnXoa
            btnXoa.BackColor = Color.FromArgb(198, 40, 40);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(20, 434);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(280, 42);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;

            // btnLamMoi
            btnLamMoi.BackColor = Color.White;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 11F);
            btnLamMoi.ForeColor = Color.DimGray;
            btnLamMoi.Location = new Point(20, 486);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(280, 42);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;

            // panelList
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.BackColor = Color.White;
            panelList.Controls.Add(dgvHoa);
            panelList.Controls.Add(txtTimKiem);
            panelList.Controls.Add(lblTimKiem);
            panelList.Location = new Point(370, 95);
            panelList.Name = "panelList";
            panelList.Size = new Size(600, 570);
            panelList.TabIndex = 2;

            // lblTimKiem
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTimKiem.Location = new Point(20, 18);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm theo tên hoa hoặc danh mục";

            // txtTimKiem
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 11F);
            txtTimKiem.Location = new Point(20, 42);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(560, 27);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            // dgvHoa
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
            dgvHoa.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvHoa.ColumnHeadersHeight = 40;
            dgvHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            cellStyle.SelectionBackColor = Color.FromArgb(253, 237, 237);
            cellStyle.SelectionForeColor = Color.FromArgb(60, 60, 60);
            dgvHoa.DefaultCellStyle = cellStyle;
            dgvHoa.EnableHeadersVisualStyles = false;
            dgvHoa.GridColor = Color.FromArgb(235, 235, 235);
            dgvHoa.Location = new Point(20, 85);
            dgvHoa.MultiSelect = false;
            dgvHoa.Name = "dgvHoa";
            dgvHoa.ReadOnly = true;
            dgvHoa.RowHeadersVisible = false;
            dgvHoa.RowTemplate.Height = 36;
            dgvHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoa.Size = new Size(560, 465);
            dgvHoa.TabIndex = 1;
            dgvHoa.CellClick += dgvHoa_CellClick;

            // frmQuanLyHoa
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(248, 245, 245);
            ClientSize = new Size(1000, 700);
            Controls.Add(panelList);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(900, 650);
            Name = "frmQuanLyHoa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý hoa - Cửa Hàng Hoa";
            Load += frmQuanLyHoa_Load;

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnTroVe;
        private Panel panelInput;
        private Label lblTen;
        private TextBox txtTenHoa;
        private Label lblDanhMuc;
        private ComboBox cboDanhMuc;
        private Label lblGia;
        private TextBox txtGiaBan;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel panelList;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvHoa;
    }
}