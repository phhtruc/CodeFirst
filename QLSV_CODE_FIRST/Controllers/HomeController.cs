using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLSV_CODE_FIRST.Data;
using QLSV_CODE_FIRST.Models;
using System.Diagnostics;

namespace QLSV_CODE_FIRST.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<SinhVien> sinhVienList = _db.SinhViens
                .Include(x => x.lop)
                .Include(x => x.lop.khoa)
                .Where(x => x.lop.khoaId == 1 && x.age >= 18 && x.age <= 20)
                .ToList();
            return View(sinhVienList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
