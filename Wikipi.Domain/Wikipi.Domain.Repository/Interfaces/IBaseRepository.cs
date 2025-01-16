namespace Wikipi.Domain.Repository.Interfaces
{
    public interface IBaseRepository
    {
        Task<TEntity> Create<TEntity>(TEntity obj);
        Task<TEntity> Update<TEntity>(TEntity obj);
        Task<TEntity> Delete<TEntity>(string id);
        Task<TEntity> Get<TEntity>(string id) where TEntity : IEntity;
        Task<IEnumerable<TEntity>> GetAll<TEntity>();
    }
}
