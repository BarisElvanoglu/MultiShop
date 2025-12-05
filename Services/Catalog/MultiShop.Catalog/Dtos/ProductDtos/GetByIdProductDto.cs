namespace MultiShop.Catalog.Dtos.PruductDtos
{
    public class GetByIdProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductDescriptipn { get; set; }
        public string CategoryId { get; set; }
    }
}
