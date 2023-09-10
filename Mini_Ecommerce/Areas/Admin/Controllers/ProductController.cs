using Microsoft.AspNetCore.Mvc;

namespace Mini_Ecommerce.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
