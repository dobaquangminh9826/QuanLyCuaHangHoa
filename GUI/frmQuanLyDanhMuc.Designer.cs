using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    partial class frmQuanLyDanhMuc
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
            lblMa = new Label();
            txtMaDanhMuc = new TextBox();
            lblTen = new Label();
            txtTenDanhMuc = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panelList = new Panel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvDanhMuc = new DataGridView();

            panelHeader.SuspendLayout();
            panelInput.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(253, 242, 242);
            panelHeader.Controls.Add(btnTroVe);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 70);
            panelHeader.TabIndex = 0;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitle.Location = new Point(30, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý danh mục";

            // btnTroVe
            btnTroVe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTroVe.BackColor = Color.White;
            btnTroVe.Cursor = Cursors.Hand;
            btnTroVe.FlatAppearance.BorderColor = Color.FromArgb(224, 98, 103);
            btnTroVe.FlatStyle = FlatStyle.Flat;
            btnTroVe.Font = new Font("Segoe UI", 10F);
            btnTroVe.ForeColor = Color.FromArgb(224, 98, 103);
            btnTroVe.Location = new Point(760, 18);
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
            panelInput.Controls.Add(txtTenDanhMuc);
            panelInput.Controls.Add(lblTen);
            panelInput.Controls.Add(txtMaDanhMuc);
            panelInput.Controls.Add(lblMa);
            panelInput.Location = new Point(30, 95);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(300, 470);
            panelInput.TabIndex = 1;

            // lblMa
            lblMa.AutoSize = true;
            lblMa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMa.ForeColor = Color.FromArgb(60, 60, 60);
            lblMa.Location = new Point(20, 22);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(95, 19);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã danh mục";

            // txtMaDanhMuc
            txtMaDanhMuc.BackColor = Color.FromArgb(245, 245, 245);
            txtMaDanhMuc.BorderStyle = BorderStyle.FixedSingle;
            txtMaDanhMuc.Font = new Font("Segoe UI", 11F);
            txtMaDanhMuc.Location = new Point(20, 47);
            txtMaDanhMuc.Name = "txtMaDanhMuc";
            txtMaDanhMuc.ReadOnly = true;
            txtMaDanhMuc.Size = new Size(260, 27);
            txtMaDanhMuc.TabIndex = 1;
            txtMaDanhMuc.TabStop = false;

            // lblTen
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTen.ForeColor = Color.FromArgb(60, 60, 60);
            lblTen.Location = new Point(20, 97);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(98, 19);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên danh mục";

            // txtTenDanhMuc
            txtTenDanhMuc.BorderStyle = BorderStyle.FixedSingle;
            txtTenDanhMuc.Font = new Font("Segoe UI", 11F);
            txtTenDanhMuc.Location = new Point(20, 122);
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.Size = new Size(260, 27);
            txtTenDanhMuc.TabIndex = 0;

            // btnThem
            btnThem.BackColor = Color.FromArgb(224, 98, 103);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 185);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(260, 42);
            btnThem.TabIndex = 1;
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
            btnSua.Location = new Point(20, 237);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(260, 42);
            btnSua.TabIndex = 2;
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
            btnXoa.Location = new Point(20, 289);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(260, 42);
            btnXoa.TabIndex = 3;
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
            btnLamMoi.Location = new Point(20, 341);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(260, 42);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;

            // panelList
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.BackColor = Color.White;
            panelList.Controls.Add(dgvDanhMuc);
            panelList.Controls.Add(txtTimKiem);
            panelList.Controls.Add(lblTimKiem);
            panelList.Location = new Point(350, 95);
            panelList.Name = "panelList";
            panelList.Size = new Size(520, 470);
            panelList.TabIndex = 2;

            // lblTimKiem
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.FromArgb(60, 60, 60);
            lblTimKiem.Location = new Point(20, 22);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(110, 19);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm theo tên";

            // txtTimKiem
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 11F);
            txtTimKiem.Location = new Point(20, 47);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(480, 27);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;

            // dgvDanhMuc
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AllowUserToDeleteRows = false;
            dgvDanhMuc.AllowUserToResizeRows = false;
            dgvDanhMuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.BackgroundColor = Color.White;
            dgvDanhMuc.BorderStyle = BorderStyle.None;
            dgvDanhMuc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhMuc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(253, 242, 242);
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            headerStyle.ForeColor = Color.FromArgb(80, 80, 80);
            headerStyle.SelectionBackColor = Color.FromArgb(253, 242, 242);
            headerStyle.SelectionForeColor = Color.FromArgb(80, 80, 80);
            dgvDanhMuc.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvDanhMuc.ColumnHeadersHeight = 40;
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            cellStyle.SelectionBackColor = Color.FromArgb(253, 237, 237);
            cellStyle.SelectionForeColor = Color.FromArgb(60, 60, 60);
            dgvDanhMuc.DefaultCellStyle = cellStyle;
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.GridColor = Color.FromArgb(235, 235, 235);
            dgvDanhMuc.Location = new Point(20, 90);
            dgvDanhMuc.MultiSelect = false;
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.RowTemplate.Height = 36;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.Size = new Size(480, 360);
            dgvDanhMuc.TabIndex = 1;
            dgvDanhMuc.CellClick += dgvDanhMuc_CellClick;

            // frmQuanLyDanhMuc
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(248, 245, 245);
            ClientSize = new Size(900, 600);
            Controls.Add(panelList);
            Controls.Add(panelInput);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 550);
            Name = "frmQuanLyDanhMuc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý danh mục - Cửa Hàng Hoa";
            Load += frmQuanLyDanhMuc_Load;

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnTroVe;
        private Panel panelInput;
        private Label lblMa;
        private TextBox txtMaDanhMuc;
        private Label lblTen;
        private TextBox txtTenDanhMuc;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel panelList;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvDanhMuc;
    }
}