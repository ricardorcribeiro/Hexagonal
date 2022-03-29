using Microsoft.AspNetCore.Mvc;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Services;

namespace ProductManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public ClientDto Get(int id) => _clientService.GetById(id);

        [HttpPost]
        public void Post([FromBody] ClientDto client)
            => _clientService.Add(client);

        [HttpPut]
        public void Put([FromBody] ClientDto client)
            => _clientService.Update(client);
    }
}
