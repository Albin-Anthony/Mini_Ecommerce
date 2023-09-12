using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Framework;

namespace Mini_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {

        public OrderController()
        {

        }
        [Route(CommonRoutes.Orders)]
        public IActionResult Orders()
        {
            return View();
        }
    }
}
