using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using  WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.GUI
{
    public partial class frmQuanLyNhanVien : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";
        private DataTable dtNhanVien = new DataTable();

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            if (cbChucVu.Items.Count > 0) cbChucVu.SelectedIndex = 0;
            if (cbLocChucVu.Items.Count > 0) cbLocChucVu.SelectedIndex = 0;
            TaiDanhSachNhanVien();
        }

        private void TaiDanhSachNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaNV, HoTen, SoDienThoai, TaiKhoan, ChucVu, GioiTinh FROM NhanVien WHERE TrangThai = N'Đang làm việc'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dtNhanVien.Clear();
                        adapter.Fill(dtNhanVien);

                        dgvNhanVien.Columns.Clear();
                        dgvNhanVien.AutoGenerateColumns = false;
                        dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        dgvNhanVien.Columns.Add("colMaNV", "Mã NV");
                        dgvNhanVien.Columns["colMaNV"].DataPropertyName = "MaNV";
                        dgvNhanVien.Columns["colMaNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                        dgvNhanVien.Columns.Add("colHoTen", "Họ và Tên");
                        dgvNhanVien.Columns["colHoTen"].DataPropertyName = "HoTen";
                        dgvNhanVien.Columns["colHoTen"].Width = 150;

                        dgvNhanVien.Columns.Add("colSDT", "Số Điện Thoại");
                        dgvNhanVien.Columns["colSDT"].DataPropertyName = "SoDienThoai";

                        dgvNhanVien.Columns.Add("colTaiKhoan", "Tài Khoản");
                        dgvNhanVien.Columns["colTaiKhoan"].DataPropertyName = "TaiKhoan";

                        dgvNhanVien.Columns.Add("colChucVu", "Chức Vụ");
                        dgvNhanVien.Columns["colChucVu"].DataPropertyName = "ChucVu";

                        dgvNhanVien.Columns.Add("colGioiTinh", "Giới Tính");
                        dgvNhanVien.Columns["colGioiTinh"].DataPropertyName = "GioiTinh";

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
                txtMaNV.ReadOnly = true; // Khóa mã nhân viên khi đang chọn sửa

                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["colSDT"].Value?.ToString();
                txtTaiKhoan.Text = row.Cells["colTaiKhoan"].Value?.ToString();

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

            // 1. Kiểm tra rỗng cơ bản
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

            bool isUpdate = txtMaNV.ReadOnly && !string.IsNullOrEmpty(maNV);

            string sql = "";
            if (isUpdate)
            {
                // Cập nhật thông tin nhân viên
                sql = @"UPDATE NhanVien 
                        SET HoTen = @HoTen, SoDienThoai = @SoDienThoai, TaiKhoan = @TaiKhoan, 
                            ChucVu = @ChucVu, GioiTinh = @GioiTinh" +
                            (!string.IsNullOrEmpty(matKhau) ? ", MatKhau = @MatKhau" : "") +
                            " WHERE MaNV = @MaNV";
            }
            else
            {
                // Thêm mới (Kiểm tra xem tài khoản đã tồn tại chưa để tránh lỗi trùng lặp)
                string checkAcc = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @TaiKhoan";
                using (SqlCommand cmdCheck = new SqlCommand(checkAcc, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    int countAcc = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (countAcc > 0)
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại trong hệ thống. Vلui lòng chọn tài khoản khác!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                     sql = @"INSERT INTO NhanVien (MaNV, HoTen, SoDienThoai, TaiKhoan, MatKhau, ChucVu, GioiTinh, TrangThai) 
                        VALUES (@MaNV, @HoTen, @SoDienThoai, @TaiKhoan, @MatKhau, @ChucVu, @GioiTinh, N'Đang làm việc')";
                    }

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@SoDienThoai", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt);
                cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", string.IsNullOrEmpty(matKhau) ? "123456" : matKhau);
                cmd.Parameters.AddWithValue("@ChucVu", (object)chucVu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                if (isUpdate)
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                }

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
            if (cbChucVu.Items.Count > 0) cbChucVu.SelectedIndex = 0;
            rbNam.Checked = true;
            dgvNhanVien.ClearSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng click chọn một nhân viên trong bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn cho nhân viên {txtHoTen.Text} nghỉ việc không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE NhanVien SET TrangThai = N'Đã nghỉ việc' WHERE MaNV = @MaNV";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã chuyển trạng thái nhân viên thành 'Đã nghỉ việc'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiForm();
                    TaiDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật trạng thái nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}