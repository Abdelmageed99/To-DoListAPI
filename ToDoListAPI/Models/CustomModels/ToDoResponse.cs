using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoModel;

namespace ToDoListAPI.Models.CustomModels
{
    public class ToDoResponse
    {
        public bool OperationIsDone { get; set; }
        public List<ToDoItem>? Items { get; set; }   

       
    }
}
