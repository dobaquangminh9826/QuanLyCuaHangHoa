namespace WindowsFormsApp1.GUI
{
    partial class frmThongKe
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.grpTongQuan = new System.Windows.Forms.GroupBox();
            this.panelDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThuTitle = new System.Windows.Forms.Label();
            this.lblDoanhThuValue = new System.Windows.Forms.Label();
            this.lineDoanhThu = new System.Windows.Forms.Panel();
            this.panelSoLuong = new System.Windows.Forms.Panel();
            this.lblSoLuongTitle = new System.Windows.Forms.Label();
            this.lblSoLuongValue = new System.Windows.Forms.Label();
            this.lineSoLuong = new System.Windows.Forms.Panel();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.lblHoaDonTitle = new System.Windows.Forms.Label();
            this.lblHoaDonValue = new System.Windows.Forms.Label();
            this.lineHoaDon = new System.Windows.Forms.Panel();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnThongKeSoLuong = new System.Windows.Forms.Button();
            this.btnThongKeHoaDon = new System.Windows.Forms.Button();
            this.grpTongQuan.SuspendLayout();
            this.panelDoanhThu.SuspendLayout();
            this.panelSoLuong.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(103)))));
            this.lblTitle.Location = new System.Drawing.Point(45, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(687, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🌸 THỐNG KÊ - BÁO CÁO";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblSubTitle.Location = new System.Drawing.Point(50, 109);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(632, 37);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Tổng quan hoạt động kinh doanh của cửa hàng hoa";
            // 
            // grpTongQuan
            // 
            this.grpTongQuan.Controls.Add(this.panelDoanhThu);
            this.grpTongQuan.Controls.Add(this.panelSoLuong);
            this.grpTongQuan.Controls.Add(this.panelHoaDon);
            this.grpTongQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.grpTongQuan.Location = new System.Drawing.Point(45, 172);
            this.grpTongQuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTongQuan.Name = "grpTongQuan";
            this.grpTongQuan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpTongQuan.Size = new System.Drawing.Size(1305, 281);
            this.grpTongQuan.TabIndex = 2;
            this.grpTongQuan.TabStop = false;
            this.grpTongQuan.Text = "🌸 TỔNG QUAN";
            // 
            // panelDoanhThu
            // 
            this.panelDoanhThu.BackColor = System.Drawing.Color.White;
            this.panelDoanhThu.Controls.Add(this.lblDoanhThuTitle);
            this.panelDoanhThu.Controls.Add(this.lblDoanhThuValue);
            this.panelDoanhThu.Controls.Add(this.lineDoanhThu);
            this.panelDoanhThu.Location = new System.Drawing.Point(30, 55);
            this.panelDoanhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(398, 188);
            this.panelDoanhThu.TabIndex = 0;
            // 
            // lblDoanhThuTitle
            // 
            this.lblDoanhThuTitle.AutoSize = true;
            this.lblDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDoanhThuTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblDoanhThuTitle.Location = new System.Drawing.Point(22, 23);
            this.lblDoanhThuTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            this.lblDoanhThuTitle.Size = new System.Drawing.Size(281, 41);
            this.lblDoanhThuTitle.TabIndex = 0;
            this.lblDoanhThuTitle.Text = "💰 Tổng doanh thu";
            // 
            // lblDoanhThuValue
            // 
            this.lblDoanhThuValue.AutoSize = true;
            this.lblDoanhThuValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuValue.ForeColor = System.Drawing.Color.Black;
            this.lblDoanhThuValue.Location = new System.Drawing.Point(22, 70);
            this.lblDoanhThuValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoanhThuValue.Name = "lblDoanhThuValue";
            this.lblDoanhThuValue.Size = new System.Drawing.Size(89, 59);
            this.lblDoanhThuValue.TabIndex = 1;
            this.lblDoanhThuValue.Text = "0 đ";
            // 
            // lineDoanhThu
            // 
            this.lineDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.lineDoanhThu.Location = new System.Drawing.Point(0, 181);
            this.lineDoanhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineDoanhThu.Name = "lineDoanhThu";
            this.lineDoanhThu.Size = new System.Drawing.Size(398, 6);
            this.lineDoanhThu.TabIndex = 2;
            // 
            // panelSoLuong
            // 
            this.panelSoLuong.BackColor = System.Drawing.Color.White;
            this.panelSoLuong.Controls.Add(this.lblSoLuongTitle);
            this.panelSoLuong.Controls.Add(this.lblSoLuongValue);
            this.panelSoLuong.Controls.Add(this.lineSoLuong);
            this.panelSoLuong.Location = new System.Drawing.Point(450, 55);
            this.panelSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSoLuong.Name = "panelSoLuong";
            this.panelSoLuong.Size = new System.Drawing.Size(398, 188);
            this.panelSoLuong.TabIndex = 1;
            // 
            // lblSoLuongTitle
            // 
            this.lblSoLuongTitle.AutoSize = true;
            this.lblSoLuongTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSoLuongTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSoLuongTitle.Location = new System.Drawing.Point(22, 23);
            this.lblSoLuongTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongTitle.Name = "lblSoLuongTitle";
            this.lblSoLuongTitle.Size = new System.Drawing.Size(344, 41);
            this.lblSoLuongTitle.TabIndex = 0;
            this.lblSoLuongTitle.Text = "💐 Số lượng hoa đã bán";
            // 
            // lblSoLuongValue
            // 
            this.lblSoLuongValue.AutoSize = true;
            this.lblSoLuongValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongValue.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuongValue.Location = new System.Drawing.Point(22, 70);
            this.lblSoLuongValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongValue.Name = "lblSoLuongValue";
            this.lblSoLuongValue.Size = new System.Drawing.Size(50, 59);
            this.lblSoLuongValue.TabIndex = 1;
            this.lblSoLuongValue.Text = "0";
            // 
            // lineSoLuong
            // 
            this.lineSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.lineSoLuong.Location = new System.Drawing.Point(0, 181);
            this.lineSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineSoLuong.Name = "lineSoLuong";
            this.lineSoLuong.Size = new System.Drawing.Size(398, 6);
            this.lineSoLuong.TabIndex = 2;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.BackColor = System.Drawing.Color.White;
            this.panelHoaDon.Controls.Add(this.lblHoaDonTitle);
            this.panelHoaDon.Controls.Add(this.lblHoaDonValue);
            this.panelHoaDon.Controls.Add(this.lineHoaDon);
            this.panelHoaDon.Location = new System.Drawing.Point(870, 55);
            this.panelHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(398, 188);
            this.panelHoaDon.TabIndex = 2;
            // 
            // lblHoaDonTitle
            // 
            this.lblHoaDonTitle.AutoSize = true;
            this.lblHoaDonTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHoaDonTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblHoaDonTitle.Location = new System.Drawing.Point(22, 23);
            this.lblHoaDonTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoaDonTitle.Name = "lblHoaDonTitle";
            this.lblHoaDonTitle.Size = new System.Drawing.Size(294, 41);
            this.lblHoaDonTitle.TabIndex = 0;
            this.lblHoaDonTitle.Text = "📄 Tổng số hóa đơn";
            // 
            // lblHoaDonValue
            // 
            this.lblHoaDonValue.AutoSize = true;
            this.lblHoaDonValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHoaDonValue.ForeColor = System.Drawing.Color.Black;
            this.lblHoaDonValue.Location = new System.Drawing.Point(22, 70);
            this.lblHoaDonValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoaDonValue.Name = "lblHoaDonValue";
            this.lblHoaDonValue.Size = new System.Drawing.Size(50, 59);
            this.lblHoaDonValue.TabIndex = 1;
            this.lblHoaDonValue.Text = "0";
            // 
            // lineHoaDon
            // 
            this.lineHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.lineHoaDon.Location = new System.Drawing.Point(0, 181);
            this.lineHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineHoaDon.Name = "lineHoaDon";
            this.lineHoaDon.Size = new System.Drawing.Size(398, 6);
            this.lineHoaDon.TabIndex = 2;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnThongKeDoanhThu);
            this.grpChucNang.Controls.Add(this.btnThongKeSoLuong);
            this.grpChucNang.Controls.Add(this.btnThongKeHoaDon);
            this.grpChucNang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.grpChucNang.Location = new System.Drawing.Point(45, 484);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChucNang.Size = new System.Drawing.Size(1305, 203);
            this.grpChucNang.TabIndex = 3;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "🌸 CHỨC NĂNG THỐNG KÊ";
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnThongKeDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnThongKeDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKeDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(30, 70);
            this.btnThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(398, 78);
            this.btnThongKeDoanhThu.TabIndex = 0;
            this.btnThongKeDoanhThu.Text = "💰 Thống kê doanh thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click_1);
            // 
            // btnThongKeSoLuong
            // 
            this.btnThongKeSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnThongKeSoLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeSoLuong.FlatAppearance.BorderSize = 0;
            this.btnThongKeSoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSoLuong.ForeColor = System.Drawing.Color.White;
            this.btnThongKeSoLuong.Location = new System.Drawing.Point(450, 70);
            this.btnThongKeSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKeSoLuong.Name = "btnThongKeSoLuong";
            this.btnThongKeSoLuong.Size = new System.Drawing.Size(398, 78);
            this.btnThongKeSoLuong.TabIndex = 1;
            this.btnThongKeSoLuong.Text = "💐 Thống kê số lượng";
            this.btnThongKeSoLuong.UseVisualStyleBackColor = false;
            this.btnThongKeSoLuong.Click += new System.EventHandler(this.btnThongKeSoLuong_Click_1);
            // 
            // btnThongKeHoaDon
            // 
            this.btnThongKeHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnThongKeHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeHoaDon.FlatAppearance.BorderSize = 0;
            this.btnThongKeHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKeHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnThongKeHoaDon.Location = new System.Drawing.Point(870, 70);
            this.btnThongKeHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKeHoaDon.Name = "btnThongKeHoaDon";
            this.btnThongKeHoaDon.Size = new System.Drawing.Size(398, 78);
            this.btnThongKeHoaDon.TabIndex = 2;
            this.btnThongKeHoaDon.Text = "📄 Thống kê hóa đơn";
            this.btnThongKeHoaDon.UseVisualStyleBackColor = false;
            this.btnThongKeHoaDon.Click += new System.EventHandler(this.btnThongKeHoaDon_Click_1);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1425, 938);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.grpTongQuan);
            this.Controls.Add(this.grpChucNang);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🌸 Thống kê báo cáo của cửa hàng hoa";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.grpTongQuan.ResumeLayout(false);
            this.panelDoanhThu.ResumeLayout(false);
            this.panelDoanhThu.PerformLayout();
            this.panelSoLuong.ResumeLayout(false);
            this.panelSoLuong.PerformLayout();
            this.panelHoaDon.ResumeLayout(false);
            this.panelHoaDon.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox grpTongQuan;
        private System.Windows.Forms.Panel panelDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuTitle;
        private System.Windows.Forms.Label lblDoanhThuValue;
        private System.Windows.Forms.Panel lineDoanhThu;
        private System.Windows.Forms.Panel panelSoLuong;
        private System.Windows.Forms.Label lblSoLuongTitle;
        private System.Windows.Forms.Label lblSoLuongValue;
        private System.Windows.Forms.Panel lineSoLuong;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.Label lblHoaDonTitle;
        private System.Windows.Forms.Label lblHoaDonValue;
        private System.Windows.Forms.Panel lineHoaDon;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnThongKeSoLuong;
        private System.Windows.Forms.Button btnThongKeHoaDon;
    }
}