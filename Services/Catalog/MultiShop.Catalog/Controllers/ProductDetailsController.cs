using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Services.CategoryServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly ICategoryService _ProductDetailService;
        public ProductDetailsController(ICategoryService ProductDetailService)
        {
            _ProductDetailService = ProductDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var categories = await _ProductDetailService.GetAllCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var ProductDetail = await _ProductDetailService.GetByIdCategoryAsync(id);
            return Ok(ProductDetail);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _ProductDetailService.CreateCategoryAsync(createCategoryDto);
            return Ok("Ürün detayı başarı ile eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _ProductDetailService.DeleteCategoryAsync(id);
            return Ok("Ürün detayı başarı ile silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _ProductDetailService.UpdateCategoryAsync(updateCategoryDto);
            return Ok("Ürün detayı başarı ile güncellendi");
        }
    }
}
