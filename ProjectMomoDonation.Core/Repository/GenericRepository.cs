using Microsoft.EntityFrameworkCore;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDoanation.Core.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly MomoDbContext context;
        protected DbSet<TEntity> entities;

        public GenericRepository()
        {
            context = new MomoDbContext();
            entities = context.Set<TEntity>();
        }

        public GenericRepository(MomoDbContext _context)
        {
            context = _context;
            entities = _context.Set<TEntity>();
        }

        public async void SaveChangeAsync()
        {
            this.context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await entities.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            //context.Set<TEntity>().Update(entity);
            this.context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Deletesync(TEntity entity)
        {
            entities.Remove(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> GetByWhereAsync(Func<TEntity, bool> predicate)
        {
            return entities.Where(predicate).AsQueryable().AsNoTracking();
        }
    }
}