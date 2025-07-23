using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoListAPI.Helpers.GeneralResponse;
using ToDoListAPI.Models.CustomModels;
using ToDoListAPI.Models.DomainModels.UserManagement.DTO;
using ToDoListAPI.Services.AuthService;

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
      
        
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ApiResponse<AuthResponse>>> RegisterAsync(RegisterModel model)
        {
            

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           
            var result = await _authService.RegisterAsync(model);

            if (!result.IsAuthenticated)
            {
                return BadRequest(ApiResponse<AuthResponse>.Failure("Not Created"));
            }
            
       
            return Ok(ApiResponse<AuthResponse>.Success("User Created", result));
            
            
        }

        [HttpPost("Login")]
        public async Task<ActionResult> LoginAsync(LoginModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            var result = await _authService.LoginAsync(model);

            if (!result.IsAuthenticated)
            {
                return BadRequest(ApiResponse<AuthResponse>.Failure("User Not Found"));
            }

            return Ok(ApiResponse<AuthResponse>.Success("User graint access", result));
        }

    }
}
