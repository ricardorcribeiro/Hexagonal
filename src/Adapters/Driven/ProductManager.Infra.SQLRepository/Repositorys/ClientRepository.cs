using ProductManager.Domain.Adapters;
using ProductManager.Domain.Entities;
using ProductManager.Infra.SQLRepository.Contexts;
using ProductManager.Infra.SQLRepository.Repositorys.Base;

namespace ProductManager.Infra.SQLRepository.Repositorys
{
    internal class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(SqlContext contex) : base(contex)
        {
        }
    }
}
