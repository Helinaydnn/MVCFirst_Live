using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCViews.Models;

namespace MVCViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]//sayfayı getiriyor..
        public IActionResult Personel()
        {
            return View();
        }
        [HttpPost]//sayfayı getiriyor..
        public IActionResult Personel(Personel personel)
        {
           if (ModelState.IsValid)
            {
                string personelBilgileri = "";
                personelBilgileri = "Personelin Bilgileri (Ad, Soyad ,Yaş) :" + personel.Ad + " " + personel.Soyad + " " + personel.Yas.ToString();
                ViewBag.Mesaj = personelBilgileri;
              
            }
           return View(personel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}