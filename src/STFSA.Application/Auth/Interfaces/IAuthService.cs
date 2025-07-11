using STFSA.Application.Auth.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.Auth.Interfaces
{
    public interface IAuthService
    {
        Task<bool> register(RegisterDto input);
        Task<string> login(LoginDto input);
    }
}
