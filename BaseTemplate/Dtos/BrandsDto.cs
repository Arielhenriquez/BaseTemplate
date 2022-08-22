using BaseTemplate.Data.Entities;

namespace BaseTemplate.Dtos
{
    public class BrandsDto : BaseEntityDto
    {
        public string Name { get; set; }
        public int SuperMarketId { get; set; }
        public int ProductId { get; set; }
    }
}
