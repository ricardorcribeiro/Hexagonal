using ProductManager.Domain.Adapters.Base;
using ProductManager.Domain.Entities;

namespace ProductManager.Domain.Adapters;

public interface IProductRepository : IRepositoryBase<Product>
{
    
}