using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ToDoListAPI.Helpers.GeneralResponse;
using ToDoListAPI.Models.CustomModels;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoDTO;
using ToDoListAPI.Models.DomainModels.ToDoManagement.ToDoModel;
using ToDoListAPI.Services.ToDoService;

namespace ToDoListAPI.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    [Authorize]
    public class ToDoController : ControllerBase
    {
        
         private readonly ITODoService _toDoService;

        public ToDoController(ITODoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet("GetAll")]
       
        public async Task<ActionResult<ApiResponse<ToDoResponse>>> GetPagedAsync(int PageNumber, int PageSize)
        {
            var result =  await _toDoService.GetPagedAsync(PageNumber, PageSize);
            if(!result.OperationIsDone)
            {
                return BadRequest(ApiResponse<ToDoResponse>.Failure("No items found"));
            }
            return Ok(ApiResponse<ToDoResponse>.Success("There're items", result));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ToDoResponse>> GetById(int Id)
        {
            var result = await _toDoService.GetByIdAsync(Id);

            if (!result.OperationIsDone)
            {
                return BadRequest(ApiResponse<ToDoResponse>.Failure("No item found"));
            }
            return Ok(ApiResponse<ToDoResponse>.Success("Item Found", result));
        }


        [HttpPost]
        public async Task<ActionResult<ToDoResponse>> CreateAsync(CreateToDo  createToDo)
        {
            var result = await _toDoService.AddAsync(createToDo);

            if (!result.OperationIsDone)
            {
                return BadRequest(ApiResponse<ToDoResponse>.Failure("Item not created"));
            }
            return Ok(ApiResponse<ToDoResponse>.Success("Item Created", result));

            
        }


        [HttpPut("{Id}")]
        public async Task<ActionResult<ToDoResponse>> UpdateAsync(int Id, UpdateToDo updateToDo)
        {
            var result =  await _toDoService.UpdateAsync(Id, updateToDo);

            if (!result.OperationIsDone)
            {
                return BadRequest(ApiResponse<ToDoResponse>.Failure("Item not updated"));
            }
            return Ok(ApiResponse<ToDoResponse>.Success("Item updated", result));
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult<ToDoResponse>> DeleteAsync(int Id)
        {
            var result =  await _toDoService.DeleteAsync(Id);

            if (!result.OperationIsDone)
            {
                return BadRequest(ApiResponse<ToDoResponse>.Failure("Item not deleted"));
            }
            return Ok(ApiResponse<ToDoResponse>.Success("Item deleted", result));
        }



    }
}
