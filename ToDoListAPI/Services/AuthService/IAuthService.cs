using ToDoListAPI.Models.CustomModels;
using ToDoListAPI.Models.DomainModels.UserManagement.DTO;

namespace ToDoListAPI.Services.AuthService
{
    public interface IAuthService
    {
        Task<AuthResponse> RegisterAsync(RegisterModel model);

        Task<AuthResponse> LoginAsync(LoginModel model);
    }
}
