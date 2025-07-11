using STFSA.Application.User.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.User.Interfaces
{
    public interface IUserService
    {
        Task<ProfileDto> GetCurrentUserInfo();
        Task<ProfileDto> UpdateProfileInfo(ProfileDto input);
        Task<List<ProfileDto>> GetAllUsers();
        Task<ProfileDto> ChangeUserRole(int id, string newRole);
    }
}
