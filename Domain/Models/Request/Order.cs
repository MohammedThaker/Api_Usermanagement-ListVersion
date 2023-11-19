﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Request
{
    public class Order
    {
        [Key]
        public int Orderid { get; set; }
        [Required]
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [Required]
        public DateTime DateOrder { get; set; }
        public DateTime Datecreate { get; set; }
      /*  public string IsValid()
        {
            if (string.IsNullOrWhiteSpace(OrderNo))
                return "Name is Required";

            if (OrderNo == null)
                return "Customer Id Required";
            return base.ToString();
        }*/

    }
}

