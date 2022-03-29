using ProductManager.Domain.Dtos;
using ProductManager.Domain.Entities.Base;
using System.Collections.ObjectModel;

namespace ProductManager.Domain.Entities
{
    public class Buy : EntityBase
    {
        public Buy()
        {

        }
        public Buy(int clientId, IEnumerable<BuyItenDto> itens)
        {
            ClientId = clientId;
            BuyItens = itens.Select(x => new BuyIten(x.ProductId,x.Quantity)).ToList();
        }
        public int ClientId { get; set; }
        public virtual Client Client { get; private set; }
        public virtual IEnumerable<BuyIten> BuyItens { get; private set; }
        public decimal BuyValue => BuyItens.Select(x=> x.Product.Price * x.Quantity).Sum();
    }
}
