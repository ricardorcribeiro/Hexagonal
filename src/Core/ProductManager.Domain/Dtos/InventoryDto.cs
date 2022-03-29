using ProductManager.Domain.Dtos.Base;

namespace ProductManager.Domain.Dtos
{
    public class InventoryDto : DtoBase 
    {
        public int ProductId { get; set; }

        public ProductDto? Product { get; set; }

        public int Amount { get; set; }
    }
}