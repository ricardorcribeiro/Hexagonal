using ProductManager.Domain.Dtos.Base;

namespace ProductManager.Domain.Dtos
{
    public class ProductDto : DtoBase 
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    public void Deconstruct(
        out int id, 
        out string name, 
        out decimal price
    ) 
        => (id, name, price) 
        = (Id, Name, Price);
    }
}