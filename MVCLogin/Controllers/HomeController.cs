using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCLogin.Models;

namespace MVCLogin.Controllers
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
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                
            
            if (login.UserID== "admin" && login.UserPass==1234 )
            {
                string LoginMesaj = "";
                LoginMesaj = "Tebrikler başarılı giriş...";
                ViewBag.Mesaj = LoginMesaj;

            }
            else
            {
                string LoginMesaj2 = "";
                LoginMesaj2 = "Başarısız giriş..Kullanıcı adı veya şifre yanlış.....";
                ViewBag.Mesaj = LoginMesaj2;
            }
        }
            return View(login);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}