using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.GUI
{
    public partial class frmQuanLyDanhMuc : Form
    {
        // Mã danh mục đang được chọn (-1 = chưa chọn)
        private int maDanhMucDangChon = -1;

        public frmQuanLyDanhMuc()
        {
            InitializeComponent();
            AcceptButton = btnThem;   // Nhấn Enter trong ô tên = Thêm
        }

        // =====================================================
        // 1. KHI MỞ FORM
        // =====================================================
        private void frmQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            LamMoiControls();
        }

        // =====================================================
        // 2. LOAD DANH SÁCH DANH MỤC
        // =====================================================
        private void LoadDanhSach()
        {
            try
            {
                dgvDanhMuc.DataSource = DanhMucBUS.LayDanhSachDanhMuc();

                if (dgvDanhMuc.Columns["MaDanhMuc"] != null)
                {
                    dgvDanhMuc.Columns["MaDanhMuc"].HeaderText = "Mã danh mục";
                    dgvDanhMuc.Columns["MaDanhMuc"].FillWeight = 30;
                }

                if (dgvDanhMuc.Columns["TenDanhMuc"] != null)
                {
                    dgvDanhMuc.Columns["TenDanhMuc"].HeaderText = "Tên danh mục";
                    dgvDanhMuc.Columns["TenDanhMuc"].FillWeight = 120;
                }

                // Giữ lại bộ lọc tìm kiếm nếu đang có chữ trong ô tìm kiếm
                ApDungTimKiem();
                dgvDanhMuc.ClearSelection();
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi tải danh sách danh mục: " + ex.Message);
            }
        }

        // =====================================================
        // 3. LÀM MỚI CÁC Ô NHẬP
        // =====================================================
        private void LamMoiControls()
        {
            maDanhMucDangChon = -1;

            txtMaDanhMuc.Text = "(tự động)";
            txtTenDanhMuc.Clear();
            txtTimKiem.Clear();

            dgvDanhMuc.ClearSelection();
            txtTenDanhMuc.Focus();
        }

        // =====================================================
        // 4. KIỂM TRA TÊN DANH MỤC (dùng chung cho Thêm / Sửa)
        // =====================================================
        private bool KiemTraTen(out string ten, int boQuaMa)
        {
            ten = txtTenDanhMuc.Text.Trim();

            if (ten.Length == 0)
            {
                HienCanhBao("Vui lòng nhập tên danh mục!");
                txtTenDanhMuc.Focus();
                return false;
            }

            if (TrungTen(ten, boQuaMa))
            {
                HienCanhBao("Tên danh mục \"" + ten + "\" đã tồn tại!");
                txtTenDanhMuc.Focus();
                return false;
            }

            return true;
        }

        // Kiểm tra tên đã có trong danh sách chưa (không phân biệt hoa thường)
        private bool TrungTen(string ten, int boQuaMa)
        {
            DataTable dt = dgvDanhMuc.DataSource as DataTable;
            if (dt == null)
                return false;

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["MaDanhMuc"]) == boQuaMa)
                    continue;

                if (string.Equals(Convert.ToString(row["TenDanhMuc"]).Trim(), ten, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // =====================================================
        // 5. NÚT THÊM
        // =====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten;
            if (!KiemTraTen(out ten, -1))
                return;

            try
            {
                if (DanhMucBUS.Them(ten))
                {
                    HienThongTin("Thêm danh mục thành công!");
                    LoadDanhSach();
                    LamMoiControls();
                }
                else
                {
                    HienCanhBao("Không thêm được danh mục!");
                }
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi khi thêm danh mục: " + ex.Message);
            }
        }

        // =====================================================
        // 6. CLICK VÀO DÒNG TRONG DATAGRIDVIEW
        // =====================================================
        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không xử lý khi click vào tiêu đề
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];

                maDanhMucDangChon = Convert.ToInt32(row.Cells["MaDanhMuc"].Value);
                txtMaDanhMuc.Text = maDanhMucDangChon.ToString();
                txtTenDanhMuc.Text = Convert.ToString(row.Cells["TenDanhMuc"].Value);
            }
            catch (Exception ex)
            {
                HienLoi("Không thể lấy thông tin danh mục: " + ex.Message);
            }
        }

        // =====================================================
        // 7. NÚT SỬA
        // =====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDanhMucDangChon == -1)
            {
                HienCanhBao("Vui lòng chọn danh mục cần sửa!");
                return;
            }

            string ten;
            if (!KiemTraTen(out ten, maDanhMucDangChon))
                return;

            if (!XacNhan("Bạn có chắc muốn sửa danh mục này?"))
                return;

            try
            {
                if (DanhMucBUS.CapNhat(maDanhMucDangChon, ten))
                {
                    HienThongTin("Cập nhật danh mục thành công!");
                    LoadDanhSach();
                    LamMoiControls();
                }
                else
                {
                    HienCanhBao("Không cập nhật được danh mục!");
                }
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi khi sửa danh mục: " + ex.Message);
            }
        }

        // =====================================================
        // 8. NÚT XÓA
        // =====================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDanhMucDangChon == -1)
            {
                HienCanhBao("Vui lòng chọn danh mục cần xóa!");
                return;
            }

            if (!XacNhan("Bạn có chắc muốn xóa danh mục \"" + txtTenDanhMuc.Text.Trim() + "\"?"))
                return;

            try
            {
                if (DanhMucBUS.Xoa(maDanhMucDangChon))
                {
                    HienThongTin("Xóa danh mục thành công!");
                    LoadDanhSach();
                    LamMoiControls();
                }
                else
                {
                    HienCanhBao("Không xóa được danh mục!");
                }
            }
            catch (Exception ex)
            {
                // Thường gặp khi danh mục vẫn còn hoa (ràng buộc khóa ngoại)
                HienLoi("Lỗi khi xóa danh mục (có thể vẫn còn hoa thuộc danh mục này): " + ex.Message);
            }
        }

        // =====================================================
        // 9. NÚT LÀM MỚI
        // =====================================================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
            LamMoiControls();
        }

        // =====================================================
        // 10. NÚT TRỞ VỀ TRANG CHỦ
        // =====================================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =====================================================
        // 11. TÌM KIẾM (lọc theo tên danh mục)
        // =====================================================
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApDungTimKiem();
        }

        private void ApDungTimKiem()
        {
            DataTable dt = dgvDanhMuc.DataSource as DataTable;
            if (dt == null)
                return;

            string tuKhoa = txtTimKiem.Text.Trim()
                .Replace("[", "[[]")
                .Replace("*", "[*]")
                .Replace("%", "[%]")
                .Replace("'", "''");

            dt.DefaultView.RowFilter = tuKhoa.Length == 0
                ? string.Empty
                : string.Format("TenDanhMuc LIKE '%{0}%'", tuKhoa);
        }

        // =====================================================
        // 12. HÀM HỖ TRỢ HIỂN THỊ THÔNG BÁO
        // =====================================================
        private void HienThongTin(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HienCanhBao(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HienLoi(string noiDung)
        {
            MessageBox.Show(noiDung, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool XacNhan(string noiDung)
        {
            return MessageBox.Show(noiDung, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}