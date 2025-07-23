using ToDoListAPI.Models.CustomModels;

namespace ToDoListAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetPagedAsync(int PageNumber, int PageSize);
        Task<T> GetByIdAsync(int Id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(int Id, T entity);
        Task<T> DeleteAsync(int Id);


    }
}
