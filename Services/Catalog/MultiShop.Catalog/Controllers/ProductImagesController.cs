using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Services.CategoryServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly ICategoryService _ProductImageService;
        public ProductImagesController(ICategoryService ProductImageService)
        {
            _ProductImageService = ProductImageService;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var categories = await _ProductImageService.GetAllCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var ProductImage = await _ProductImageService.GetByIdCategoryAsync(id);
            return Ok(ProductImage);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _ProductImageService.CreateCategoryAsync(createCategoryDto);
            return Ok("Ürün görselleri başarı ile eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _ProductImageService.DeleteCategoryAsync(id);
            return Ok("Ürün görselleri ile silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _ProductImageService.UpdateCategoryAsync(updateCategoryDto);
            return Ok("Ürün görselleri başarı ile güncellendi");
        }
    }
}
