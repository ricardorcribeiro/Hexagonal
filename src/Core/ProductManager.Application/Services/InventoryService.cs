using AutoMapper;
using ProductManager.Application.Services.Base;
using ProductManager.Domain.Adapters;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Services;

namespace ProductManager.Application.Services
{
    public class InventoryService : ServiceBase<InventoryDto, Inventory>, IInventoryService
    {
        public InventoryService(IInventoryRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override Inventory ConvertToEntity(InventoryDto obj)
            => new Inventory(obj.ProductId, obj.Amount);
    }
}
