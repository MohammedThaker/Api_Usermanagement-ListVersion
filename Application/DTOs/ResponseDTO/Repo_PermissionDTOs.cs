using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ResponseDTO
{
    public class Repo_PermissionDTOs
    {
        public int Id { get; set; }
        public string PermissionType { get; set; }
        public string PermissionModule { get; set; }
        public int RoleID { get; set; }
        public RESRoleDTOs Role { get; set; }

    }
}
