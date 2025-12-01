namespace MultiShop.Catalog.Dtos.CategoryDtos
{
    public class GetByIdProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ProductImageUrl { get; set; }
        public string ProductDescriptipn { get; set; }
        public string CategoryId { get; set; }
    }
}
