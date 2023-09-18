using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Framework;

namespace Mini_Ecommerce.Areas.User.Controllers
{
    [Area("User")]
    public class UserProfileController : Controller
    {
        [Route(CommonRoutes.UserProfile)]
        public IActionResult UserProfile()
        {
            return View();
        }
    }
}
