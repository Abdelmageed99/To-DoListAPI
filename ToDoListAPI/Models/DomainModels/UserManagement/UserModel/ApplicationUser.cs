using Microsoft.AspNetCore.Identity;

namespace ToDoListAPI.Models.DomainModels.UserManagement.UserModel
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
