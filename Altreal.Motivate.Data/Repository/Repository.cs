using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Altreal.Motivate.Data.Repository
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {

        protected readonly TContext _context;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(TContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public abstract Task<TEntity> Add(TEntity obj);
        public abstract Task<TEntity?> GetById<T>(T id);

        //public async Task<TEntity> GetById<T>(T id)
        //{
        //    return await DbSet.FindAsync(id);
        //}

        public virtual Task<List<TEntity>> GetAll()
        {
            return DbSet.Where(ds => !ds.DeletedAt.HasValue).ToListAsync();
        }
        public virtual Task Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id) ?? throw new InvalidOperationException($"No entity found with id {id}"));
            return Task.FromResult(this.SaveChangesAsync());
        }

        public abstract Task<TEntity> Update(TEntity entity);

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

    }
}
