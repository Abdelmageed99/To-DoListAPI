using AutoMapper;
using ToDoListAPI.Models;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoDTO;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoModel;


namespace ToDoListAPI.Helpers.AutoMapper
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<CreateToDo, ToDoItem>();

            CreateMap<UpdateToDo, ToDoItem>();
                
        }

    }
}
