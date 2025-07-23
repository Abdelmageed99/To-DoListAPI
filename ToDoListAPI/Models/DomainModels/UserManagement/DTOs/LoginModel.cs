using Azure.Identity;

namespace ToDoListAPI.Models.DomainModels.UserManagement.DTO
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
