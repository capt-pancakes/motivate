using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Data.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
       Task<TEntity> Add(TEntity obj);
        Task<TEntity?> GetById<T>(T id);
        Task<List<TEntity>> GetAll();
        Task<TEntity> Update(TEntity obj);
        Task Remove(Guid id);
        Task<int> SaveChangesAsync();
    }
}
