using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace WindowsFormsApp1.BUS
{
    public class ChiTietDonHangDTO
    {
        public string TenHoa { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get { return SoLuong * DonGia; } }
    }

    public class DonHangDTO
    {
        public string MaDon { get; set; }
        public string KhachHang { get; set; }
        public DateTime NgayDat { get; set; }
        public string TrangThai { get; set; }   // Hoàn thành / Đang giao / Chờ xác nhận / Đã hủy
        public List<ChiTietDonHangDTO> ChiTiet { get; set; } = new List<ChiTietDonHangDTO>();
        public decimal TongTien { get { return ChiTiet.Sum(c => c.ThanhTien); } }
    }

    public class HoaBanChayDTO
    {
        public string TenHoa { get; set; }
        public int DaBan { get; set; }
    }

    public static class DonHangBUS
    {
        public const string DA_HUY = "Đã hủy";

        // Chuỗi kết nối SQL Server (đồng bộ với form bán hàng của bạn)
        private static string connectionString = @"Data Source=n3wgate;Initial Catalog=QuanLyCuaHangHoa;Integrated Security=True";

        public static string TaoMaDon()
        {
            // Có thể tự sinh mã hoặc để SQL tự tăng, ở đây tạm trả về định dạng chuẩn
            return "DH" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public static List<DonHangDTO> LayTatCa()
        {
            List<DonHangDTO> danhSach = new List<DonHangDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Lấy danh sách hóa đơn từ CSDL
                string queryHD = "SELECT MaHD, TenKhach, NgayLap, TongTien FROM HoaDon ORDER BY NgayLap DESC";
                using (SqlCommand cmd = new SqlCommand(queryHD, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DonHangDTO dh = new DonHangDTO
                            {
                                MaDon = "DH" + reader["MaHD"].ToString(),
                                KhachHang = reader["TenKhach"] != DBNull.Value ? reader["TenKhach"].ToString() : "Khách lẻ",
                                NgayDat = Convert.ToDateTime(reader["NgayLap"]),
                                TrangThai = "Hoàn thành" // Mặc định đơn thành công
                            };
                            danhSach.Add(dh);
                        }
                    }
                }

                // Lấy chi tiết cho từng đơn hàng
                foreach (var dh in danhSach)
                {
                    int maHD = int.Parse(dh.MaDon.Replace("DH", ""));
                    string queryCT = @"SELECT h.TenHoa, c.SoLuong, c.DonGia 
                                       FROM ChiTietHoaDon c 
                                       JOIN Hoa h ON c.MaHoa = h.MaHoa 
                                       WHERE c.MaHD = @MaHD";
                    using (SqlCommand cmdCT = new SqlCommand(queryCT, conn))
                    {
                        cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                        using (SqlDataReader readerCT = cmdCT.ExecuteReader())
                        {
                            while (readerCT.Read())
                            {
                                dh.ChiTiet.Add(new ChiTietDonHangDTO
                                {
                                    TenHoa = readerCT["TenHoa"].ToString(),
                                    SoLuong = Convert.ToInt32(readerCT["SoLuong"]),
                                    DonGia = Convert.ToDecimal(readerCT["DonGia"])
                                });
                            }
                        }
                    }
                }
            }
            return danhSach;
        }

        public static List<DonHangDTO> LayDonHangGanDay(int soLuong)
        {
            return LayTatCa().Take(soLuong).ToList();
        }

        // Lấy danh sách hoa bán chạy trực tiếp từ SQL
        public static List<HoaBanChayDTO> LayHoaBanChay(int soLuong)
        {
            List<HoaBanChayDTO> list = new List<HoaBanChayDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $@"TOP ({soLuong}) h.TenHoa, SUM(c.SoLuong) AS DaBan
                                  FROM ChiTietHoaDon c
                                  JOIN Hoa h ON c.MaHoa = h.MaHoa
                                  GROUP BY h.TenHoa
                                  ORDER BY DaBan DESC";
                // Lưu ý: Nếu phiên bản SQL Server cũ, sửa "SELECT TOP (n)" thành "SELECT TOP n"
                string safeQuery = $@"SELECT TOP {soLuong} h.TenHoa, SUM(c.SoLuong) AS DaBan 
                                      FROM ChiTietHoaDon c 
                                      JOIN Hoa h ON c.MaHoa = h.MaHoa 
                                      GROUP BY h.TenHoa 
                                      ORDER BY DaBan DESC";

                using (SqlCommand cmd = new SqlCommand(safeQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new HoaBanChayDTO
                            {
                                TenHoa = reader["TenHoa"].ToString(),
                                DaBan = Convert.ToInt32(reader["DaBan"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        // Đếm số đơn hàng trong ngày hôm nay từ SQL
        public static int DemDonHomNay()
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return count;
        }

        // Tính tổng doanh thu hôm nay từ SQL
        public static decimal DoanhThuHomNay()
        {
            decimal total = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    total = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
            return total;
        }
    }
}