using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string PermissionType { get; set; }
        public string PermissionModule { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }

        public new string IsValid()
        {
            if (string.IsNullOrWhiteSpace(PermissionType))
                return "Enter Permission Type  ";

            if (string.IsNullOrEmpty(PermissionModule))
                return "Enter Permission Module";
            if (RoleID==null)
                return " Enter Role Id   ";
            return base.ToString();
        }

    }
}
