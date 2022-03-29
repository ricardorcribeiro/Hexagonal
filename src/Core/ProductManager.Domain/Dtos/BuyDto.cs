using ProductManager.Domain.Dtos.Base;

namespace ProductManager.Domain.Dtos
{
    public class BuyDto : DtoBase
    {
        public int ClientId { get; set; }
        public virtual ClientDto? Client { get; set; }
        public virtual IEnumerable<BuyItenDto> BuyItens { get; set; }
        public decimal BuyValue { get; set; }
    }
}
