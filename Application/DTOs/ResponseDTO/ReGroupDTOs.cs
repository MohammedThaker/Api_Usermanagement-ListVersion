using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ResponseDTO
{
    public class ReGroupDTOs
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<UserResponseDTOs> Users { get; set; }

    }
}
