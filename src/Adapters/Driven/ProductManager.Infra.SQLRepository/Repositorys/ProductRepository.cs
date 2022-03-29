using ProductManager.Domain.Adapters;
using ProductManager.Domain.Entities;
using ProductManager.Infra.SQLRepository.Contexts;
using ProductManager.Infra.SQLRepository.Repositorys.Base;

namespace ProductManager.Infra.SQLRepository.Repositorys;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(SqlContext contex) : base(contex) {}
}