using Microsoft.AspNetCore.Mvc;

namespace Mini_Ecommerce.Controllers
{
    public class AuthenticationController : Controller
    {
     
        public IActionResult LogInPage()
        {
            return View();
        }
        [Route("user-register")]
        public IActionResult RegisterPage()
        {
            return View();
        }
    }
}
