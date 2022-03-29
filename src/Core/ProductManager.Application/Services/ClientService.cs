using AutoMapper;
using ProductManager.Application.Services.Base;
using ProductManager.Domain.Adapters;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Services;

namespace ProductManager.Application.Services
{
    public class ClientService : ServiceBase<ClientDto, Client>, IClientService
    {
        public ClientService(IClientRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override Client ConvertToEntity(ClientDto obj)
        {
            return new Client(obj.Name, obj.Cpf);
        }
    }
}
