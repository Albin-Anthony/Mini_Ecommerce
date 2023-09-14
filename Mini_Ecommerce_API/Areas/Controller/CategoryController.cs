using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Service.Interface;

namespace Mini_Ecommerce.API.Areas.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryDetailService;

        public CategoryController(ICategoryService CategoryDetailService)
        {
            _CategoryDetailService = CategoryDetailService;
        }

        [HttpGet]
        [ActionName("GetCategory")]
        public async Task<IActionResult> GetCategoryDetailsAsync()
        {
            return Ok(await _CategoryDetailService.GetCategoryDetailsAsync());
        }

        [HttpPost]
        [ActionName("saveCategory")]
        public async Task<IActionResult> AddCategoryDetailsAsync([FromBody] CategoryDTO CategoryDetail)
        {
            return Ok(await _CategoryDetailService.AddCategoryDetailsAsync(CategoryDetail));
        }

        [HttpDelete]
        [ActionName("DeleteCategoryDetailsByIdAsync")]
        public async Task<IActionResult> DeleteCategoryDetailsByIdAsync([FromQuery] int id)
        {
            return Ok(await _CategoryDetailService.DeleteCategoryDetailsByIdAsync(id));
        }
    }
}
