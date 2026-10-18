using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BUS
{
    public class DanhMucBUS
    {
        // 1. Lấy danh sách danh mục
        public static DataTable LayDanhSachDanhMuc()
        {
            string sql = "SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc ORDER BY MaDanhMuc";
            return Database.GetData(sql);
        }

        // 2. Thêm danh mục mới
        public static bool Them(string tenDanhMuc)
        {
            string sql = "INSERT INTO DanhMuc (TenDanhMuc) VALUES (@tenDanhMuc)";
            SqlParameter[] p =
            {
                new SqlParameter("@tenDanhMuc", tenDanhMuc)
            };
            return Database.ExecuteNonQuery(sql, p);
        }

        // 3. Cập nhật danh mục
        public static bool CapNhat(int maDanhMuc, string tenDanhMuc)
        {
            string sql = "UPDATE DanhMuc SET TenDanhMuc = @tenDanhMuc WHERE MaDanhMuc = @maDanhMuc";
            SqlParameter[] p =
            {
                new SqlParameter("@tenDanhMuc", tenDanhMuc),
                new SqlParameter("@maDanhMuc", maDanhMuc)
            };
            return Database.ExecuteNonQuery(sql, p);
        }

        // 4. Xóa danh mục
        public static bool Xoa(int maDanhMuc)
        {
            string sql = "DELETE FROM DanhMuc WHERE MaDanhMuc = @maDanhMuc";
            SqlParameter[] p =
            {
                new SqlParameter("@maDanhMuc", maDanhMuc)
            };
            return Database.ExecuteNonQuery(sql, p);
        }
    }
}