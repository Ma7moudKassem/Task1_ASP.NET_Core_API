namespace Task1_ASP.NET_Core_API.Services.BaseServices
{
    public interface IBaseServices<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
