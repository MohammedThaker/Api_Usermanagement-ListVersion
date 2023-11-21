using Application.DTOs.RequestDTO;
using Application.Interfaces.IRoleService;
using Domain.IRepository;

using Domain.Entities;


namespace Application.service.RoleSerivce
{
    public class CreateRoleService : ICreateRoleService
    {
        public readonly IBaseUnitOftWork addUnitOfWork;
      

        public CreateRoleService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;
        
        }

        public bool CreateRole(Role role)

        {
            try
            {


            if (String.IsNullOrEmpty(role.RoleName))
                {
               return false;
                }
                if (String.IsNullOrEmpty(role.Description))
                {
                    return false;
                }
              
                  
                var createorder= addUnitOfWork.AddRole.Add(role);
         
                addUnitOfWork.Complete();
                return true;
            }
            catch (Exception )
            {

                return false;
            }
        }

   
    }
}
