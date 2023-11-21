using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserLogin
    {
        public string LoginProvider { get; set; }
        public int Userid { get; set; }
        public User User { get; set; }
           


    }

    
}
