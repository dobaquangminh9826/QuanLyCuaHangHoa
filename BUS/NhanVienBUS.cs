using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BUS
{
    public class NhanVienBUS
    {
        public static int DemSoNhanVien()
        {
            DataTable dt = Database.GetData("SELECT COUNT(*) FROM NhanVien WHERE TrangThai = N'Đang làm việc'");
            if (dt == null || dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
                return 0;
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public static DataTable DangNhap(string taiKhoan, string matKhau)
        {
            string query = "SELECT * FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk AND TrangThai = N'Đang làm việc'";
            SqlParameter[] parameters = {
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhau)
            };
            return Database.GetData(query, parameters);
        }

        // Lấy danh sách nhân viên đang làm việc (phục vụ form quản lý nhân viên)
        public static DataTable LayDanhSachNhanVien()
        {
            string query = "SELECT MaNV, HoTen, SoDienThoai, TaiKhoan, ChucVu, GioiTinh FROM NhanVien WHERE TrangThai = N'Đang làm việc'";
            return Database.GetData(query);
        }

        // Thêm nhân viên mới
        public static bool ThemNhanVien(string hoTen, string sdt, string taiKhoan, string matKhau, string chucVu, string gioiTinh)
        {
            string query = "INSERT INTO NhanVien (HoTen, SoDienThoai, TaiKhoan, MatKhau, ChucVu, GioiTinh, TrangThai) VALUES (@hoTen, @sdt, @tk, @mk, @chucVu, @gioiTinh, N'Đang làm việc')";
            SqlParameter[] parameters = {
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@sdt", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt),
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", string.IsNullOrEmpty(matKhau) ? "123456" : matKhau),
                new SqlParameter("@chucVu", (object)chucVu ?? DBNull.Value),
                new SqlParameter("@gioiTinh", gioiTinh)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        // Cập nhật thông tin nhân viên
        public static bool SuaNhanVien(int maNV, string hoTen, string sdt, string taiKhoan, string chucVu, string gioiTinh)
        {
            string query = "UPDATE NhanVien SET HoTen = @hoTen, SoDienThoai = @sdt, TaiKhoan = @taiKhoan, ChucVu = @chucVu, GioiTinh = @gioiTinh WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@sdt", string.IsNullOrEmpty(sdt) ? (object)DBNull.Value : sdt),
                new SqlParameter("@taiKhoan", taiKhoan),
                new SqlParameter("@chucVu", (object)chucVu ?? DBNull.Value),
                new SqlParameter("@gioiTinh", gioiTinh)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        // Xóa mềm nhân viên (chuyển trạng thái thành Đã nghỉ việc)
        public static bool XoaNhanVien(int maNV)
        {
            string query = "UPDATE NhanVien SET TrangThai = N'Đã nghỉ việc' WHERE MaNV = @maNV";
            SqlParameter[] parameters = {
                new SqlParameter("@maNV", maNV)
            };
            return Database.ExecuteNonQuery(query, parameters);
        }

        public static bool KiemTraTonTaiTaiKhoan(string taiKhoan)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @tk";
            SqlParameter[] parameters = { new SqlParameter("@tk", taiKhoan) };
            DataTable dt = Database.GetData(query, parameters);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
    }
}