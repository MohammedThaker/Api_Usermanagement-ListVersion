using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class CustomerOrder: Domain.Models.Base.Base
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }       
      //  public List<OrderCusts> orders { get; set; }
        public string isvalid()
        {
            if (CustomerId == null)
                return "Customer is required";
            if (CustomerName == null)
                return "Customer is required";
           
            return base.ToString();
        }
    }
}
