using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Token
    {
        public int TokenId { get; set; }
        public string? TokenName { get; set; }
        public string? TokenValue { get; set; }
        public User User { get; set; }
    }
}
