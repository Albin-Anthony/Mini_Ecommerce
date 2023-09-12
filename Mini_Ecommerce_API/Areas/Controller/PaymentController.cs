using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mini_Ecommerce.API.Areas.Controller
{
	[Route("api/[controller]/[Action]")]
	[ApiController]
	public class PaymentController : ControllerBase
	{
		private readonly IpaymentService _userDetailsService;

		public PaymentController(IpaymentService userDetailsService)
		{
			_userDetailsService = userDetailsService;

		}
		// GET select api/<PaymentController>/5
		[HttpGet]
		public async Task<IActionResult> GetUserDetailsAsync()
		{
			return Ok(await _userDetailsService.GetUserDetailsAsync());
		}


		// GET: insert api/<PaymentController>
		[HttpPost]
		public async Task<IActionResult> AddUserDetailsAsync([FromBody] PamentDetailDTO userDetail)
		{
			return Ok(await _userDetailsService.AddUserDetailsAsync(userDetail));
		}




	}
}
