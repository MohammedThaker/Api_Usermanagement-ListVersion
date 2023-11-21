using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.IRepository;
using Domain.Models;
using Domain.Models.Request;

namespace Application.service
{
    public class GetOrdercustomerService : IGetOrderCustomerService
    {
        public readonly IBaseUnitOftWork addUnitOfWork;
   

        public GetOrdercustomerService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;
        }

        public List<OrderCusts> GetALLOrderByCustomerID(int CustomerId)
        {
            try
            {

                /*   var Customers = dBContext.CustomerOrder.FirstOrDefault(c => c.CustomerId == CustomerId);
                   var order = dBContext.OrderCus.Where(c => c.CustomerID == Customers.CustomerId).ToList();
                */
                var createorder = addUnitOfWork.GetOrderByCustomerById.GetByIdi(CustomerId);

                return createorder;

            }
            catch (Exception ex) {


                throw  new ApplicationException();
            }

           
        }
      /*  public OrderCusts GetOrderCus(int customer)
        {
            try
            {



                var Customers = dBContext.CustomerOrder.FirstOrDefault(c => c.CustomerId == customer);
                var order = dBContext.OrderCus.FirstOrDefault(c => c.CustomerID == Customers.CustomerId);
            
                
                if (order.CustomerID == null)
                {
                    return null;
                }
                
                
       return order;
            }
            catch (Exception ex)
            {

                return null;    
            }

        }*/
    }
}
