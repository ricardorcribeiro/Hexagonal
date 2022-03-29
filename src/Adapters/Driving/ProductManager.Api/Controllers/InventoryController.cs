using Microsoft.AspNetCore.Mvc;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Services;

namespace ProductManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
            => (_inventoryService) = (inventoryService);

        [HttpGet]
        public InventoryDto Get(int id) => _inventoryService.GetById(id);

        [HttpPost]
        public void Post([FromBody] InventoryDto product)
            => _inventoryService.Add(product);

        [HttpPut]
        public void Put([FromBody] InventoryDto product)
            => _inventoryService.Update(product);
    }
}
