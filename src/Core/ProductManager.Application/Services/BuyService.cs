using AutoMapper;
using ProductManager.Application.Services.Base;
using ProductManager.Domain.Adapters;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Services;

namespace ProductManager.Application.Services
{
    public class BuyService : ServiceBase<BuyDto, Buy>, IBuyService
    {
        private readonly IInventoryRepository _inventoryRepository;
        public BuyService(
            IBuyRepository repository,
            IInventoryRepository inventoryRepository,
            IMapper mapper
            ) : base(repository, mapper)
        {
            _inventoryRepository = inventoryRepository;
        }

        public override Buy ConvertToEntity(BuyDto obj)
            => new Buy(obj.ClientId, obj.BuyItens);

        public override void Add(BuyDto obj)
        {
            var buy = ConvertToEntity(obj);
            var listIdProducts = buy.BuyItens.Select(x=> x.ProductId).ToList();
            var inventoryProduct = _inventoryRepository
                .GetAll()
                .Where(x => listIdProducts.Contains(x.ProductId))
                .ToList();

            foreach (var iten in obj.BuyItens)
            {
                inventoryProduct
                    .First(x=> x.ProductId == iten.ProductId)
                    .WithdrawalInventory(iten.Quantity);
            }

            _inventoryRepository.UpdateAll(inventoryProduct);
            _repository.Add(buy);
        }
    }
}
