using ProductManager.Domain.Entities.Base;

namespace ProductManager.Domain.Adapters.Base;
public interface IRepositoryBase<TEntity> where TEntity : EntityBase
{
    void Add(TEntity obj);

    void AddAll(IEnumerable<TEntity> obj);

    void Update(TEntity obj);

    void UpdateAll(IEnumerable<TEntity> obj);

    void Remove(TEntity obj);

    IQueryable<TEntity> GetAll();

    TEntity GetById(int id);
}