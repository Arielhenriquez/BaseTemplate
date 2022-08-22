namespace BaseTemplate.Data.Entities;

public class SuperMarkets : BaseEntity
{
    public SuperMarkets()
    {
        ShoppingLists = new HashSet<ShoppingList>();
    }
    public string Name { get; set; }
    public bool IsFavorite { get; set; }
    public Products? Products { get; set; }
    public int? ProductId { get; set; }
    public Brands? Brands { get; set; }
    public int? BrandId { get; set; }
    public ICollection<ShoppingList>? ShoppingLists { get; set; }
}
