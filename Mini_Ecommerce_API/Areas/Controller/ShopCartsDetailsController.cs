using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Service.Interface;

namespace Mini_Ecommerce.API.Areas.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopCartsDetailsController : ControllerBase
    {

        private readonly IShopCartsService _cartsDetailsService;

        public ShopCartsDetailsController(IShopCartsService cartsDetailsService)
        {
            _cartsDetailsService = cartsDetailsService;

        }
        [HttpGet]
        [ActionName("GetAllCartDetails")]

        public async Task<IActionResult> GetAllDoctorDetails()
        {
            return Ok(await _cartsDetailsService.SerGetAllCartDetailsAsync());
        }
        [HttpGet("{Id}")]
        [ActionName("GetCartDetailsById")]
        public async Task<IActionResult> GetCartDetailsByIdAsync(int id)
        {
            return Ok(await _cartsDetailsService.SerGetCartDetailsByIdAsync(id));
        }
        [HttpPost]
        [ActionName("InsertUserDetailsAsync")]
        public async Task<IActionResult> InsertCartDetailsAsync([FromBody] CartDetailDTO obj)
        {
            return Ok(await _cartsDetailsService.SerInsertCartDetailsAsync(obj));
        }
        [HttpDelete("{Id}")]
        [ActionName("DeleteCartByID")]
        public async Task<IActionResult> DeleteCartById([FromQuery] Int64 Trash)
        {

            return Ok(await _cartsDetailsService.SerDeleteCartByIdAsync(Trash));
        }
        [HttpPut("{Id}")]
        [ActionName("UpdateCartDetailsById")]
        public async Task<IActionResult> UpdateCartDetailsAsync(int Id, [FromBody] CartDetailDTO obj)
        {
            obj.CartId = Id;

            return Ok(await _cartsDetailsService.SerUpdateCartDetailsByIdAsync(obj));
        }
    }
}
