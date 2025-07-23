using Microsoft.EntityFrameworkCore;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoValidation;

namespace ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoModel
{
    [EntityTypeConfiguration(typeof(ToDoConfiguration))]
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }

}
