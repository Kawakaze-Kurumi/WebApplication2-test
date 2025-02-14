using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class QuotationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
