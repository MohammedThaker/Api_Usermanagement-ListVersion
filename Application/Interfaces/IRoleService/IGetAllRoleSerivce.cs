using Application.DTOs.ResponseDTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRoleService
{
    public interface IGetAllRoleSerivce
    {
        public List<Role> GetRole_All();

    }
}
