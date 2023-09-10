using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mini_Ecommerce.API.Areas.Product
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentController : ControllerBase
	{
		private readonly IpaymentService _userDetailsService;

        public PaymentController(IpaymentService userDetailsService)
        {
			_userDetailsService = userDetailsService;

		}
        // GET: insert api/<PaymentController>
        [HttpGet]
		public async Task<IActionResult> GetpaymentDetailsAsync()
		{
			return Ok(await _userDetailsService.GetpaymentDetailsAsync());
		}

		// GET select api/<PaymentController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		
	}
}
