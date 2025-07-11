using STFSA.Application.Auth.DTOs;
using STFSA.Application.Auth.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.Auth.Services
{
    public class AuthService : IAuthService
    {
        public AuthService()
        {
        }

        public async Task<bool> register(RegisterDto input)
        {
            return true;
        }

        public async Task<string> login(LoginDto input)
        {
            return "dummy_token";
        }
    }
}
