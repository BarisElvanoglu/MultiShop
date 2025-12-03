
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.PruductDtos;



namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task CreateProductAsync(Dtos.CategoryDtos.CreateProductDto createProductDto);

        Task UpdateProductAsync(UpdateProductDto updateProductDto);

        Task DeleteProductAsync(string id);

        Task<GetByIdProductDto> GetByIdProductAsync(string id);
    }
}
