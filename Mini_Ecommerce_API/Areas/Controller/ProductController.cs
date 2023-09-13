using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Framework;
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
		public async Task<IActionResult> GetUserDetailsAsync()
		{
			return Ok(await _productDetailservice.GetUserDetailsAsync());
		}

		// GET api/<ProductController>/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetUserDetailsByIdAsync(int id)
		{
			return Ok(await _productDetailservice.GetUserDetailsByIdAsync(id));
		}

		// POST api/<ProductController>
		[HttpPost]
		[ActionName("AddUserDetailsAsync")]
		public async Task<IActionResult> AddUserDetailsAsync([FromBody] ProductDetailDTO productDetail)
		{
			return Ok(await _productDetailservice.AddUserDetailsAsync(productDetail));
		}
		// PUT api/<PaymentController>/5


		// PUT api/<ProductController>/5
		[HttpPut("{id}")]
		public async Task<IActionResult> updateUserDetailsAsync([FromBody] ProductDetailDTO productDetail)
		{
			return Ok(await _productDetailservice.UpdateUserDetailsAsync(productDetail));
		}

		// DELETE api/<ProductController>/5
		[HttpDelete]
		public async Task<IActionResult> DeleteUserDetailsAsync(int Id)
		{
			return Ok(await _productDetailservice.DeleteUserDetailsAsync(Id));
		}
	}
}
