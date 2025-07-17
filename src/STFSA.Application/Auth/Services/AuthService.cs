using Microsoft.AspNetCore.Identity;
using STFSA.Application.Auth.DTOs;
using STFSA.Application.Auth.Interfaces;
using STFSA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.Auth.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AuthService(
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> Register(RegisterDto input)
        {

            var user = new ApplicationUser
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                Email = input.Email,
                UserName = $"{input.FirstName.ToLower()}_{input.LastName.ToLower()}",
                PhoneNumber = input.PhoneNumber,
                AcceptTerms = input.AcceptTerms
            };

            var result = await _userManager.CreateAsync(user, input.Password);

            if (result.Succeeded)
                return true;
            else
                return false;
        }

        public async Task<string> Login(LoginDto input)
        {
            return "dummy_token";
        }
    }
}
