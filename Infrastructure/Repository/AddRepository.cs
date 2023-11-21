using Domain.IRepository;
using Domain.Models;
using Domain.Models.Request;
using Infrastructure;
using Infrastructure.LibraryDB;
namespace Infrastructure.Interfacies
{
    public class AddRepository : IAddRepository
    {
        protected LibraryDBContext dBContext;

        public AddRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public OrderCusts Add(OrderCusts Order, int CustomerID)
        {
            var Customers = dBContext.CustomerOrder.FirstOrDefault(c => c.CustomerId == CustomerID);
            Order.CustomerID = CustomerID;
            dBContext.Set<OrderCusts>().Add(Order);
            return Order;
        }

      
    }
}
