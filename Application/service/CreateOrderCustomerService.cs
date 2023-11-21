using Application.DTOs.RequestDTO;
using Application.Interfaces;
using Domain.IRepository;

using Domain.Models.Request;


namespace Application.service
{
    public class CreateOrderCustomerService : ICreateOrderCustomerSerivce
    {
        public readonly IBaseUnitOftWork addUnitOfWork;
      

        public CreateOrderCustomerService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;
        
        }

        public void CreateOrder(OrderCusts Order, int CustomerID)

        {
            try
            {


                if (String.IsNullOrEmpty(Order.OrderNo))
                {
                    base.Equals("the product is empty");
                }
         /*       var Customers = dBContext.CustomerOrder.FirstOrDefault(c => c.CustomerId == CustomerID);
            Order.CustomerID = CustomerID;*/
            /*  OrderCusts.Customer = Customers;*/

            var OrderCusts = new OrderCusts
            {
                OrderName = Order.OrderName,
                OrderNo = Order.OrderNo,
              
                CustomerID=Order.CustomerID,
               
            };





            var createorder= addUnitOfWork.AddOrderCusts.Add(Order, CustomerID);
            addUnitOfWork.Complete();
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }
    }
}
