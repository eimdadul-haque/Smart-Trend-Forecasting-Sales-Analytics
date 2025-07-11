using STFSA.Application.User.DTOs;
using STFSA.Application.User.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.User.Services
{
    public class UserService : IUserService
    {
        public async Task<ProfileDto> GetCurrentUserInfo()
        {
            return new ProfileDto();
        }

        public async Task<ProfileDto> UpdateProfileInfo(ProfileDto input)
        {
            return new ProfileDto();
        }

        public async Task<List<ProfileDto>> GetAllUsers()
        {
            return new List<ProfileDto>();
        }

        public async Task<ProfileDto> ChangeUserRole(int id, string newRole)
        {
            return new ProfileDto();
        }
    }
}
