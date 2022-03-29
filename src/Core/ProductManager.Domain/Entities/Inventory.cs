using ProductManager.Domain.Entities.Base;

namespace ProductManager.Domain.Entities;

public class Inventory : EntityBase
{
    public Inventory(int productId,int amount)
    {
        SetProductId(productId);
        SetAmount(amount);
    }
        public int ProductId { get; private set; }
        public virtual Product Product { get; private set; }
        public int Amount { get; private set; }

    private void SetProductId(int id)
    {
        if (id < 1) throw new ArgumentOutOfRangeException();
        ProductId = id;
    }

    private void SetAmount(int amount)
    {
        if (amount < 1) throw new ArgumentOutOfRangeException();
        Amount = amount;
    }

    public void WithdrawalInventory(int Withdrawal)
    {
        if (Amount - Withdrawal < 0) throw new Exception($"Insufficient stock for the product {Product.Name}");
        Amount -= Withdrawal;
    }
}