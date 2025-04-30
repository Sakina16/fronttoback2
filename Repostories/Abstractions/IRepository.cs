using fronttoback33.Models;

namespace fronttoback33.Repostories.Abstractions
{
    public interface IRepository<T> where T:BaseEntity
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}
