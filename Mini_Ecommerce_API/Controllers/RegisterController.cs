using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Service.Interface;

namespace Mini_Ecommerce.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]  //Http method
        [ActionName("SaveRegisterDetailsAsync")]

        public async Task<ActionResult> SaveRegisterDetailsAsync([FromBody]RegisterDTO registerDetails)
        {
            return Ok(await _registerService.SaveRegisterDetailsAsync(registerDetails));
        }


        [HttpPost]  //Http method
        [ActionName("LoginDetailsAsync")]

        public async Task<ActionResult> LoginDetailsAsync([FromBody] LoginDTO Logindetail)
        {
            return Ok(await _registerService.LoginDetailsAsync(Logindetail));
        }


    }
}
