using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRoleService
{
    public interface IDeleteRoleServiceById
    {
        public bool RemoveById(int roleId);
    }
}
