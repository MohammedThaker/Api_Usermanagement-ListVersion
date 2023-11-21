using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ResponseDTO
{
    public class RESRoleDTOs
    {
        public int IdRole { get; set; }

        public string? RoleName { get; set; }
        public string Description { get; set; }

        public ICollection<UserResponseDTOs> user { get; set; }
        public ICollection<Repo_PermissionDTOs> Permission { get; set; }



    }
}
