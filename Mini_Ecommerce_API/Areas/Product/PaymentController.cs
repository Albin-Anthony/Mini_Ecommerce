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
        // GET: api/<PaymentController>
        [HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<PaymentController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<PaymentController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<PaymentController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<PaymentController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
