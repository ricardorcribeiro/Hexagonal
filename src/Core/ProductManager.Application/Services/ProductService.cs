using AutoMapper;
using ProductManager.Application.Services.Base;
using ProductManager.Domain.Adapters;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Services;

namespace ProductManager.Application.Services;
public class ProductService : ServiceBase<ProductDto, Product>, IProductService
{
    public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }

    public override Product ConvertToEntity(ProductDto obj)
    {
        var (id, name, price) = obj;
        return new Product(name, price);
    }

    public override void Update(ProductDto obj)
    {
        Validation = (obj) =>
        {
            if(obj.Id <= 0) throw new Exception();
        };

        base.Update(obj);
    }
}