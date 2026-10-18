using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DAL; // Kết nối tới lớp DAL chứa Database.cs

namespace WindowsFormsApp1.BUS
{
    // Từ khóa 'public' giúp Form đăng nhập và các Form GUI khác truy cập được
    public class NhanVienBUS
    {
        // Đếm tổng số nhân viên (tính cả quản lý). Không có ai thì trả về 0
        public static int DemSoNhanVien()
        {
            DataTable dt = Database.GetData("SELECT COUNT(*) FROM NhanVien");

            if (dt == null || dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
                return 0;

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        // 1. Kiểm tra thông tin tài khoản & mật khẩu khi Đăng nhập
        public static DataTable DangNhap(string taiKhoan, string matKhau)
        {
            string query = "SELECT * FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";
            SqlParameter[] parameters = {
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhau)
            };
            return Database.GetData(query, parameters);
        }

        // 2. Lấy danh sách tất cả nhân viên (dùng cho màn hình Quản lý nhân viên)
        public static DataTable LayDanhSachNhanVien()
        {
            string query = "SELECT MaNV, HoTen, SoDienThoai, TaiKhoan, ChucVu FROM NhanVien";
            return Database.GetData(query);
        }

        // 3. Thêm tài khoản nhân viên mới
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

        // 4. Cập nhật thông tin nhân viên
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

        // 5. Xóa tài khoản nhân viên
        public static bool XoaNhanVien(int maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
                new SqlParameter("@maNV", maNV)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        // 6. Đổi mật khẩu theo mã nhân viên
        public static bool DoiMatKhau(int maNV, string matKhauMoi)
        {
            string query = "UPDATE NhanVien SET MatKhau = @mk WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@mk", matKhauMoi)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        // 7. Kiểm tra mật khẩu hiện tại theo tài khoản (dùng cho form Đổi mật khẩu)
        public static bool KiemTraMatKhau(string taiKhoan, string matKhau)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";
            SqlParameter[] parameters = {
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhau)
            };
            DataTable dt = Database.GetData(query, parameters);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        // 8. Đổi mật khẩu theo tài khoản (dùng cho form Đổi mật khẩu)
        public static bool DoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            string query = "UPDATE NhanVien SET MatKhau = @mk WHERE TaiKhoan = @tk";
            SqlParameter[] parameters = {
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhauMoi)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }
    }
}