using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using STFSA.Application.User.DTOs;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace STFSA.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        [HttpGet("profile")]
        public async Task<IActionResult> GetCurrentUserInfo() 
        { 
            return Ok(new { message = "User profile information" });
        }

        [HttpPut("profile")]
        public async Task<IActionResult> UpdateProfileInfo([FromBody] ProfileDto input) 
        {
            return Ok(new { message = "Profile updated successfully" });
        }

        [HttpGet("all")]
        [Authorize(Roles ="Ädmin")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(new { message = "List of all users" });
        }

        [HttpPut("{id}/role")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangeUserRole(int id, [FromBody] string newRole)
        {
            return Ok(new { message = $"User role changed to {newRole} for user with ID {id}" });
        }
    }
}

