namespace WindowsFormsApp1.GUI
{
    partial class frmThongKeSoLuongHoa
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

        // Các Card tổng quan
        private System.Windows.Forms.Panel cardSoLuongBan;
        private System.Windows.Forms.Label lblTitleSoLuongBan;
        private System.Windows.Forms.Label lblValSoLuongBan;

        private System.Windows.Forms.Panel cardBanChayNhat;
        private System.Windows.Forms.Label lblTitleBanChay;
        private System.Windows.Forms.Label lblValBanChay;

        private System.Windows.Forms.Panel cardTrungBinhNgay;
        private System.Windows.Forms.Label lblTitleTrungBinh;
        private System.Windows.Forms.Label lblValTrungBinh;

        private System.Windows.Forms.Panel cardSoLoaiHoa;
        private System.Windows.Forms.Label lblTitleSoLoai;
        private System.Windows.Forms.Label lblValSoLoai;

        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.Label lblChiTietTitle;
        private System.Windows.Forms.Label lblChiTietSub;
        private System.Windows.Forms.DataGridView dgvSoLuongHoa;

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

            this.cardSoLuongBan = new System.Windows.Forms.Panel();
            this.lblTitleSoLuongBan = new System.Windows.Forms.Label();
            this.lblValSoLuongBan = new System.Windows.Forms.Label();

            this.cardBanChayNhat = new System.Windows.Forms.Panel();
            this.lblTitleBanChay = new System.Windows.Forms.Label();
            this.lblValBanChay = new System.Windows.Forms.Label();

            this.cardTrungBinhNgay = new System.Windows.Forms.Panel();
            this.lblTitleTrungBinh = new System.Windows.Forms.Label();
            this.lblValTrungBinh = new System.Windows.Forms.Label();

            this.cardSoLoaiHoa = new System.Windows.Forms.Panel();
            this.lblTitleSoLoai = new System.Windows.Forms.Label();
            this.lblValSoLoai = new System.Windows.Forms.Label();

            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.lblChiTietTitle = new System.Windows.Forms.Label();
            this.lblChiTietSub = new System.Windows.Forms.Label();
            this.dgvSoLuongHoa = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();

            this.pnlBanner.SuspendLayout();
            this.pnlBoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChonNam)).BeginInit();
            this.cardSoLuongBan.SuspendLayout();
            this.cardBanChayNhat.SuspendLayout();
            this.cardTrungBinhNgay.SuspendLayout();
            this.cardSoLoaiHoa.SuspendLayout();
            this.pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuongHoa)).BeginInit();
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
            this.lblTitleMain.Size = new System.Drawing.Size(380, 24);
            this.lblTitleMain.Text = "🌸 THỐNG KÊ SỐ LƯỢNG HÓA";
            this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitleMain.ForeColor = System.Drawing.Color.FromArgb(219, 39, 119);

            this.lblSubTitle.Location = new System.Drawing.Point(11, 28);
            this.lblSubTitle.Size = new System.Drawing.Size(380, 18);
            this.lblSubTitle.Text = "Theo dõi sản phẩm hoa bán ra và hiệu quả kinh doanh ❀";
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);

            this.lblSlogan.Location = new System.Drawing.Point(650, 6);
            this.lblSlogan.Size = new System.Drawing.Size(265, 38);
            this.lblSlogan.Text = "Hoa tươi\ntrao yêu thương ♡";
            this.lblSlogan.Font = new System.Drawing.Font("Segoe Script", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(219, 39, 119);
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // 
            // pnlBoLoc
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
            // 4 Thẻ tổng quan (Cards) có icon sinh động
            // 
            this.cardSoLuongBan.Location = new System.Drawing.Point(10, 112);
            this.cardSoLuongBan.Size = new System.Drawing.Size(455, 58);
            this.cardSoLuongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cardSoLuongBan.BackColor = System.Drawing.Color.FromArgb(252, 231, 243);
            this.cardSoLuongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSoLuongBan.Controls.Add(this.lblTitleSoLuongBan);
            this.cardSoLuongBan.Controls.Add(this.lblValSoLuongBan);

            this.lblTitleSoLuongBan.Location = new System.Drawing.Point(10, 5);
            this.lblTitleSoLuongBan.Size = new System.Drawing.Size(430, 18);
            this.lblTitleSoLuongBan.Text = "🌷 TỔNG SỐ LƯỢNG HOA ĐÃ BÁN";
            this.lblTitleSoLuongBan.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleSoLuongBan.ForeColor = System.Drawing.Color.FromArgb(190, 24, 93);

            this.lblValSoLuongBan.Location = new System.Drawing.Point(10, 22);
            this.lblValSoLuongBan.Size = new System.Drawing.Size(430, 32);
            this.lblValSoLuongBan.Text = "---";
            this.lblValSoLuongBan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValSoLuongBan.ForeColor = System.Drawing.Color.FromArgb(157, 23, 77);

            // Card 2: Hoa bán chạy nhất
            this.cardBanChayNhat.Location = new System.Drawing.Point(481, 112);
            this.cardBanChayNhat.Size = new System.Drawing.Size(455, 58);
            this.cardBanChayNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cardBanChayNhat.BackColor = System.Drawing.Color.FromArgb(204, 251, 241);
            this.cardBanChayNhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBanChayNhat.Controls.Add(this.lblTitleBanChay);
            this.cardBanChayNhat.Controls.Add(this.lblValBanChay);

            this.lblTitleBanChay.Location = new System.Drawing.Point(10, 5);
            this.lblTitleBanChay.Size = new System.Drawing.Size(430, 18);
            this.lblTitleBanChay.Text = "⭐ HOA BÁN CHẠY NHẤT";
            this.lblTitleBanChay.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleBanChay.ForeColor = System.Drawing.Color.FromArgb(13, 148, 136);

            this.lblValBanChay.Location = new System.Drawing.Point(10, 22);
            this.lblValBanChay.Size = new System.Drawing.Size(430, 32);
            this.lblValBanChay.Text = "---";
            this.lblValBanChay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValBanChay.ForeColor = System.Drawing.Color.FromArgb(15, 118, 110);

            // Card 3: Trung bình hoa bán / ngày
            this.cardTrungBinhNgay.Location = new System.Drawing.Point(10, 176);
            this.cardTrungBinhNgay.Size = new System.Drawing.Size(455, 58);
            this.cardTrungBinhNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cardTrungBinhNgay.BackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            this.cardTrungBinhNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTrungBinhNgay.Controls.Add(this.lblTitleTrungBinh);
            this.cardTrungBinhNgay.Controls.Add(this.lblValTrungBinh);

            this.lblTitleTrungBinh.Location = new System.Drawing.Point(10, 5);
            this.lblTitleTrungBinh.Size = new System.Drawing.Size(430, 18);
            this.lblTitleTrungBinh.Text = "📊 TRUNG BÌNH HOA BÁN / NGÀY";
            this.lblTitleTrungBinh.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleTrungBinh.ForeColor = System.Drawing.Color.FromArgb(2, 132, 199);

            this.lblValTrungBinh.Location = new System.Drawing.Point(10, 22);
            this.lblValTrungBinh.Size = new System.Drawing.Size(430, 32);
            this.lblValTrungBinh.Text = "---";
            this.lblValTrungBinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValTrungBinh.ForeColor = System.Drawing.Color.FromArgb(3, 105, 161);

            // Card 4: Số loại hoa đã bán
            this.cardSoLoaiHoa.Location = new System.Drawing.Point(481, 176);
            this.cardSoLoaiHoa.Size = new System.Drawing.Size(455, 58);
            this.cardSoLoaiHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.cardSoLoaiHoa.BackColor = System.Drawing.Color.FromArgb(254, 243, 199);
            this.cardSoLoaiHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSoLoaiHoa.Controls.Add(this.lblTitleSoLoai);
            this.cardSoLoaiHoa.Controls.Add(this.lblValSoLoai);

            this.lblTitleSoLoai.Location = new System.Drawing.Point(10, 5);
            this.lblTitleSoLoai.Size = new System.Drawing.Size(430, 18);
            this.lblTitleSoLoai.Text = "🌻 SỐ LOẠI HOA ĐÃ BÁN";
            this.lblTitleSoLoai.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTitleSoLoai.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9);

            this.lblValSoLoai.Location = new System.Drawing.Point(10, 22);
            this.lblValSoLoai.Size = new System.Drawing.Size(430, 32);
            this.lblValSoLoai.Text = "---";
            this.lblValSoLoai.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValSoLoai.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14);

            // 
            // pnlChiTiet (Bảng xếp hạng hoa bán chạy)
            // 
            this.pnlChiTiet.Location = new System.Drawing.Point(10, 240);
            this.pnlChiTiet.Size = new System.Drawing.Size(926, 230);
            this.pnlChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChiTiet.BackColor = System.Drawing.Color.White;
            this.pnlChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTiet.Controls.Add(this.lblChiTietTitle);
            this.pnlChiTiet.Controls.Add(this.lblChiTietSub);
            this.pnlChiTiet.Controls.Add(this.dgvSoLuongHoa);

            this.lblChiTietTitle.Location = new System.Drawing.Point(12, 8);
            this.lblChiTietTitle.Size = new System.Drawing.Size(250, 20);
            this.lblChiTietTitle.Text = "🏆 BẢNG XẾP HẠNG HOA BÁN CHẠY";
            this.lblChiTietTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChiTietTitle.ForeColor = System.Drawing.Color.FromArgb(190, 24, 93);

            this.lblChiTietSub.Location = new System.Drawing.Point(380, 9);
            this.lblChiTietSub.Size = new System.Drawing.Size(350, 18);
            this.lblChiTietSub.Text = "Sản phẩm được sắp xếp theo số lượng bán giảm dần";
            this.lblChiTietSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblChiTietSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);

            // DataGridView
            this.dgvSoLuongHoa.Location = new System.Drawing.Point(12, 32);
            this.dgvSoLuongHoa.Size = new System.Drawing.Size(900, 185);
            this.dgvSoLuongHoa.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoLuongHoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSoLuongHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoLuongHoa.RowHeadersVisible = false;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(236, 72, 153);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvSoLuongHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoLuongHoa.ColumnHeadersHeight = 32;

            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSoLuongHoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoLuongHoa.RowTemplate.Height = 28;

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
            // frmThongKeSoLuongHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.ClientSize = new System.Drawing.Size(950, 515);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.pnlChiTiet);
            this.Controls.Add(this.cardTrungBinhNgay);
            this.Controls.Add(this.cardSoLoaiHoa);
            this.Controls.Add(this.cardBanChayNhat);
            this.Controls.Add(this.cardSoLuongBan);
            this.Controls.Add(this.pnlBoLoc);
            this.Controls.Add(this.pnlBanner);
            this.Name = "frmThongKeSoLuongHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Số Lượng Hoa";

            this.pnlBanner.ResumeLayout(false);
            this.pnlBoLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numChonNam)).EndInit();
            this.cardSoLuongBan.ResumeLayout(false);
            this.cardBanChayNhat.ResumeLayout(false);
            this.cardTrungBinhNgay.ResumeLayout(false);
            this.cardSoLoaiHoa.ResumeLayout(false);
            this.pnlChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoLuongHoa)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}