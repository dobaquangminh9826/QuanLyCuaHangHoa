using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.GUI
{
    public partial class frmQuanLyHoa : Form
    {
        // Mã hoa đang được chọn
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
                DataTable dt = DanhMucBUS.LayDanhSachDanhMuc();
                cboDanhMuc.DataSource = dt;
                cboDanhMuc.DisplayMember = "TenDanhMuc";
                cboDanhMuc.ValueMember = "MaDanhMuc";

                LoadDanhSachHoa();
                LamMoiControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

                // Đổi tên tiêu đề các cột
                if (dgvHoa.Columns["MaHoa"] != null)
                {
                    dgvHoa.Columns["MaHoa"].HeaderText = "Mã hoa";
                }

                if (dgvHoa.Columns["TenHoa"] != null)
                {
                    dgvHoa.Columns["TenHoa"].HeaderText = "Tên hoa";
                }

                if (dgvHoa.Columns["TenDanhMuc"] != null)
                {
                    dgvHoa.Columns["TenDanhMuc"].HeaderText = "Danh mục";
                }

                if (dgvHoa.Columns["GiaBan"] != null)
                {
                    dgvHoa.Columns["GiaBan"].HeaderText = "Giá bán";
                }

                if (dgvHoa.Columns["SoLuongTon"] != null)
                {
                    dgvHoa.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách hoa: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 3. LÀM MỚI CÁC Ô NHẬP
        // =====================================================
        private void LamMoiControls()
        {
            txtTenHoa.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();

            maHoaDangChon = -1;

            if (cboDanhMuc.Items.Count > 0)
            {
                cboDanhMuc.SelectedIndex = 0;
            }

            txtTenHoa.Focus();
        }

        // =====================================================
        // 4. NÚT THÊM
        // =====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtTenHoa.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin hoa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                string ten = txtTenHoa.Text.Trim();

                int maDM =
                    Convert.ToInt32(cboDanhMuc.SelectedValue);

                decimal gia =
                    Convert.ToDecimal(txtGiaBan.Text.Trim());

                int soLuong =
                    Convert.ToInt32(txtSoLuong.Text.Trim());

                // Kiểm tra giá
                if (gia < 0)
                {
                    MessageBox.Show(
                        "Giá bán không được âm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Kiểm tra số lượng
                if (soLuong < 0)
                {
                    MessageBox.Show(
                        "Số lượng không được âm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Gọi BUS để thêm
                if (FlowerBUS.Them(
                    ten,
                    maDM,
                    gia,
                    soLuong))
                {
                    MessageBox.Show(
                        "Thêm sản phẩm hoa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Load lại danh sách
                    LoadDanhSachHoa();

                    // Xóa trắng ô nhập
                    LamMoiControls();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Giá bán và số lượng phải nhập bằng số!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm hoa: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 5. CLICK VÀO DÒNG TRONG DATAGRIDVIEW
        // =====================================================
        private void dgvHoa_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                // Không xử lý khi click vào tiêu đề
                if (e.RowIndex < 0)
                {
                    return;
                }

                DataGridViewRow row =
                    dgvHoa.Rows[e.RowIndex];

                // Lấy mã hoa
                maHoaDangChon =
                    Convert.ToInt32(
                        row.Cells["MaHoa"].Value);

                // Lấy tên hoa
                txtTenHoa.Text =
                    row.Cells["TenHoa"].Value.ToString();

                // Lấy giá bán
                txtGiaBan.Text =
                    row.Cells["GiaBan"].Value.ToString();

                // Lấy số lượng tồn
                txtSoLuong.Text =
                    row.Cells["SoLuongTon"].Value.ToString();

                // Chọn danh mục
                cboDanhMuc.Text =
                    row.Cells["TenDanhMuc"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể lấy thông tin hoa: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 6. NÚT SỬA
        // =====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maHoaDangChon == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn hoa cần sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenHoa.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ten = txtTenHoa.Text.Trim();
                int maDM = Convert.ToInt32(cboDanhMuc.SelectedValue);
                decimal gia = Convert.ToDecimal(txtGiaBan.Text.Trim());
                int soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());

                if (gia < 0 || soLuong < 0)
                {
                    MessageBox.Show(
                        "Giá bán và số lượng không được âm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn sửa sản phẩm này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                bool ketQua = FlowerBUS.CapNhat(
                    maHoaDangChon,
                    ten,
                    maDM,
                    gia,
                    soLuong);

                if (ketQua)
                {
                    MessageBox.Show(
                        "Cập nhật sản phẩm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDanhSachHoa();
                    LamMoiControls();
                }
                else
                {
                    MessageBox.Show(
                        "Không cập nhật được sản phẩm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Giá bán và số lượng phải nhập bằng số!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi sửa hoa: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // 7. NÚT XÓA
        // =====================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        // =====================================================
        // 8. NÚT LÀM MỚI
        // =====================================================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoa();
            LamMoiControls();
        }

        // =====================================================
        // 9. CÁC EVENT CŨ CỦA DESIGNER
        // =====================================================

        private void groupBox1_Enter(
            object sender,
            EventArgs e)
        {
        }

        private void textBox3_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void dgvHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}