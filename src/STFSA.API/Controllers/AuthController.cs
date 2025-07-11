using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using STFSA.Application.Auth.DTOs;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
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
