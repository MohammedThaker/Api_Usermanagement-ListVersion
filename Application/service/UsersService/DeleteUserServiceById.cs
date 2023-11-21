using Application.Interfaces.IUserService;
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.service.UsersService
{
    public class DeleteUserServiceById : IDeleteUserServiceById
    {
        public readonly IBaseUnitOftWork _addUnitOfWork;


        public DeleteUserServiceById(IBaseUnitOftWork addUnitOfWork)
        {
            _addUnitOfWork = addUnitOfWork;

        }
        public bool RemoveById(int UserId)
        {
            try
            {
                if(UserId <= 0)
                    return false;

              //  var createorder = _addUnitOfWork.DeleteUser.RemoveById(UserId);

                ///_addUnitOfWork.Complete();
                return true;
            }
            catch (Exception )
            {

                throw new ApplicationException();
            }
        }
    }
}
