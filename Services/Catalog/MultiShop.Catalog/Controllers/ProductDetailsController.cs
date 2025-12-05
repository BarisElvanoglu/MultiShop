using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.PruductDtos;
using MultiShop.Catalog.Services.ProductDetailServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _ProductDetailService;
        public ProductDetailsController(IProductDetailService ProductDetailService)
        {
            _ProductDetailService = ProductDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var categories = await _ProductDetailService.GetAllProductDetailsAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var ProductDetail = await _ProductDetailService.GetByIdProductDetailAsync(id);
            return Ok(ProductDetail);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDetailDto createProductDto)
        {
            await _ProductDetailService.CreateProductDetailAsync(createProductDto);
            return Ok("Ürün detayı başarı ile eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _ProductDetailService.DeleteProductDetailAsync(id);
            return Ok("Ürün detayı başarı ile silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDetailDto updateProductDto)
        {
            await _ProductDetailService.UpdateProductDetailAsync(updateProductDto);
            return Ok("Ürün detayı başarı ile güncellendi");
        }
    }
}
