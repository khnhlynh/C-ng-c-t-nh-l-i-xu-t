using Microsoft.AspNetCore.Mvc;

namespace Công_cụ_tính_lãi_xuất.Controllers
{
    public class Tinhlaixuat : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = " ";
            return View();
        }
        public IActionResult Index(int soTiengui, int laixuatgui, int kyhangui)
        {
            ViewData["SoTiengui"] = soTiengui;
            ViewData["laixuatgui"] = laixuatgui;
            ViewData["kyhangui"] = kyhangui;
            ViewData["KetQua1"] = soTiengui * laixuatgui/100/12 * kyhangui;
            ViewData["KetQua2"] = soTiengui * laixuatgui / 100 / 12 * kyhangui + soTiengui;
            return View();
        }
    }
}
