using BaseTemplate.Data.Entities;

namespace BaseTemplate.Dtos
{
    public class ProductsDto : BaseEntityDto 
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int SuperMarketId { get; set; }
        public int BrandId { get; set; }
    }
}
