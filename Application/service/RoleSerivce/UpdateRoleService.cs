using Application.DTOs.RequestDTO;
using Application.Interfaces.IRoleService;
using Domain.IRepository;

using Domain.Entities;
namespace Application.service.RoleSerivce
{
    public class UpdateRoleService: IUpdateRoleService
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public UpdateRoleService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }
        public string Update_Role(Role role)
        {
            try
            {


                if (String.IsNullOrEmpty(role.RoleName))
                {
                    return "Enter to update Role Name";
                }
                if (String.IsNullOrEmpty(role.Description))
                {
                    return "error to update Role Description";
                }
                
             

                var createorder = addUnitOfWork.UpdateRole.Update(role);

                addUnitOfWork.Complete();
                return   "Updated user";
            }
            catch (Exception )
            {

                return "Erorr to update";
            }
        }
    }
}
