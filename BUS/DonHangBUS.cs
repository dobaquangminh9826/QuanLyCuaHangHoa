using System;
using System.Collections.Generic;
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

    // Nơi lưu và truy vấn đơn hàng (hiện lưu trong bộ nhớ, sau này thay bằng database)
    public static class DonHangBUS
    {
        public const string DA_HUY = "Đã hủy";

        private static readonly List<DonHangDTO> dsDonHang = new List<DonHangDTO>();
        private static readonly object khoa = new object();

        public static string TaoMaDon()
        {
            lock (khoa) { return "DH" + (dsDonHang.Count + 1).ToString("000"); }
        }

        // Form Quản lý bán hàng gọi hàm này khi bán xong một đơn
        public static void ThemDonHang(DonHangDTO donHang)
        {
            if (donHang == null) throw new ArgumentNullException("donHang");
            lock (khoa) { dsDonHang.Add(donHang); }
        }

        public static List<DonHangDTO> LayTatCa()
        {
            lock (khoa) { return dsDonHang.OrderByDescending(d => d.NgayDat).ToList(); }
        }

        public static List<DonHangDTO> LayDonHangGanDay(int soLuong)
        {
            return LayTatCa().Take(soLuong).ToList();
        }

        // Hoa bán chạy: cộng số lượng theo tên hoa, bỏ qua đơn đã hủy
        public static List<HoaBanChayDTO> LayHoaBanChay(int soLuong)
        {
            lock (khoa)
            {
                return dsDonHang
                    .Where(d => d.TrangThai != DA_HUY)
                    .SelectMany(d => d.ChiTiet)
                    .GroupBy(c => c.TenHoa)
                    .Select(g => new HoaBanChayDTO { TenHoa = g.Key, DaBan = g.Sum(c => c.SoLuong) })
                    .OrderByDescending(h => h.DaBan)
                    .Take(soLuong)
                    .ToList();
            }
        }

        public static int DemDonHomNay()
        {
            lock (khoa) { return dsDonHang.Count(d => d.NgayDat.Date == DateTime.Today); }
        }

        public static decimal DoanhThuHomNay()
        {
            lock (khoa)
            {
                return dsDonHang
                    .Where(d => d.NgayDat.Date == DateTime.Today && d.TrangThai != DA_HUY)
                    .Sum(d => d.TongTien);
            }
        }
    }
}