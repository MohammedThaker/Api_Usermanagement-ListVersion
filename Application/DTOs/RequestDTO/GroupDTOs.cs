using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.RequestDTO
{
    public class GroupDTOs
    {
        
            public string? GroupName { get; set; }
      
        public new string IsValid()
        {
            if (string.IsNullOrWhiteSpace(GroupName))
                return "Enter Permission Type  ";

            return base.ToString();
        }

    }
}
