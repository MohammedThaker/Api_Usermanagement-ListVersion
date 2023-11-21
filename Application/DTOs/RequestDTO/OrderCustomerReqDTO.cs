using Application.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.RequestDTO
{
    public class OrderCustomerReqDTO : UserDTO
    {
        public string? OrderNo { get; set; }
        public string? OrderName { get; set; }
        public int CustomerID { get; set; }

        public CustomerRequestDTO Customer { get; set; }


        /*public string isvalid()
        {
            if (OrderNo == null)
                return "Customer is required";
            if (CustomerID >= 0)
                return "Customer is required";

            return base.ToString();
        }*/
    }
}
