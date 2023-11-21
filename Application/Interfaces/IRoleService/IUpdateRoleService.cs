using Application.DTOs.RequestDTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRoleService
{
    public interface IUpdateRoleService
    {
        public string Update_Role(Role Role);
    }
}
