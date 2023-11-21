using Application.DTOs.RequestDTO;
using Application.DTOs.ResponseDTO;
using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICreateOrderCustomerSerivce
    {
   public void CreateOrder(OrderCusts Order,int CustomerID);

    }
}
