using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.RequestDTO
{
    public class UserRole
    {
        public UserDTOs User { get; set; }
        public RESRoleDTOs Roles { get; set; } 
    }
}
