using BaseTemplate.Data.Entities;

namespace BaseTemplate.Dtos
{
    public class ShoppingListDto : BaseEntityDto
    {
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }

        public int SuperMarketId { get; set; }
        public int BrandId { get; set; }
        public int ProductId { get; set; }
    }
}
