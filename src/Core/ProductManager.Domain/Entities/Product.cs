using ProductManager.Domain.Entities.Base;

namespace ProductManager.Domain.Entities;

public class Product : EntityBase
{
    public Product(string name, decimal price)
    {
        Name = SetName(name);
        Price = SetPrice(price);
    }
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    private string SetName(string name)
    {
        if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException();
        if(name.Count() > 50) throw new ArgumentOutOfRangeException();
        return name;
    }

    private decimal SetPrice(decimal price)
    {
        if(price > 999999999) throw new ArgumentOutOfRangeException();
        return price;
    }
}