using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.RequestDTO
{
    public class OrderCustomerResponseDTOs
    {
       
        

        public string? OrderNo { get; set; }
        public string? OrderName { get; set; }
        public int CustomerID { get; set; }

        public CustomerResponseDTO Customer { get; set; }
    }
}
