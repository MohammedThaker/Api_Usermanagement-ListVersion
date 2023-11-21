using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Base
{
    public class Base
    {
        public Task IsValid()
        {
            return Task.CompletedTask;
        }
        
    }
}
