using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
    
        public string? RoleName { get; set; }
        public string Description { get; set; }

        public ICollection<User> user { get; set;}
        public ICollection<Permission> Permission { get; set; }
        public new string IsValid()
        {
            if (string.IsNullOrWhiteSpace(RoleName))
                return "يرجى ادخال اسم الرول  ";
            if (string.IsNullOrWhiteSpace(Description))
                return "يرجى ادخال وصف  ";
            return base.ToString();
        }

    }
}
