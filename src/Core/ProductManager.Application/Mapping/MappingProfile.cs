using AutoMapper;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Entities;

namespace ProductManager.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(to => to.Name, map => map.MapFrom(src => src.Name))
                .ForMember(to => to.Price, map => map.MapFrom(src => src.Price))
                .ForMember(to => to.Id, map => map.MapFrom(src => src.Id))
                ;

            CreateMap<Inventory, InventoryDto>()
                .ForMember(to => to.Id, map => map.MapFrom(src => src.Id))
                .ForMember(to => to.ProductId, map => map.MapFrom(src => src.ProductId))
                .ForMember(to => to.Product, map => map.MapFrom(src => src.Product))
                .ForMember(to => to.Amount, map => map.MapFrom(src => src.Amount))
                ;

            CreateMap<Client, ClientDto>()
                .ForMember(to => to.Id, map => map.MapFrom(src => src.Id))
                .ForMember(to => to.Name, map => map.MapFrom(src => src.Name))
                .ForMember(to => to.Cpf, map => map.MapFrom(src => src.Cpf))
                ;

            CreateMap<Buy, BuyDto>()
                .ForMember(to => to.Id, map => map.MapFrom(src => src.Id))
                .ForMember(to => to.ClientId, map => map.MapFrom(src => src.ClientId))
                .ForMember(to => to.Client, map => map.MapFrom(src => src.Client))
                .ForMember(to => to.BuyItens, map => map.MapFrom(src => src.BuyItens))
                .ForMember(to => to.BuyValue, map => map.MapFrom(src => src.BuyValue))
                ;

            CreateMap<BuyIten, BuyItenDto>()
                .ForMember(to => to.Id, map => map.MapFrom(src => src.Id))
                .ForMember(to => to.ProductId, map => map.MapFrom(src => src.ProductId))
                .ForMember(to => to.Product, map => map.MapFrom(src => src.Product))
                .ForMember(to => to.Quantity, map => map.MapFrom(src => src.Quantity))
                ;
        }
    }
}
