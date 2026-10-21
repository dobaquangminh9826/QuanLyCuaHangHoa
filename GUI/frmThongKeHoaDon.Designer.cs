namespace WindowsFormsApp1.GUI
{
    partial class frmThongKeHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblSlogan;

        private System.Windows.Forms.Panel pnlBoLoc;
        private System.Windows.Forms.Label lblBoLocTitle;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cmbHinhThuc;

        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.DateTimePicker dtpChonNgay;

        private System.Windows.Forms.Label lblChonNam;
        private System.Windows.Forms.NumericUpDown numChonNam;

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDatLai;

        // Các Card tổng quan (3 thẻ)
        private System.Windows.Forms.TableLayoutPanel pnlCards;
        private System.Windows.Forms.Panel cardSoHoaDon;
        private System.Windows.Forms.Label lblTitleSoHD;
        private System.Windows.Forms.Label lblValSoHD;

        private System.Windows.Forms.Panel cardTongDoanhThu;
        private System.Windows.Forms.Label lblTitleDoanhThu;
        private System.Windows.Forms.Label lblValDoanhThu;

        private System.Windows.Forms.Panel cardTrungBinh;
        private System.Windows.Forms.Label lblTitleTrungBinh;
        private System.Windows.Forms.Label lblValTrungBinh;

        // Bảng chi tiết hóa đơn
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.Label lblChiTietTitle;
        private System.Windows.Forms.Label lblChiTietSub;
        private System.Windows.Forms.DataGridView dgvHoaDon;

        private System.Windows.Forms.Button btnQuayLai;

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

            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();

            this.pnlBoLoc = new System.Windows.Forms.Panel();
            this.lblBoLocTitle = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cmbHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.dtpChonNgay = new System.Windows.Forms.DateTimePicker();
            this.lblChonNam = new System.Windows.Forms.Label();
            this.numChonNam = new System.Windows.Forms.NumericUpDown();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();

            this.pnlCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardSoHoaDon = new System.Windows.Forms.Panel();
            this.lblTitleSoHD = new System.Windows.Forms.Label();
            this.lblValSoHD = new System.Windows.Forms.Label();

            this.cardTongDoanhThu = new System.Windows.Forms.Panel();
            this.lblTitleDoanhThu = new System.Windows.Forms.Label();
            this.lblValDoanhThu = new System.Windows.Forms.Label();

            this.cardTrungBinh = new System.Windows.Forms.Panel();
            this.lblTitleTrungBinh = new System.Windows.Forms.Label();
            this.lblValTrungBinh = new System.Windows.Forms.Label();

            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.lblChiTietTitle = new System.Windows.Forms.Label();
            this.lblChiTietSub = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();

            this.pnlBanner.SuspendLayout();
            this.pnlBoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChonNam)).BeginInit();
            this.pnlCards.SuspendLayout();
            this.cardSoHoaDon.SuspendLayout();
            this.cardTongDoanhThu.SuspendLayout();
            this.cardTrungBinh.SuspendLayout();
            this.pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlBanner
            // 
            this.pnlBanner.Location = new System.Drawing.Point(10, 8);
            this.pnlBanner.Size = new System.Drawing.Size(926, 50);
            this.pnlBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(253, 237, 242);
            this.pnlBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBanner.Controls.Add(this.lblTitleMain);
            this.pnlBanner.Controls.Add(this.lblSubTitle);
            this.pnlBanner.Controls.Add(this.lblSlogan);

            this.lblTitleMain.Location = new System.Drawing.Point(10, 4);
            this.lblTitleMain.Size = new System.Drawing.Size(350, 24);
            this.lblTitleMain.Text = "🌸 THỐNG KÊ HÓA ĐƠN";
            this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitleMain.ForeColor = System.Drawing.Color.FromArgb(219, 39, 119);

            this.lblSubTitle.Location = new System.Drawing.Point(11, 28);
            this.lblSubTitle.Size = new System.Drawing.Size(420, 18);
            this.lblSubTitle.Text = "Theo dõi hóa đơn và tình hình kinh doanh của cửa hàng hoa ♡";
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);

            this.lblSlogan.Location = new System.Drawing.Point(650, 6);
            this.lblSlogan.Size = new System.Drawing.Size(265, 38);
            this.lblSlogan.Text = "Hoa tươi\ntrao yêu thương ♡";
            this.lblSlogan.Font = new System.Drawing.Font("Segoe Script", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(219, 39, 119);
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // 
            // pnlBoLoc (Chuẩn đồng bộ các form)
            // 
            this.pnlBoLoc.Location = new System.Drawing.Point(10, 62);
            this.pnlBoLoc.Size = new System.Drawing.Size(926, 46);
            this.pnlBoLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBoLoc.BackColor = System.Drawing.Color.FromArgb(240, 253, 250);
            this.pnlBoLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBoLoc.Controls.Add(this.lblBoLocTitle);
            this.pnlBoLoc.Controls.Add(this.lblHinhThuc);
            this.pnlBoLoc.Controls.Add(this.cmbHinhThuc);
            this.pnlBoLoc.Controls.Add(this.lblChonNgay);
            this.pnlBoLoc.Controls.Add(this.dtpChonNgay);
            this.pnlBoLoc.Controls.Add(this.lblChonNam);
            this.pnlBoLoc.Controls.Add(this.numChonNam);
            this.pnlBoLoc.Controls.Add(this.btnThongKe);
            this.pnlBoLoc.Controls.Add(this.btnDatLai);

            this.lblBoLocTitle.Location = new System.Drawing.Point(8, 13);
            this.lblBoLocTitle.Size = new System.Drawing.Size(120, 20);
            this.lblBoLocTitle.Text = "❖ BỘ LỌC THỜI GIAN";
            this.lblBoLocTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBoLocTitle.ForeColor = System.Drawing.Color.FromArgb(13, 148, 136);

            this.lblHinhThuc.Location = new System.Drawing.Point(130, 13);
            this.lblHinhThuc.Size = new System.Drawing.Size(70, 20);
            this.lblHinhThuc.Text = "Hình thức:";
            this.lblHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.cmbHinhThuc.Location = new System.Drawing.Point(202, 10);
            this.cmbHinhThuc.Size = new System.Drawing.Size(100, 26);
            this.cmbHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbHinhThuc.Items.AddRange(new object[] { "Theo ngày", "Theo tháng", "Theo quý", "Theo năm" });
            this.cmbHinhThuc.SelectedIndex = 0;

            this.lblChonNgay.Location = new System.Drawing.Point(310, 13);
            this.lblChonNgay.Size = new System.Drawing.Size(75, 20);
            this.lblChonNgay.Text = "📅 Ngày:";
            this.lblChonNgay.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.dtpChonNgay.Location = new System.Drawing.Point(385, 10);
            this.dtpChonNgay.Size = new System.Drawing.Size(105, 26);
            this.dtpChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChonNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpChonNgay.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.lblChonNam.Location = new System.Drawing.Point(498, 13);
            this.lblChonNam.Size = new System.Drawing.Size(65, 20);
            this.lblChonNam.Text = "📆 Năm:";
            this.lblChonNam.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.numChonNam.Location = new System.Drawing.Point(565, 10);
            this.numChonNam.Size = new System.Drawing.Size(65, 26);
            this.numChonNam.Minimum = 2000;
            this.numChonNam.Maximum = 2100;
            this.numChonNam.Value = 2026;
            this.numChonNam.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.btnThongKe.Location = new System.Drawing.Point(642, 9);
            this.btnThongKe.Size = new System.Drawing.Size(88, 28);
            this.btnThongKe.Text = "🔍 Thống kê";
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(236, 72, 153);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnDatLai.Location = new System.Drawing.Point(737, 9);
            this.btnDatLai.Size = new System.Drawing.Size(82, 28);
            this.btnDatLai.Text = "↺ Đặt lại";
            this.btnDatLai.BackColor = System.Drawing.Color.White;
            this.btnDatLai.ForeColor = System.Drawing.Color.FromArgb(219, 39, 119);
            this.btnDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(219, 39, 119);
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatLai.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // pnlCards (3 Thẻ tổng quan chia đều)
            // 
            this.pnlCards.Location = new System.Drawing.Point(10, 112);
            this.pnlCards.Size = new System.Drawing.Size(926, 58);
            this.pnlCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCards.ColumnCount = 3;
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlCards.Controls.Add(this.cardSoHoaDon, 0, 0);
            this.pnlCards.Controls.Add(this.cardTongDoanhThu, 1, 0);
            this.pnlCards.Controls.Add(this.cardTrungBinh, 2, 0);

            // Card 1
            this.cardSoHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSoHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cardSoHoaDon.BackColor = System.Drawing.Color.FromArgb(252, 231, 243);
            this.cardSoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSoHoaDon.Controls.Add(this.lblTitleSoHD);
            this.cardSoHoaDon.Controls.Add(this.lblValSoHD);

            this.lblTitleSoHD.Location = new System.Drawing.Point(8, 5);
            this.lblTitleSoHD.Size = new System.Drawing.Size(280, 18);
            this.lblTitleSoHD.Text = "📋 TỔNG SỐ HÓA ĐƠN";
            this.lblTitleSoHD.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleSoHD.ForeColor = System.Drawing.Color.FromArgb(190, 24, 93);

            this.lblValSoHD.Location = new System.Drawing.Point(8, 22);
            this.lblValSoHD.Size = new System.Drawing.Size(280, 32);
            this.lblValSoHD.Text = "0";
            this.lblValSoHD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValSoHD.ForeColor = System.Drawing.Color.FromArgb(157, 23, 77);

            // Card 2
            this.cardTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTongDoanhThu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cardTongDoanhThu.BackColor = System.Drawing.Color.FromArgb(204, 251, 241);
            this.cardTongDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTongDoanhThu.Controls.Add(this.lblTitleDoanhThu);
            this.cardTongDoanhThu.Controls.Add(this.lblValDoanhThu);

            this.lblTitleDoanhThu.Location = new System.Drawing.Point(8, 5);
            this.lblTitleDoanhThu.Size = new System.Drawing.Size(280, 18);
            this.lblTitleDoanhThu.Text = "💰 TỔNG DOANH THU";
            this.lblTitleDoanhThu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleDoanhThu.ForeColor = System.Drawing.Color.FromArgb(13, 148, 136);

            this.lblValDoanhThu.Location = new System.Drawing.Point(8, 22);
            this.lblValDoanhThu.Size = new System.Drawing.Size(280, 32);
            this.lblValDoanhThu.Text = "0 VNĐ";
            this.lblValDoanhThu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValDoanhThu.ForeColor = System.Drawing.Color.FromArgb(15, 118, 110);

            // Card 3
            this.cardTrungBinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTrungBinh.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cardTrungBinh.BackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            this.cardTrungBinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTrungBinh.Controls.Add(this.lblTitleTrungBinh);
            this.cardTrungBinh.Controls.Add(this.lblValTrungBinh);

            this.lblTitleTrungBinh.Location = new System.Drawing.Point(8, 5);
            this.lblTitleTrungBinh.Size = new System.Drawing.Size(280, 18);
            this.lblTitleTrungBinh.Text = "📊 TRUNG BÌNH / HÓA ĐƠN";
            this.lblTitleTrungBinh.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleTrungBinh.ForeColor = System.Drawing.Color.FromArgb(2, 132, 199);

            this.lblValTrungBinh.Location = new System.Drawing.Point(8, 22);
            this.lblValTrungBinh.Size = new System.Drawing.Size(280, 32);
            this.lblValTrungBinh.Text = "0 VNĐ";
            this.lblValTrungBinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValTrungBinh.ForeColor = System.Drawing.Color.FromArgb(3, 105, 161);

            // 
            // pnlChiTiet (Bảng chi tiết hóa đơn)
            // 
            this.pnlChiTiet.Location = new System.Drawing.Point(10, 178);
            this.pnlChiTiet.Size = new System.Drawing.Size(926, 292);
            this.pnlChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChiTiet.BackColor = System.Drawing.Color.White;
            this.pnlChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTiet.Controls.Add(this.lblChiTietTitle);
            this.pnlChiTiet.Controls.Add(this.lblChiTietSub);
            this.pnlChiTiet.Controls.Add(this.dgvHoaDon);

            this.lblChiTietTitle.Location = new System.Drawing.Point(12, 8);
            this.lblChiTietTitle.Size = new System.Drawing.Size(180, 20);
            this.lblChiTietTitle.Text = "⚙ CHI TIẾT HÓA ĐƠN";
            this.lblChiTietTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChiTietTitle.ForeColor = System.Drawing.Color.FromArgb(190, 24, 93);

            this.lblChiTietSub.Location = new System.Drawing.Point(200, 9);
            this.lblChiTietSub.Size = new System.Drawing.Size(350, 18);
            this.lblChiTietSub.Text = "Danh sách hóa đơn theo khoảng thời gian đã chọn";
            this.lblChiTietSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblChiTietSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);

            // DataGridView
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 32);
            this.dgvHoaDon.Size = new System.Drawing.Size(900, 245);
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.RowHeadersVisible = false;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(236, 72, 153);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeight = 32;

            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.RowTemplate.Height = 28;

            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(826, 480);
            this.btnQuayLai.Size = new System.Drawing.Size(110, 28);
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuayLai.Text = "← Quay lại";
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(236, 72, 153);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;

            // 
            // frmThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(950, 515);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.pnlChiTiet);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlBoLoc);
            this.Controls.Add(this.pnlBanner);
            this.Name = "frmThongKeHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Hóa Đơn";

            this.pnlBanner.ResumeLayout(false);
            this.pnlBoLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numChonNam)).EndInit();
            this.pnlCards.ResumeLayout(false);
            this.cardSoHoaDon.ResumeLayout(false);
            this.cardTongDoanhThu.ResumeLayout(false);
            this.cardTrungBinh.ResumeLayout(false);
            this.pnlChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}