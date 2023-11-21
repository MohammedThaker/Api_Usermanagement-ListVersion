using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.RequestDTO
{
    public class RESRoleDTOs
    {
        [Key]
        public int IdRole { get; set; }
    
        public string? RoleName { get; set; }
        public string? Description { get; set; }

     
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
