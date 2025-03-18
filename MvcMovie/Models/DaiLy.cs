using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class DaiLy
    {
        [Key]
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }
        public string MaHTPP { get; set; } // Liên kết với HeThongPhanPhoi

        public DaiLy(string maDaiLy, string tenDaiLy, string diaChi, string nguoiDaiDien, string dienThoai, string maHTPP)
        {
            MaDaiLy = maDaiLy;
            TenDaiLy = tenDaiLy;
            DiaChi = diaChi;
            NguoiDaiDien = nguoiDaiDien;
            DienThoai = dienThoai;
            MaHTPP = maHTPP;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"MaDaiLy: {MaDaiLy}, TenDaiLy: {TenDaiLy}, DiaChi: {DiaChi}, " +
                              $"NguoiDaiDien: {NguoiDaiDien}, DienThoai: {DienThoai}, MaHTPP: {MaHTPP}");
        }
    }
}