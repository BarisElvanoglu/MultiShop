
using AutoMapper;
using AutoMapper.Execution;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.PruductDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Settings;
using System.Linq.Expressions;

namespace MultiShop.Catalog.Services.ProductServices
{
    public class ProductService : IProductService

    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Product> _productConnection;

        public ProductService(IMapper imapper,IDatabaseSettings _databaseSettings)
        {
            _mapper = imapper;
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productConnection = database.GetCollection<Product>(_databaseSettings.ProductsCollectionName);

        }
        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var values = _mapper.Map<Product>(createProductDto);
            return _productConnection.InsertOneAsync(values);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productConnection.DeleteOneAsync(x => x.ProductId == id);
        }

        public async Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            var values = await _productConnection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<GetByIdProductDto> GetByIdProductAsync(string id)
        {
            var values = await _productConnection.Find<Product>(x => x.ProductId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDto>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            await _productConnection.FindOneAndReplaceAsync(x => x.ProductId == updateProductDto.ProductId, values);
        }
    }
}
