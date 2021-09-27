using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Interfaces.AuthService;
using JapTask1BackendCorrection.Core.Requests.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest request)
        {
            var user = new User
            {
                Email = request.Email, 
                FirstName = request.FirstName, 
                LastName = request.LastName 
            };

            var response = await _authService.Register(user, request.Password);

            return (response.Success) ? Ok(response) : BadRequest(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginRequest request)
        {
            var response = await _authService.Login(request.Email, request.Password);

            return (response.Success) ? Ok(response) : BadRequest(response);
        }

    }
}
