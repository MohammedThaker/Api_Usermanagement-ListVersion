using Application.Interfaces.IRoleService;
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.service.RoleSerivce
{
    public class DeleteRoleServiceById : IDeleteRoleServiceById
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public DeleteRoleServiceById(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }
        public bool RemoveById(int roleId)
        {
            try
            {

                if (roleId <= 0)
                    return false; 

                var createorder = addUnitOfWork.DeleteRole.RemoveById(roleId);

                addUnitOfWork.Complete();
                return true;
            }
            catch (Exception )
            {

                return true;
            }
        }
    }
}
