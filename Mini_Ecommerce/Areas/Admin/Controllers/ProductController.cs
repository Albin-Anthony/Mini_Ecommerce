using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Framework;

namespace Mini_Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {

        public ProductController()
        {

        }
        [Route(CommonRoutes.ProductListView)]
        public IActionResult ProductListView()
        {
            return View();
        }

        [Route(CommonRoutes.AddProductList)]
        public IActionResult AddProductList()
        {
            return View();
        }
        [Route(CommonRoutes.CreateProduct)]
        public IActionResult CreateProduct()
        {
            return View();
        }
        public IActionResult DeleteProductList()
        {
            return View();
        }
    }
}
