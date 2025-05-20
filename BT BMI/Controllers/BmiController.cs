using Microsoft.AspNetCore.Mvc;
using BTBMI.Models;

namespace BTBMI.Controllers
{
    public class BmiController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bmi model)
        {
            if (model.ChieuCao > 0 && model.CanNang > 0)
            {
                float chieuCaoMet = model.ChieuCao / 100; // Chuyển cm → m
                float bmi = model.CanNang / (chieuCaoMet * chieuCaoMet); // Tính BMI

                ViewBag.BMI = $"Chỉ số BMI của bạn là: {bmi:F2}";
            }
            else
            {
                ViewBag.BMI = "Vui lòng nhập số hợp lệ!";
            }

            return View();
        }
    }
}
