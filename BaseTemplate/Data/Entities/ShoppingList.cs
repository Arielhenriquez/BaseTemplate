namespace BaseTemplate.Data.Entities;

public class ShoppingList : BaseEntity
{
    public string Author { get; set; }
    public DateTime CreatedDate { get; set; }

    public SuperMarkets? SuperMarkets { get; set; }
    public int? SuperMarketId { get; set; }
    public Products? Products { get; set; }
    public int? ProductId { get; set; }
}
