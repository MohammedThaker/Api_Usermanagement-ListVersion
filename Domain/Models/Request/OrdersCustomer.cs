using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class OrderCusts
    {
        [Key]
        public int Orderid { get; set; }
        public string? OrderNo { get; set; }
        public string? OrderName { get; set; }
        public int CustomerID { get; set; }

        public CustomerOrder Customer { get; set; }  
       /* public string isvalid()
        {
            if (Customer == null)
                return "Customer is required";
            if (CustomerID==null)
                return "Customer is required";

            return base.ToString();
        }*/

    }
}
