using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class HeThongPhanPhoi
    {
       [Key]
        public string MaHTPP { get; set; }

        public string TenHTPP { get; set; }

        public HeThongPhanPhoi(string maHTPP, string tenHTPP)
        {
            MaHTPP = maHTPP;
            TenHTPP = tenHTPP;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"MaHTPP: {MaHTPP}, TenHTPP: {TenHTPP}");
        }
    }
}