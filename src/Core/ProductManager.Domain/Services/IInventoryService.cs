using ProductManager.Domain.Dtos;
using ProductManager.Domain.Services.Base;

namespace ProductManager.Domain.Services
{
    public interface IInventoryService : IServiceBase<InventoryDto>
    {
    }
}
