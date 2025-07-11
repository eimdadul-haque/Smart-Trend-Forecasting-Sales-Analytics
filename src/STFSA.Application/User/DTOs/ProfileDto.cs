using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.User.DTOs
{
    public class ProfileDto
    {
        public int Id { get; set; }

        public string Name { get; set; } 

        public string Email { get; set; } 

        public string PhoneNumber { get; set; } 

        public string Address { get; set; } 

        public string? ProfilePictureUrl { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? Bio { get; set; }

    }
}
