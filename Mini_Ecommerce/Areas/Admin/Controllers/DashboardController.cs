using Microsoft.AspNetCore.Mvc;

namespace Mini_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
       
        [Route("admin-dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
