using Microsoft.AspNetCore.Mvc;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Services;

namespace ProductManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyController : ControllerBase
    {
        private readonly IBuyService _BuyService;

        public BuyController(IBuyService BuyService)
        {
            _BuyService = BuyService;
        }

        [HttpGet]
        public BuyDto Get(int id) => _BuyService.GetById(id);

        [HttpPost]
        public void Post([FromBody] BuyDto buy)
            => _BuyService.Add(buy);

        [HttpPut]
        public void Put([FromBody] BuyDto buy)
            => _BuyService.Update(buy);
    }
}
