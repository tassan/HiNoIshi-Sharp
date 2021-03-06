using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiNoIshi.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity, IDisposable
    {
        void Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        void Update(TEntity entity);
        void Remove(Guid id);
    }
}