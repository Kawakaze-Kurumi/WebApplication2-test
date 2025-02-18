using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GoToHome()
        {
            return RedirectToAction("Index", "User");
        }

        public ActionResult GoToHBL()
        {
            return RedirectToAction("Index", "HBL");
        }
    }
}
