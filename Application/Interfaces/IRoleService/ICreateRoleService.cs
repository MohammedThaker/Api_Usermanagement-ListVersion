
using Application.DTOs.RequestDTO;
using Domain.Entities;

namespace Application.Interfaces.IRoleService
{
    public interface ICreateRoleService
    {
   public bool CreateRole(Role role);
 
    }
}
