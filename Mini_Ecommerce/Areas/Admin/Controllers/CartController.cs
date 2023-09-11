using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Framework;

namespace Mini_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CartController : Controller
    {

        public CartController()
        {

        }
        [Route(CommonRoutes.Cart)]
        public IActionResult Cart()
        {
            return View();
        }
    }
}
