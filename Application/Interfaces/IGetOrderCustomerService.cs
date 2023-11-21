using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGetOrderCustomerService
    {
   public List<OrderCusts> GetALLOrderByCustomerID(int CustomerId);
     //  public OrderCusts GetOrderCus();
    }
}
