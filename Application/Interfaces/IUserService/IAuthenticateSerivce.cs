using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IUserService
{
    public interface IAuthenticateSerivce
    {

        public bool  AuthenticateSerivces(string username, string password);
    }
}
