using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.GUI
{
    public partial class frmQuanLyHoa : Form
    {
        // Mã hoa đang được chọn (-1 = chưa chọn)
        private int maHoaDangChon = -1;

        public frmQuanLyHoa()
        {
            InitializeComponent();
        }

        // =====================================================
        // 1. KHI MỞ FORM
        // =====================================================
        private void frmQuanLyHoa_Load(object sender, EventArgs e)
        {
            try
            {
                cboDanhMuc.DataSource = DanhMucBUS.LayDanhSachDanhMuc();
                cboDanhMuc.DisplayMember = "TenDanhMuc";
                cboDanhMuc.ValueMember = "MaDanhMuc";

                LoadDanhSachHoa();
                LamMoiControls();
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi: " + ex.Message);
            }
        }

        // =====================================================
        // 2. LOAD DANH SÁCH HOA
        // =====================================================
        private void LoadDanhSachHoa()
        {
            try
            {
                dgvHoa.DataSource = FlowerBUS.LayHoa();

                DatTieuDe("MaHoa", "Mã hoa");
                DatTieuDe("TenHoa", "Tên hoa");
                DatTieuDe("TenDanhMuc", "Danh mục");
                DatTieuDe("GiaBan", "Giá bán (đ)");
                DatTieuDe("SoLuongTon", "Số lượng tồn");

                if (dgvHoa.Columns["MaHoa"] != null)
                    dgvHoa.Columns["MaHoa"].FillWeight = 40;

                if (dgvHoa.Columns["TenHoa"] != null)
                    dgvHoa.Columns["TenHoa"].FillWeight = 130;

                if (dgvHoa.Columns["GiaBan"] != null)
                {
                    dgvHoa.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
                    dgvHoa.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvHoa.Columns["GiaBan"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgvHoa.Columns["SoLuongTon"] != null)
                {
                    dgvHoa.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvHoa.Columns["SoLuongTon"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Giữ lại bộ lọc tìm kiếm nếu đang có chữ trong ô tìm kiếm
                ApDungTimKiem();
                dgvHoa.ClearSelection();
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi tải danh sách hoa: " + ex.Message);
            }
        }

        private void DatTieuDe(string tenCot, string tieuDe)
        {
            if (dgvHoa.Columns[tenCot] != null)
                dgvHoa.Columns[tenCot].HeaderText = tieuDe;
        }

        // =====================================================
        // 3. LÀM MỚI CÁC Ô NHẬP
        // =====================================================
        private void LamMoiControls()
        {
            txtTenHoa.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtTimKiem.Clear();

            maHoaDangChon = -1;

            if (cboDanhMuc.Items.Count > 0)
                cboDanhMuc.SelectedIndex = 0;

            dgvHoa.ClearSelection();
            txtTenHoa.Focus();
        }

        // =====================================================
        // 4. ĐỌC VÀ KIỂM TRA DỮ LIỆU NHẬP (dùng chung cho Thêm / Sửa)
        // =====================================================
        private bool DocDuLieuNhap(out string ten, out int maDM, out decimal gia, out int soLuong)
        {
            ten = txtTenHoa.Text.Trim();
            maDM = 0;
            gia = 0;
            soLuong = 0;

            if (ten.Length == 0 ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                HienCanhBao("Vui lòng nhập đầy đủ thông tin hoa!");
                return false;
            }

            if (cboDanhMuc.SelectedValue == null)
            {
                HienCanhBao("Vui lòng chọn danh mục!");
                return false;
            }
            maDM = Convert.ToInt32(cboDanhMuc.SelectedValue);

            if (!decimal.TryParse(txtGiaBan.Text.Trim(), out gia))
            {
                HienCanhBao("Giá bán phải nhập bằng số!");
                return false;
            }
            if (gia < 0)
            {
                HienCanhBao("Giá bán không được âm!");
                return false;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuong))
            {
                HienCanhBao("Số lượng phải nhập bằng số nguyên!");
                return false;
            }
            if (soLuong < 0)
            {
                HienCanhBao("Số lượng không được âm!");
                return false;
            }

            return true;
        }

        // =====================================================
        // 5. NÚT THÊM
        // =====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten;
            int maDM;
            decimal gia;
            int soLuong;

            if (!DocDuLieuNhap(out ten, out maDM, out gia, out soLuong))
                return;

            try
            {
                if (FlowerBUS.Them(ten, maDM, gia, soLuong))
                {
                    HienThongTin("Thêm sản phẩm hoa thành công!");
                    LoadDanhSachHoa();
                    LamMoiControls();
                }
                else
                {
                    HienCanhBao("Không thêm được sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi khi thêm hoa: " + ex.Message);
            }
        }

        // =====================================================
        // 6. CLICK VÀO DÒNG TRONG DATAGRIDVIEW
        // =====================================================
        private void dgvHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không xử lý khi click vào tiêu đề
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dgvHoa.Rows[e.RowIndex];

                maHoaDangChon = Convert.ToInt32(row.Cells["MaHoa"].Value);
                txtTenHoa.Text = Convert.ToString(row.Cells["TenHoa"].Value);

                // Giá hiển thị dạng số nguyên (tránh lỗi dấu . , theo vùng miền)
                txtGiaBan.Text = Convert.ToDecimal(row.Cells["GiaBan"].Value).ToString("0");
                txtSoLuong.Text = Convert.ToString(row.Cells["SoLuongTon"].Value);

                int viTri = cboDanhMuc.FindStringExact(Convert.ToString(row.Cells["TenDanhMuc"].Value));
                if (viTri >= 0)
                    cboDanhMuc.SelectedIndex = viTri;
            }
            catch (Exception ex)
            {
                HienLoi("Không thể lấy thông tin hoa: " + ex.Message);
            }
        }

        // =====================================================
        // 7. NÚT SỬA
        // =====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maHoaDangChon == -1)
            {
                HienCanhBao("Vui lòng chọn hoa cần sửa!");
                return;
            }

            string ten;
            int maDM;
            decimal gia;
            int soLuong;

            if (!DocDuLieuNhap(out ten, out maDM, out gia, out soLuong))
                return;

            if (!XacNhan("Bạn có chắc muốn sửa sản phẩm này?"))
                return;

            try
            {
                if (FlowerBUS.CapNhat(maHoaDangChon, ten, maDM, gia, soLuong))
                {
                    HienThongTin("Cập nhật sản phẩm thành công!");
                    LoadDanhSachHoa();
                    LamMoiControls();
                }
                else
                {
                    HienCanhBao("Không cập nhật được sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                HienLoi("Lỗi khi sửa hoa: " + ex.Message);
            }
        }

        // =====================================================
        // 8. NÚT XÓA
        // (cần có FlowerBUS.Xoa(int maHoa) trả về bool)
        // =====================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maHoaDangChon == -1)
            {
                HienCanhBao("Vui lòng chọn hoa cần xóa!");
                return;
            }

            if (!XacNhan("Bạn có chắc muốn xóa sản phẩm \"" + txtTenHoa.Text.Trim() + "\"?"))
                return;

            try
            {
                if (FlowerBUS.Xoa(maHoaDangChon))
                {
                    HienThongTin("Xóa sản phẩm thành công!");
                    LoadDanhSachHoa();
                    LamMoiControls();
                }
                else
                {
                    HienCanhBao("Không xóa được sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                // Thường gặp khi hoa đã nằm trong đơn hàng (ràng buộc khóa ngoại)
                HienLoi("Lỗi khi xóa hoa (có thể sản phẩm đã có trong đơn hàng): " + ex.Message);
            }
        }

        // =====================================================
        // 9. NÚT LÀM MỚI
        // =====================================================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoa();
            LamMoiControls();
        }

        // =====================================================
        // 10. TÌM KIẾM (lọc theo tên hoa hoặc danh mục)
        // =====================================================
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApDungTimKiem();
        }

        private void ApDungTimKiem()
        {
            DataTable dt = dgvHoa.DataSource as DataTable;
            if (dt == null)
                return;

            string tuKhoa = txtTimKiem.Text.Trim()
                .Replace("[", "[[]")
                .Replace("*", "[*]")
                .Replace("%", "[%]")
                .Replace("'", "''");

            dt.DefaultView.RowFilter = tuKhoa.Length == 0
                ? string.Empty
                : string.Format("TenHoa LIKE '%{0}%' OR TenDanhMuc LIKE '%{0}%'", tuKhoa);
        }

        // =====================================================
        // 11. CHỈ CHO NHẬP SỐ Ở Ô GIÁ BÁN VÀ SỐ LƯỢNG
        // =====================================================
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // =====================================================
        // 12. NÚT TRỞ VỀ TRANG CHỦ (đóng form này, quay lại frmMain)
        // =====================================================
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =====================================================
        // 13. HÀM HỖ TRỢ HIỂN THỊ THÔNG BÁO
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