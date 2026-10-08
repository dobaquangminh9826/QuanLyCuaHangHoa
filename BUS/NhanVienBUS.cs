using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DAL; // Kết nối tới lớp DAL chứa Database.cs

namespace WindowsFormsApp1.BUS
{
    // Từ khóa 'public' giúp Form đăng nhập và các Form GUI khác truy cập được
    public class NhanVienBUS
    {
        // 1. Kiểm tra thông tin tài khoản & mật khẩu khi Đăng nhập[cite: 1]
        public static DataTable DangNhap(string taiKhoan, string matKhau)
        {
            string query = "SELECT * FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";
            SqlParameter[] parameters = {
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhau)
            };
            return Database.GetData(query, parameters);
        }

        // 2. Lấy danh sách tất cả nhân viên (dùng cho màn hình Quản lý nhân viên)[cite: 1]
        public static DataTable LayDanhSachNhanVien()
        {
            string query = "SELECT MaNV, HoTen, SoDienThoai, TaiKhoan, ChucVu FROM NhanVien";
            return Database.GetData(query);
        }

        // 3. Thêm tài khoản nhân viên mới[cite: 1]
        public static bool ThemNhanVien(string hoTen, string sdt, string taiKhoan, string matKhau, string chucVu)
        {
            string query = "INSERT INTO NhanVien (HoTen, SoDienThoai, TaiKhoan, MatKhau, ChucVu) VALUES (@hoTen, @sdt, @tk, @mk, @chucVu)";
            SqlParameter[] parameters = {
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhau),
                new SqlParameter("@chucVu", chucVu)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        // 4. Cập nhật thông tin nhân viên[cite: 1]
        public static bool SuaNhanVien(int maNV, string hoTen, string sdt, string chucVu)
        {
            string query = "UPDATE NhanVien SET HoTen = @hoTen, SoDienThoai = @sdt, ChucVu = @chucVu WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@chucVu", chucVu)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        // 5. Xóa tài khoản nhân viên[cite: 1]
        public static bool XoaNhanVien(int maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
                new SqlParameter("@maNV", maNV)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        // 6. Đổi mật khẩu tài khoản
        public static bool DoiMatKhau(int maNV, string matKhauMoi)
        {
            string query = "UPDATE NhanVien SET MatKhau = @mk WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@mk", matKhauMoi)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }
    }
}