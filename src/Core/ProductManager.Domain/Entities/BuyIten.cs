using ProductManager.Domain.Entities.Base;

namespace ProductManager.Domain.Entities;

public class BuyIten : EntityBase
{
    public BuyIten(int productId, int quantity)
    {
        ProductId = productId;
        Quantity = quantity;
    }

    public int BuyId { get; private set; }
    public virtual Buy Buy { get; private set; }
    public int ProductId { get; private set; }
    public virtual Product Product { get; private set; }
    public int Quantity { get; private set; }
}
