using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoModel;
using ToDoListAPI.Models.DomainModels.UserManagement.UserModel;

namespace ToDoListAPI.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public DbSet<ToDoItem> toDoItems {  get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
    }
}
