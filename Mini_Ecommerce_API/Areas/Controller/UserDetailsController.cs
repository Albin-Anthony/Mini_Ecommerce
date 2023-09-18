using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Service.Interface;

namespace Mini_Ecommerce.API.Areas.Controller
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailsService _userDetailsSer;

        public UserDetailsController(IUserDetailsService userDetailsService)
        {
            _userDetailsSer = userDetailsService;

        }

        [HttpGet("{id}")]
        [ActionName("GetUserDetailsById")]
        public async Task<IActionResult> GetUserDetailsByIdAsync(int id)
        {
            return Ok(await _userDetailsSer.SerGetUserDetailsByIdAsync(id));
        }
        [HttpPost]
        [ActionName("InsertUserDetailsAsync")]
        public async Task<IActionResult> InsertUserDetailsAsync([FromBody] UserDetailDTO obj)
        {
            return Ok(await _userDetailsSer.SerInsertUserDetailsAsync(obj));
        }
        [HttpPut("{id}")]
        [ActionName("UpdateUserDetailsAsync")]
        public async Task<IActionResult> UpdateUserDetailsAsync([FromBody] UserDetailDTO userDetail)
        {
            return Ok(await _userDetailsSer.SerUpdateUserDetailsAsync(userDetail));
        }


    }


}
