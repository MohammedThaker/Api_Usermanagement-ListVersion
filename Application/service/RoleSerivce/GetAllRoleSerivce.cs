using Application.DTOs.ResponseDTO;
using Application.Interfaces.IRoleService;
using Domain.Entities;
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.service.RoleSerivce
{
    public class GetAllRoleSerivce : IGetAllRoleSerivce
    {

        public readonly IBaseUnitOftWork addUnitOfWork;


        public GetAllRoleSerivce(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }

        public List<Role> GetRole_All()
        {
            try
            {
                var roles = addUnitOfWork.GetAllRole.GetAll().ToList();

                if (roles == null)
                    return null;



                return roles;
            }catch (Exception )
            {
                return null;
            }

        }
    }
}
