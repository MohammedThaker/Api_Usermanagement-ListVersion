using Application.DTOs.ResponseDTO;
using Application.Interfaces.IUserService;
using Domain.Entities;
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.service.UsersService
{
    public class GetUserByIdService : IGetUserByIdService
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public GetUserByIdService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }
        public User GetUser_ById(int userid)
        {
            try
            {
                if (userid <= 0)
                    return null;
                var user = addUnitOfWork.GetUserById.GetByIdi(userid);

                if (user == null)
                    return null;

                return user;

            }
            catch (Exception) { return null; }






        }
    }
}
