using AutoMapper;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoDTO;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoModel;
using ToDoListAPI.Repository;
using ToDoListAPI.Models.CustomModels;

namespace ToDoListAPI.Services.ToDoService
{
    public class ToDoService : ITODoService
    {
        private readonly IRepository<ToDoItem> _repository;
        private readonly IMapper _mapper;

        public ToDoService(IRepository<ToDoItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ToDoResponse> GetPagedAsync(int PageNumber, int PageSize)
        {
            var responseModel = new ToDoResponse();
            var toDos = await _repository.GetPagedAsync(PageNumber, PageSize);

            if (toDos == null)
            {
                
                return responseModel;
            }

            responseModel.OperationIsDone = true;
            responseModel.Items = toDos;
            return responseModel;


        }

        public async Task<ToDoResponse> GetByIdAsync(int Id)
        {
            var responseModel = new ToDoResponse();
            var toDo = await _repository.GetByIdAsync(Id);

            if (toDo != null)
            {
                responseModel.Items = new List<ToDoItem> { toDo };
              
                responseModel.OperationIsDone = true;

                return responseModel;
            }

            return responseModel;

        }

        public async Task<ToDoResponse> AddAsync(CreateToDo entity)
        {
            var responseModel = new ToDoResponse();

            var toDo = _mapper.Map<ToDoItem>(entity);
            var createdIteme = await _repository.AddAsync(toDo);

            if (createdIteme != null)
            {
                responseModel.Items = new List<ToDoItem> { toDo };
                
                responseModel.OperationIsDone = true;

                return responseModel;
            }

    
            responseModel.OperationIsDone = false;
            return responseModel;
        }

        public async Task<ToDoResponse> DeleteAsync(int Id)
        {
            var responseModel = new ToDoResponse();


            var deletedItem = await _repository.DeleteAsync(Id);

            if (deletedItem != null)
            {
                responseModel.Items = new List<ToDoItem> { deletedItem };
     
                responseModel.OperationIsDone = true;

                return responseModel;
            }

            return responseModel;
        }

        public async Task<ToDoResponse> UpdateAsync(int Id, UpdateToDo entity)
        {
            var responseModel = new ToDoResponse();

            var toDo = _mapper.Map<ToDoItem>(entity);
            var updatedItem = await _repository.UpdateAsync(Id, toDo);

            if (updatedItem != null)
            {
                responseModel.Items = new List<ToDoItem> { updatedItem };
         
                responseModel.OperationIsDone = true;

                return responseModel;
            }

  
            return responseModel;
        }
    }
 

    }

