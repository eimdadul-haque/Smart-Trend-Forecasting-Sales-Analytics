using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using STFSA.Application.Auth.DTOs;
using STFSA.Application.Auth.Interfaces;
using STFSA.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace STFSA.Application.Auth.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
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
            var user = await _userManager
                .FindByEmailAsync(input.Email);

            if (user is null)
                throw new UnauthorizedAccessException("User not found.");

            var result = await _signInManager
                .PasswordSignInAsync(user.UserName, input.Password, input.RememberMe, false);

            if (result.Succeeded)
            {
                return GenerateJwtToken(user.Email);
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid login attempt.");
            }
        }

        private string GenerateJwtToken(string email)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII
                .GetBytes(_configuration["JWT:IssuerSigningKey"]));

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
