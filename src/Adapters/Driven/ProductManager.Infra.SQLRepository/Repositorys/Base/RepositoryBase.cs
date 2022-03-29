using Microsoft.EntityFrameworkCore;
using ProductManager.Domain.Adapters.Base;
using ProductManager.Domain.Entities.Base;
using ProductManager.Infra.SQLRepository.Contexts;

namespace ProductManager.Infra.SQLRepository.Repositorys.Base;
public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable
        where TEntity : EntityBase
{
    protected readonly SqlContext _db;

    protected readonly DbSet<TEntity> entities;

    public RepositoryBase(SqlContext contex)
    {
        _db = contex;
        entities = _db.Set<TEntity>();
    }

    public virtual void Add(TEntity obj)
    {
        entities.Add(obj);
        _db.SaveChanges();
    }


    public void AddAll(IEnumerable<TEntity> obj)
    {
        entities.AddRange(obj);
        _db.SaveChanges();  
    }

    public virtual IQueryable<TEntity> GetAll()
            => entities;

    public virtual TEntity GetById(int id)
        => entities.Find(id);

    public virtual void Remove(TEntity obj)
    {
        entities.Remove(obj);
        _db.SaveChanges();
    }

    public virtual void Update(TEntity obj)
    {
        _db.Entry(obj).State = EntityState.Modified;
        _db.SaveChanges();
    }
    
    public virtual void UpdateAll(IEnumerable<TEntity> obj)
    {
        _db.UpdateRange(obj);
        _db.SaveChanges();
    }

    public virtual void Dispose()
    {
        _db.Dispose();
        GC.SuppressFinalize(this);
    }

}
