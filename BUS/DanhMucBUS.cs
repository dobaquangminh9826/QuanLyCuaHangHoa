using System.Data;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BUS
{
    public class DanhMucBUS
    {
        public static DataTable LayDanhSachDanhMuc()
        {
            string sql = "SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc";
            return Database.GetData(sql);
        }
    }
}