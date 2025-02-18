using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HBLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
