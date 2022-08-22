using BaseTemplate.Data.Entities;

namespace BaseTemplate.Dtos
{
    public class SuperMarketDto : BaseEntityDto
    {
        public string Name { get; set; }
        public bool IsFavorite { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }
    }
}
