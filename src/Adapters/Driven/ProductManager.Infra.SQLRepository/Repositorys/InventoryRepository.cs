using ProductManager.Domain.Adapters;
using ProductManager.Domain.Entities;
using ProductManager.Infra.SQLRepository.Contexts;
using ProductManager.Infra.SQLRepository.Repositorys.Base;

namespace ProductManager.Infra.SQLRepository.Repositorys
{
    public class InventoryRepository : RepositoryBase<Inventory>, IInventoryRepository
    {
        public InventoryRepository(SqlContext contex) : base(contex)
        {
        }
    }
}
