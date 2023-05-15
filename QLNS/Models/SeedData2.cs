using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLNS.Data;
using System;
using System.Linq;
namespace QLNS.Models;
public static class SeedData2
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new QLNSContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<QLNSContext>>()))
        {
            if (context.HopDongLaoDong.Any())
            {
                return;   // DB has been seeded
            }
            context.HopDongLaoDong.AddRange(
                new HopDongLaoDong
                {
                    MaHDLD = "HDT1",
                    MaNV = "NV0001",
                    LoaiHDLD = "Hợp đồng thời vụ",
                    ThoiHan = 3,
                    DiaDiemLamViec = "Chi nhánh 1",
                    MaLuong = "LB1",
                    PhuCap = 1000000,
                    ChucVu = "CV1"
                },
            new HopDongLaoDong
            {
                MaHDLD = "HDT2",
                MaNV = "NV0002",
                LoaiHDLD = "Hợp đồng thử việc",
                ThoiHan = 2,
                DiaDiemLamViec = "Chi nhánh 2",
                MaLuong = "LB2",
                PhuCap = 1200000,
                ChucVu = "CV2"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT3",
                MaNV = "NV0003",
                LoaiHDLD = "Hợp đồng hợp tác",
                ThoiHan = 8,
                DiaDiemLamViec = "Chi nhánh 2",
                MaLuong = "LB4",
                PhuCap = 1900000,
                ChucVu = "CV4"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT4",
                MaNV = "NV0004",
                LoaiHDLD = "Hợp đồng xác định thời hạn",
                ThoiHan = 12,
                DiaDiemLamViec = "Chi nhánh 3",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV2"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT5",
                MaNV = "NV0005",
                LoaiHDLD = "Hợp đồng xác định thời hạn",
                ThoiHan = 12,
                DiaDiemLamViec = "Chi nhánh 2",
                MaLuong = "LB3",
                PhuCap = 1700000,
                ChucVu = "CV3"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT6",
                MaNV = "NV0006",
                LoaiHDLD = "Hợp đồng học việc",
                ThoiHan = 6,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB1",
                PhuCap = 1200000,
                ChucVu = "CV1"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT7",
                MaNV = "NV0007",
                LoaiHDLD = "Hợp đồng thử việc",
                ThoiHan = 2,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB1",
                PhuCap = 1000000,
                ChucVu = "CV1"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT8",
                MaNV = "NV0008",
                LoaiHDLD = "Hợp đồng thời vụ",
                ThoiHan = 3,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV2"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT9",
                MaNV = "NV0009",
                LoaiHDLD = "Hợp đồng thời vụ",
                ThoiHan = 3,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV3"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT10",
                MaNV = "NV0010",
                LoaiHDLD = "Hợp đồng thời vụ",
                ThoiHan = 3,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV1"
            }
            );

            // Thêm dữ liệu cho bảng ChamCong
            context.SaveChanges();
        }
    }
}