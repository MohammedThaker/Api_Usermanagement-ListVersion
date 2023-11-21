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
    public class GetAllUserSerivce : IGetAllUserSerivce
    {

        public readonly IBaseUnitOftWork addUnitOfWork;


        public GetAllUserSerivce(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }

        public List<User> GetUser_All()
        {
            try
            {
                var user = addUnitOfWork.GetAllUser.GetAll().ToList();


                if (user == null)
                    return null;

                else return user;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
