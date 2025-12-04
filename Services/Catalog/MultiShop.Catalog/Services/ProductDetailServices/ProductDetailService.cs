using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.PruductDtos;
using MultiShop.Catalog.Entities;
using MultiShop.Catalog.Services.ProductDetailServices;
using MultiShop.Catalog.Settings;

using MultiShop.Catalog.Entities;

using MultiShop.Catalog.Dtos.ProductDetailDtos;


namespace MultiShop.Catalog.Services.ProductDetailServices;

public class ProductDetailService : IProductDetailService
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<ProductDetail> _ProductDetailConnection;

    public ProductDetailService(IMapper imapper, IDatabaseSettings _databaseSettings)
    {
        _mapper = imapper;
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _ProductDetailConnection = database.GetCollection<ProductDetail>(_databaseSettings.ProductDetailCollectionName);

    }
    public Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto)
    {
        var values = _mapper.Map<ProductDetail>(createProductDetailDto);
        return _ProductDetailConnection.InsertOneAsync(values);
    }

    public async Task DeleteProductDetailAsync(string id)
    {
        await _ProductDetailConnection.DeleteOneAsync(x => x.ProductDetailID == id);
    }

    public async Task<List<ResultProductDetailDto>> GetAllProductDetailsAsync()
    {
        var values = await _ProductDetailConnection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultProductDetailDto>>(values);
    }

    public async Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id)
    {
        var values = await _ProductDetailConnection.Find<ProductDetail>(x => x.ProductDetailID == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdProductDetailDto>(values);
    }

    public async Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto)
    {
        var values = _mapper.Map<ProductDetail>(updateProductDetailDto);
        await _ProductDetailConnection.FindOneAndReplaceAsync(x => x.ProductDetailID == updateProductDetailDto.ProductDetailId, values);
    }

}
