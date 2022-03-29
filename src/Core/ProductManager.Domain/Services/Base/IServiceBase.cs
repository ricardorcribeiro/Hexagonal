using ProductManager.Domain.Dtos.Base;

namespace ProductManager.Domain.Services.Base;
public interface IServiceBase<Dto> 
where Dto : DtoBase
{
    Dto GetById(int id);
    void Add(Dto obj);
    void Update(Dto obj);
}