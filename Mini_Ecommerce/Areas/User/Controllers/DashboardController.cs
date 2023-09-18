using Microsoft.AspNetCore.Mvc;

namespace Mini_Ecommerce.Areas.User.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            return View();
        }
    }
}
