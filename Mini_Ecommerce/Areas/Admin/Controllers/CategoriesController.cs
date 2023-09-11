using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Framework;

namespace Mini_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {

        public CategoriesController()
        {

        }
        [Route(CommonRoutes.CategoriesDetails)]
        public IActionResult CategoriesDetails()
        {
            return View();
        }
    }
}
