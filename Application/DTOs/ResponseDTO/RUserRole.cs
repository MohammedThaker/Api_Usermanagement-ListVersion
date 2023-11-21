using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ResponseDTO
{
    public class RUserRole
    {
        public UserResponseDTOs User { get; set; }
        public RESRoleDTOs Roles { get; set; } 
    }
}
