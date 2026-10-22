namespace WindowsFormsApp1.GUI
{
    partial class frmTimKiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoa = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgKetQua = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 114);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(344, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm theo hoa, khách hàng, hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "🔍 TÌM KIẾM";
            // 
            // btnHoa
            // 
            this.btnHoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.btnHoa.Location = new System.Drawing.Point(28, 194);
            this.btnHoa.Name = "btnHoa";
            this.btnHoa.Size = new System.Drawing.Size(390, 87);
            this.btnHoa.TabIndex = 1;
            this.btnHoa.Text = "❀  Hoa";
            this.btnHoa.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.btnKhachHang.Location = new System.Drawing.Point(442, 194);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(390, 87);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "👥  Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.btnHoaDon.Location = new System.Drawing.Point(864, 194);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(390, 87);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "📋  Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại thông tin cần tìm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(21, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ khóa tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.btnTimKiem.Location = new System.Drawing.Point(306, 430);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(300, 70);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(111)))), ((int)(((byte)(149)))));
            this.btnLamMoi.Location = new System.Drawing.Point(628, 430);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(300, 70);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(28, 352);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1226, 59);
            this.txtTimKiem.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(21, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách kết quả";
            // 
            // dtgKetQua
            // 
            this.dtgKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKetQua.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgKetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKetQua.EnableHeadersVisualStyles = false;
            this.dtgKetQua.Location = new System.Drawing.Point(28, 569);
            this.dtgKetQua.Name = "dtgKetQua";
            this.dtgKetQua.RowHeadersVisible = false;
            this.dtgKetQua.RowHeadersWidth = 82;
            this.dtgKetQua.RowTemplate.Height = 33;
            this.dtgKetQua.Size = new System.Drawing.Size(1226, 227);
            this.dtgKetQua.TabIndex = 12;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1291, 855);
            this.Controls.Add(this.dtgKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnHoa);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoa;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgKetQua;
    }
}