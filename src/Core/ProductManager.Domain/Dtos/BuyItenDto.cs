using ProductManager.Domain.Dtos.Base;

namespace ProductManager.Domain.Dtos
{
    public class BuyItenDto : DtoBase
    {
        public int ProductId { get; set; }
        public ProductDto? Product { get; set; }
        public int Quantity { get; set; }
    }
}
