using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;   
        }

        Test1Context db= new Test1Context();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = db.TblTaiKhoans.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                if (user.Username == "admin")
                    return RedirectToAction("Index", "Admin");
                else if (user.Username == "user")
                    return RedirectToAction("Index", "User");
            }

            ViewBag.Error = "Sai tài khoản hoặc mật khẩu!";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
