namespace BaseTemplate.Data.Entities;

public class Products : BaseEntity
{
    public Products()
    {
        Brands = new HashSet<Brands>();
        SuperMarkets = new HashSet<SuperMarkets>();
        ShoppingLists = new HashSet<ShoppingList>();
    }
    public string Name { get; set; }
    public int Price { get; set; }
    public ICollection<SuperMarkets> SuperMarkets { get; set; }
    public ICollection<Brands> Brands { get; set; }
    public ICollection<ShoppingList> ShoppingLists { get; set; }
}
