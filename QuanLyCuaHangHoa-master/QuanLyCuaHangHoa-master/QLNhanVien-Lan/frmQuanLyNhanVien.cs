using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thêm thư viện kết nối SQL Server

namespace WindowsFormsApp1.GUI
{
    public partial class frmQuanLyNhanVien : Form
    {
        // Chuỗi kết nối đến database của nhóm
        string strConn = @"Data Source=LAPTOP-1JDF0EDQ;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True;TrustServerCertificate=True";

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
        }

        // 1. Hàm load danh sách nhân viên lên DataGridView
        // 1. Hàm load danh sách nhân viên lên DataGridView (đã tối ưu hóa làm mới dữ liệu)
        private void LoadDataNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    string query = "SELECT MaNV, HoTen, SoDienThoai, TaiKhoan, MatKhau, ChucVu FROM NhanVien";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvNhanVien.DataSource = null; // Ngắt kết nối tạm thời để xóa sạch dữ liệu cũ
                    dgvNhanVien.DataSource = dt;  // Gán bảng dữ liệu mới lấy từ SQL lên
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 2. Chức năng Nút THÊM (Nằm trong GroupBox)
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Họ tên và Tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string query = "INSERT INTO NhanVien (HoTen, SoDienThoai, TaiKhoan, MatKhau, ChucVu) VALUES (@HoTen, @SoDienThoai, @TaiKhoan, @MatKhau, @ChucVu)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text.Trim());
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text.Trim());
                        cmd.Parameters.AddWithValue("@ChucVu", cboChucVu.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //// Khi nhấn nút Thêm thì ẩn nút Sửa và Xóa đi theo yêu cầu giao diện của bạn
            //btnSua.Visible = false;
            //btnXoa.Visible = false;
        }

        // 3. Chức năng Nút SỬA (Nằm trong GroupBox)
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null || string.IsNullOrEmpty(dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString()))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string maNV = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string query = "UPDATE NhanVien SET HoTen = @HoTen, SoDienThoai = @SoDienThoai, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau, ChucVu = @ChucVu WHERE MaNV = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text.Trim());
                        cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text.Trim());
                        cmd.Parameters.AddWithValue("@ChucVu", cboChucVu.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataNhanVien();
                XoaTrangForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Chức năng Nút XÓA (Nằm trong GroupBox)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null || string.IsNullOrEmpty(dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString()))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string maNV = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();

                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();
                        string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", maNV);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataNhanVien();
                    XoaTrangForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 5. Chức năng Nút LÀM MỚI (Hiện lại nút Sửa/Xóa và reset form)
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            LoadDataNhanVien();

            // Hiện lại nút Sửa và Xóa khi làm mới
            btnSua.Visible = true;
            btnXoa.Visible = true;
        }

        // Hàm hỗ trợ làm trống các ô nhập liệu trong GroupBox
        private void XoaTrangForm()
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            if (cboChucVu.Items.Count > 0) cboChucVu.SelectedIndex = -1;
            txtHoTen.Focus();
        }

        // 6. Chức năng Tìm kiếm tự động khi gõ vào ô tìm kiếm (txtTimKiem độc lập bên ngoài)
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        // 7. Sự kiện Click vào dòng trên DataGridView để đổ dữ liệu chi tiết lên GroupBox
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Đổ dữ liệu từ bảng lên các TextBox/ComboBox nằm trong GroupBox
                txtHoTen.Text = row.Cells["HoTen"].Value != null ? row.Cells["HoTen"].Value.ToString() : "";
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value != null ? row.Cells["SoDienThoai"].Value.ToString() : "";
                txtTaiKhoan.Text = row.Cells["TaiKhoan"].Value != null ? row.Cells["TaiKhoan"].Value.ToString() : "";
                txtMatKhau.Text = row.Cells["MatKhau"].Value != null ? row.Cells["MatKhau"].Value.ToString() : "";
                cboChucVu.Text = row.Cells["ChucVu"].Value != null ? row.Cells["ChucVu"].Value.ToString() : "";
            }
        }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem người dùng có bấm phím Enter không
            if (e.KeyCode == Keys.Enter)
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                try
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        string query = "SELECT MaNV, HoTen, SoDienThoai, TaiKhoan, MatKhau, ChucVu FROM NhanVien WHERE HoTen LIKE @tuKhoa OR SoDienThoai LIKE @tuKhoa";
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        da.SelectCommand.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvNhanVien.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Chặn tiếng kêu "ting ting" mặc định của Windows khi bấm Enter trong ô TextBox
                e.SuppressKeyPress = true;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e) { }

     
    }
}