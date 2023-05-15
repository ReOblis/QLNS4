using QLNS.Models;

namespace QLNS.ViewModels
{
    public class NhanVienDetailViewModel
    {
        public NhanVien NhanVien { get; set; }
        public PhongBan PhongBan { get; set; }
        public ChucVu ChucVu { get; set; }
        public String TenQuyUocMaChucVu { get; set; }
        public int Sogio { get; set; }
        public HopDongLaoDong HopDongLaoDong { get; set; }
    }
}
