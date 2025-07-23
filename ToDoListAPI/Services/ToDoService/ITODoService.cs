using ToDoListAPI.Models.CustomModels;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoDTO;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoModel;

namespace ToDoListAPI.Services.ToDoService
{
    public interface ITODoService
    {
        Task<ToDoResponse> GetPagedAsync(int PageNumber, int PageSize);
        Task<ToDoResponse> GetByIdAsync(int Id);
        Task<ToDoResponse> AddAsync(CreateToDo entity);
        Task<ToDoResponse> UpdateAsync(int Id, UpdateToDo entity);
        Task<ToDoResponse> DeleteAsync(int Id);
    }
}
