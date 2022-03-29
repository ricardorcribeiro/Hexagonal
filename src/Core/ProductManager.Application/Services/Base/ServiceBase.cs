using AutoMapper;
using ProductManager.Domain.Adapters.Base;
using ProductManager.Domain.Dtos.Base;
using ProductManager.Domain.Entities.Base;
using ProductManager.Domain.Services.Base;

namespace ProductManager.Application.Services.Base;
public abstract class ServiceBase<Dto, Entity> : IServiceBase<Dto>
where Dto : DtoBase
where Entity : EntityBase
{
    protected readonly IRepositoryBase<Entity> _repository;
    protected readonly IMapper _mapper;
    
    protected Action<Entity> Validation { get; set; }
    
    public ServiceBase(IRepositoryBase<Entity> repository, IMapper mapper)
        => (_repository, _mapper) = (repository, mapper);

    public abstract Entity ConvertToEntity(Dto obj);

    public virtual void Add(Dto obj)
    {
        var ent = ConvertToEntity(obj);

        Validation?.Invoke(ent);

        _repository.Add(ent);
    }

    public virtual void Update(Dto obj)
    {
        var ent = ConvertToEntity(obj);

        ent.SetId(obj.Id);

        Validation?.Invoke(ent);

        _repository.Update(ent);
    }

    public virtual Dto GetById(int id)
    {
        var entity = _repository.GetById(id);
        return _mapper.Map<Dto>(entity);
    }
        
}