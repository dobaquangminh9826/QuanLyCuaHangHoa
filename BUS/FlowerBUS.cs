using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BUS
{
    public class FlowerBUS
    {
        // Lấy toàn bộ danh sách hoa
        public static DataTable LayHoa()
        {
            string sql = @"
                SELECT 
                    h.MaHoa,
                    h.TenHoa,
                    d.TenDanhMuc,
                    h.GiaBan,
                    h.SoLuongTon
                FROM Hoa h
                INNER JOIN DanhMuc d 
                    ON h.MaDanhMuc = d.MaDanhMuc";

            return Database.GetData(sql);
        }

        // Thêm hoa
        public static bool Them(string ten, int maDM, decimal gia, int soLuong)
        {
            string sql = @"
                INSERT INTO Hoa 
                (TenHoa, MaDanhMuc, GiaBan, SoLuongTon)
                VALUES 
                (@ten, @maDM, @gia, @sl)";

            SqlParameter[] p =
            {
                new SqlParameter("@ten", ten),
                new SqlParameter("@maDM", maDM),
                new SqlParameter("@gia", gia),
                new SqlParameter("@sl", soLuong)
            };

            return Database.ExecuteNonQuery(sql, p);
        }

        // Sửa hoa
        public static bool CapNhat(
            int maHoa,
            string ten,
            int maDM,
            decimal gia,
            int soLuong)
        {
            string sql = @"
                UPDATE Hoa
                SET 
                    TenHoa = @ten,
                    MaDanhMuc = @maDM,
                    GiaBan = @gia,
                    SoLuongTon = @sl
                WHERE MaHoa = @maHoa";

            SqlParameter[] p =
            {
                new SqlParameter("@maHoa", maHoa),
                new SqlParameter("@ten", ten),
                new SqlParameter("@maDM", maDM),
                new SqlParameter("@gia", gia),
                new SqlParameter("@sl", soLuong)
            };

            return Database.ExecuteNonQuery(sql, p);
        }

        // Xóa hoa
        public static bool Xoa(int maHoa)
        {
            string sql = "DELETE FROM Hoa WHERE MaHoa = @maHoa";

            SqlParameter[] p =
            {
                new SqlParameter("@maHoa", maHoa)
            };

            return Database.ExecuteNonQuery(sql, p);
        }

        // Tìm kiếm hoa
        public static DataTable TimKiem(string tenHoa)
        {
            string sql = @"
                SELECT 
                    h.MaHoa,
                    h.TenHoa,
                    d.TenDanhMuc,
                    h.GiaBan,
                    h.SoLuongTon
                FROM Hoa h
                INNER JOIN DanhMuc d 
                    ON h.MaDanhMuc = d.MaDanhMuc
                WHERE h.TenHoa LIKE @ten";

            SqlParameter[] p =
            {
                new SqlParameter("@ten", "%" + tenHoa + "%")
            };

            return Database.GetData(sql, p);
        }
    }
}