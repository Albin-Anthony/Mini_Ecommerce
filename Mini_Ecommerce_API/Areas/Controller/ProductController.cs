using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mini_Ecommerce.API.Areas.Controller
{
	[Route("api/[controller]/[Action]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IproductService _productDetailservice;

		public ProductController(IproductService productDetailservice)
		{
			_productDetailservice = productDetailservice;
		}

		// GET: api/<ProductController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<ProductController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ProductController>
		[HttpPost]
		public async Task<IActionResult> AddUserDetailsAsync([FromBody] ProductDetailDTO productDetail)
		{
			return Ok(await _productDetailservice.AddUserDetailsAsync(productDetail));
		}
		// PUT api/<PaymentController>/5
		

		// PUT api/<ProductController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ProductController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
