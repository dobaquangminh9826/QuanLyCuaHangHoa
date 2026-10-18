using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmQuanLyNhanVien : Form
    {
        private string connectionString = @"Data Source=LAPTOP-1JDF0EDQ;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";
        private DataTable dtNhanVien = new DataTable();

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            cbChucVu.SelectedIndex = 0;
            cbLocChucVu.SelectedIndex = 0;
            TaiDanhSachNhanVien();
        }

        private void TaiDanhSachNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Đã xóa cột MatKhau khỏi câu lệnh SELECT để không nạp lên giao diện
                    // Chỉ hiển thị nhân viên đang làm việc
                    string query = "SELECT MaNV, HoTen, SoDienThoai, TaiKhoan, ChucVu, GioiTinh FROM NhanVien WHERE TrangThai = N'Đang làm việc'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dtNhanVien.Clear();
                        adapter.Fill(dtNhanVien);

                        // --- BẮT ĐẦU TẠO CỘT CỨNG BẰNG CODE ---
                        dgvNhanVien.Columns.Clear(); // Dọn sạch cột rác (nếu có)
                        dgvNhanVien.AutoGenerateColumns = false; // Tắt tính năng tự sinh cột
                        dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // 1. Cột Mã NV
                        dgvNhanVien.Columns.Add("colMaNV", "Mã NV");
                        dgvNhanVien.Columns["colMaNV"].DataPropertyName = "MaNV"; // Khớp với SQL
                        dgvNhanVien.Columns["colMaNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                        // 2. Cột Họ Tên
                        dgvNhanVien.Columns.Add("colHoTen", "Họ và Tên");
                        dgvNhanVien.Columns["colHoTen"].DataPropertyName = "HoTen";
                        dgvNhanVien.Columns["colHoTen"].Width = 150; // Cho cột tên rộng hơn 1 chút

                        // 3. Cột Số Điện Thoại
                        dgvNhanVien.Columns.Add("colSDT", "Số Điện Thoại");
                        dgvNhanVien.Columns["colSDT"].DataPropertyName = "SoDienThoai";

                        // 4. Cột Tài Khoản
                        dgvNhanVien.Columns.Add("colTaiKhoan", "Tài Khoản");
                        dgvNhanVien.Columns["colTaiKhoan"].DataPropertyName = "TaiKhoan";

                        // 5. Cột Chức Vụ
                        dgvNhanVien.Columns.Add("colChucVu", "Chức Vụ");
                        dgvNhanVien.Columns["colChucVu"].DataPropertyName = "ChucVu";

                        // 6. Cột Giới Tính
                        dgvNhanVien.Columns.Add("colGioiTinh", "Giới Tính");
                        dgvNhanVien.Columns["colGioiTinh"].DataPropertyName = "GioiTinh";
                        // --- KẾT THÚC TẠO CỘT ---

                        // Nạp dữ liệu vào bảng
                        dgvNhanVien.DataSource = dtNhanVien;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ SQL Server: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApDungLoc()
        {
            if (dtNhanVien == null || dtNhanVien.Rows.Count == 0) return;

            string keyword = txtTimKiem.Text.Trim().Replace("'", "''");
            string chucVuLoc = cbLocChucVu.SelectedItem?.ToString();

            keyword = txtTimKiem.Text.Trim();
            string filter = $"CONVERT(MaNV, 'System.String') LIKE '%{keyword}%' OR HoTen LIKE '%{keyword}%'";

            if (!string.IsNullOrEmpty(chucVuLoc) && chucVuLoc != "Tất cả")
            {
                filter += $" AND (ChucVu = '{chucVuLoc}')";
            }

            DataView dv = dtNhanVien.DefaultView;
            dv.RowFilter = filter;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApDungLoc();
        }

        private void cbLocChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApDungLoc();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["colMaNV"].Value?.ToString();
                txtMaNV.ReadOnly = true;

                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["colSDT"].Value?.ToString();
                txtTaiKhoan.Text = row.Cells["colTaiKhoan"].Value?.ToString();
                //txtMatKhau.Text = row.Cells["colMatKhau"].Value?.ToString();

                string chucVu = row.Cells["colChucVu"].Value?.ToString();
                if (!string.IsNullOrEmpty(chucVu) && cbChucVu.Items.Contains(chucVu))
                {
                    cbChucVu.SelectedItem = chucVu;
                }

                string gioiTinh = row.Cells["colGioiTinh"].Value?.ToString();
                if (gioiTinh == "Nữ") rbNu.Checked = true;
                else rbNam.Checked = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string chucVu = cbChucVu.SelectedItem?.ToString();
            string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(taiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NV, Họ tên và Tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                    bool isExist = false;
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaNV", maNV);
                        isExist = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    }

                    string sql = "";
                    if (isExist)
                    {
                        sql = @"UPDATE NhanVien 
                                SET HoTen = @HoTen, SoDienThoai = @SoDienThoai, TaiKhoan = @TaiKhoan, 
                                    MatKhau = @MatKhau, ChucVu = @ChucVu, GioiTinh = @GioiTinh 
                                WHERE MaNV = @MaNV";
                    }
                    else
                    {
                        sql = @"INSERT INTO NhanVien (MaNV, HoTen, SoDienThoai, TaiKhoan, MatKhau, ChucVu, GioiTinh) 
                                VALUES (@MaNV, @HoTen, @SoDienThoai, @TaiKhoan, @MatKhau, @ChucVu, @GioiTinh)";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@HoTen", (object)hoTen ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoDienThoai", (object)sdt ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TaiKhoan", (object)taiKhoan ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MatKhau", (object)matKhau ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ChucVu", (object)chucVu ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", (object)gioiTinh ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lưu thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                TaiDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txtMaNV.Clear();
            txtMaNV.ReadOnly = false;
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            cbChucVu.SelectedIndex = 0;
            rbNam.Checked = true;
            dgvNhanVien.ClearSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn nhân viên chưa
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng click chọn một nhân viên trong bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn cho nhân viên {txtHoTen.Text} nghỉ việc không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        // Dùng lệnh UPDATE thay vì DELETE
                        string query = "UPDATE NhanVien SET TrangThai = N'Đã nghỉ việc' WHERE MaNV = @MaNV";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã chuyển trạng thái nhân viên thành 'Đã nghỉ việc'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa trắng các ô nhập liệu bên trái
                    btnLamMoi_Click(sender, e); // Gọi hàm của nút Làm mới nếu có

                    // Tải lại danh sách (nhân viên vừa xóa sẽ biến mất khỏi DataGridView)
                    TaiDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}