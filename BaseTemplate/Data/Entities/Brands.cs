
namespace BaseTemplate.Data.Entities;

public class Brands : BaseEntity 
{
    public Brands()
    {
        SuperMarkets = new HashSet<SuperMarkets>();
        Products = new HashSet<Products>();
    }
    public string Name { get; set; }
    public ICollection<SuperMarkets> SuperMarkets { get; set; }
    public ICollection<Products> Products { get; set; }
}
