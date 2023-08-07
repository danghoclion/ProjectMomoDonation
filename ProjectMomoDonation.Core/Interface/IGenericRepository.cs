namespace ProjectMomoDoanation.Core.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> Deletesync(TEntity entity);

        IQueryable<TEntity> GetByWhereAsync(Func<TEntity, bool> predicate);
    }
}