using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.GUI
{
    public partial class frmQuanLyBanHang : Form
    {
        private string connectionString = @"Data Source=n3wgate;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";
        private DataTable dtSanPham = new DataTable();
        private DataTable dtGioHang = new DataTable();
        private decimal tongTienThucTe = 0;

        public frmQuanLyBanHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            KhoiTaoBangGioHang();
            TaiDanhSachSanPham();
        }

        private void KhoiTaoBangGioHang()
        {
            dtGioHang.Columns.Add("MaSP", typeof(string));
            dtGioHang.Columns.Add("TenSP", typeof(string));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia");
            dgvGioHang.DataSource = dtGioHang;

            if (dgvGioHang.Columns.Contains("DonGia")) dgvGioHang.Columns["DonGia"].DefaultCellStyle.Format = "#,##0 VNĐ";
            if (dgvGioHang.Columns.Contains("ThanhTien")) dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Format = "#,##0 VNĐ";
        }

        private void TaiDanhSachSanPham()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // 1. Đảm bảo câu lệnh SQL có đầy đủ cột: MaHoa, TenHoa, GiaBan, SoLuongTon
                    string query = "SELECT CAST(MaHoa AS VARCHAR(20)) AS MaSP, TenHoa AS TenSP, GiaBan AS DonGia, SoLuongTon FROM Hoa";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dtSanPham = new DataTable();
                        adapter.Fill(dtSanPham);
                        dgvSanPham.DataSource = dtSanPham;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ SQL Server: " + ex.Message);
            }

            // 2. Tắt chế độ AutoSize chung của toàn bảng để tránh xung đột
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // 3. Set cứng kích thước và thứ tự ép buộc (DisplayIndex) cho từng cột
            if (dgvSanPham.Columns.Contains("MaSP"))
            {
                dgvSanPham.Columns["MaSP"].HeaderText = "Mã SP";
                dgvSanPham.Columns["MaSP"].Width = 60; // Gọn gàng cho mã
                dgvSanPham.Columns["MaSP"].DisplayIndex = 0; // Ép nằm cột 1
            }

            if (dgvSanPham.Columns.Contains("TenSP"))
            {
                dgvSanPham.Columns["TenSP"].HeaderText = "Tên Hoa";
                // Bắt buộc độ rộng tối thiểu là 150px để không bao giờ bị biến mất
                dgvSanPham.Columns["TenSP"].MinimumWidth = 150;
                // Chỉ riêng cột Tên Hoa được phép giãn ra chiếm khoảng trống còn lại
                dgvSanPham.Columns["TenSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSanPham.Columns["TenSP"].DisplayIndex = 1; // Ép nằm cột 2
            }

            if (dgvSanPham.Columns.Contains("DonGia"))
            {
                dgvSanPham.Columns["DonGia"].HeaderText = "Giá Bán";
                dgvSanPham.Columns["DonGia"].DefaultCellStyle.Format = "#,##0 VNĐ";
                dgvSanPham.Columns["DonGia"].Width = 100; // Đủ rộng cho số tiền
                dgvSanPham.Columns["DonGia"].DisplayIndex = 2; // Ép nằm cột 3
            }

            if (dgvSanPham.Columns.Contains("SoLuongTon"))
            {
                dgvSanPham.Columns["SoLuongTon"].HeaderText = "Tồn";
                dgvSanPham.Columns["SoLuongTon"].Width = 50; // Đủ rộng cho số lượng
                dgvSanPham.Columns["SoLuongTon"].DisplayIndex = 3; // Ép nằm cột 4
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtSanPham != null && dtSanPham.Rows.Count > 0 && dtSanPham.DefaultView != null)
            {
                string keyword = txtTimKiem.Text.Trim().Replace("'", "''");
                if (string.IsNullOrEmpty(keyword)) dtSanPham.DefaultView.RowFilter = "";
                else dtSanPham.DefaultView.RowFilter = $"CONVERT(MaSP, 'System.String') LIKE '%{keyword}%' OR TenSP LIKE '%{keyword}%'";
            }
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvSanPham.SelectedRows[0];
            string maSP = row.Cells["MaSP"].Value.ToString();
            string tenSP = row.Cells["TenSP"].Value.ToString();
            decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
            int soLuongTon = Convert.ToInt32(row.Cells["SoLuongTon"].Value);
            int soLuongThem = (int)nudSoLuong.Value;

            if (soLuongThem > soLuongTon)
            {
                MessageBox.Show($"Tồn kho không đủ (chỉ còn {soLuongTon})!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow[] existingRows = dtGioHang.Select($"MaSP = '{maSP}'");
            if (existingRows.Length > 0)
            {
                int currentSL = Convert.ToInt32(existingRows[0]["SoLuong"]);
                if (currentSL + soLuongThem > soLuongTon)
                {
                    MessageBox.Show("Vượt quá số lượng tồn kho!", "Cảnh báo"); return;
                }
                existingRows[0]["SoLuong"] = currentSL + soLuongThem;
            }
            else
            {
                dtGioHang.Rows.Add(maSP, tenSP, donGia, soLuongThem);
            }
            CapNhatTongTien();
        }

        // Sự kiện khi NumericUpDown Phí Ship và Giảm Giá thay đổi
        private void TinhTongTienEvent(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal tamTinh = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                tamTinh += Convert.ToDecimal(row["ThanhTien"]);
            }

            decimal phiShip = nudPhiShip.Value;
            decimal giamGia = nudGiamGia.Value;
            tongTienThucTe = tamTinh + phiShip - giamGia;
            if (tongTienThucTe < 0) tongTienThucTe = 0;

            lblTamTinhVal.Text = string.Format("{0:#,##0} VNĐ", tamTinh);
            lblTongTienVal.Text = string.Format("{0:#,##0} VNĐ", tongTienThucTe);
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            dtGioHang.Rows.Clear();
            txtTenKhach.Clear(); txtSDT.Clear(); txtLoiChuc.Clear();
            nudPhiShip.Value = 0; nudGiamGia.Value = 0;
            CapNhatTongTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Bổ sung các thông tin mở rộng vào bảng HoaDon
                    string insertHD = @"INSERT INTO HoaDon (NgayLap, TongTien, TenKhach, SoDienThoai, NoiDungThiep, PhuongThucTT, PhiShip, GiamGia, TamTinh) 
                                        VALUES (GETDATE(), @TongTien, @TenKhach, @SDT, @LoiChuc, @PhuongThuc, @PhiShip, @GiamGia, @TamTinh);
                                        SELECT SCOPE_IDENTITY();";
                    int maHD = 0;
                    using (SqlCommand cmd = new SqlCommand(insertHD, conn))
                    {
                        cmd.Parameters.AddWithValue("@TongTien", tongTienThucTe);
                        cmd.Parameters.AddWithValue("@TenKhach", txtTenKhach.Text.Trim());
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                        cmd.Parameters.AddWithValue("@LoiChuc", txtLoiChuc.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhuongThuc", cbPhuongThucTT.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@PhiShip", nudPhiShip.Value);
                        cmd.Parameters.AddWithValue("@GiamGia", nudGiamGia.Value);

                        decimal tamTinh = 0;
                        foreach (DataRow r in dtGioHang.Rows) tamTinh += Convert.ToDecimal(r["ThanhTien"]);
                        cmd.Parameters.AddWithValue("@TamTinh", tamTinh);

                        maHD = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Lưu Chi Tiết và Trừ Kho
                    foreach (DataRow row in dtGioHang.Rows)
                    {
                        string maHoa = row["MaSP"].ToString();
                        int soLuong = Convert.ToInt32(row["SoLuong"]);

                        try
                        {
                            string insertCT = "INSERT INTO ChiTietHoaDon (MaHD, MaHoa, SoLuong, DonGia) VALUES (@MaHD, @MaHoa, @SoLuong, @DonGia)";
                            using (SqlCommand cmdCT = new SqlCommand(insertCT, conn))
                            {
                                cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                                cmdCT.Parameters.AddWithValue("@MaHoa", maHoa);
                                cmdCT.Parameters.AddWithValue("@SoLuong", soLuong);
                                cmdCT.Parameters.AddWithValue("@DonGia", row["DonGia"]);
                                cmdCT.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi lưu Chi tiết hóa đơn: " + ex.Message, "Phát hiện lỗi SQL");
                        }

                        string updateKho = "UPDATE Hoa SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaHoa = @MaHoa AND SoLuongTon >= @SoLuong";
                        using (SqlCommand cmdKho = new SqlCommand(updateKho, conn))
                        {
                            cmdKho.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdKho.Parameters.AddWithValue("@MaHoa", maHoa);
                            cmdKho.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Thanh toán đơn hàng xuất sắc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnXoaGioHang_Click(null, null);
                TaiDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message, "Lỗi hệ thống");
            }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSuBanHang f = new frmLichSuBanHang();
            f.ShowDialog();
        }
    }
}