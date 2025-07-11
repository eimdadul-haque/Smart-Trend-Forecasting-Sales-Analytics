using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using STFSA.Application.Auth.DTOs;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> register([FromBody] RegisterDto input)
        {
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> login([FromBody] LoginDto input)
        {
            return Ok(new { Token = "dummy_token" });
        }
    }
}
