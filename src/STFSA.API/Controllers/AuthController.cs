using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;
using STFSA.Application.Auth.DTOs;
using STFSA.Application.Auth.Interfaces;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(
            IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto input)
        {
            return Ok(await _authService.Register(input));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto input)
        {
            return Ok(new { Token = "dummy_token" });
        }
    }
}


//| Method | Endpoint | Description |
//| ------ | ------------------ | ------------------------------------ |
//| POST | `/ auth / register`   | Register new user                    |
//| POST | `/ auth / login`      | User login(returns JWT) |
//| GET | `/ users / profile`   | Get current user info (JWT required) |
//| PUT    | `/users/profile`   | Update profile info                  |
//| GET    | `/users`           | Get all users (Admin only)           |
//| PUT    | `/users/{id}/ role` | Change user role(Admin only)        |

