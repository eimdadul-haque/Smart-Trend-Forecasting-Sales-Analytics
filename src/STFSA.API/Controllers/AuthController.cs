using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;
using STFSA.Application.Auth.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/auth")]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto input)
        {
            return Ok();
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

