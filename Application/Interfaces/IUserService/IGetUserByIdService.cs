using Application.DTOs.ResponseDTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IUserService
{
    public interface IGetUserByIdService
    {
        public User GetUser_ById(int userDTOs);
    }
}
