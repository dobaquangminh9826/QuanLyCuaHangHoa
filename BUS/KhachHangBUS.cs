using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BUS
{
    public class KhachHangBUS
    {
        // 1. Lấy danh sách khách hàng
        public static DataTable LayDanhSachKhachHang()
        {
            string query = "SELECT * FROM KhachHang";
            return Database.GetData(query);
        }

        // 2. Thêm khách hàng mới
        public static bool ThemKhachHang(string hoTen, string sdt)
        {
            string query = "INSERT INTO KhachHang (HoTen, SoDienThoai) VALUES (@hoTen, @sdt)";
            SqlParameter[] p = {
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@sdt", sdt)
            };
            return Database.ExecuteNonQuery(query, p);
        }

        // 3. Tìm kiếm khách hàng theo số điện thoại
        public static DataTable TimKhachHangTheoSDT(string sdt)
        {
            string query = "SELECT * FROM KhachHang WHERE SoDienThoai = @sdt";
            SqlParameter[] p = {
                new SqlParameter("@sdt", sdt)
            };
            return Database.GetData(query, p);
        }
    }
}