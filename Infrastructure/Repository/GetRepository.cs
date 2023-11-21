using Application.Interfaces;
using Domain.Models;

using Domain.IRepository;
using Infrastructure.LibraryDB; 
using Domain.Models.Request;

namespace Infrastructure.Interfacies
{
    public class GetRepository: IGetRepositoryById
    {
        protected LibraryDBContext dBContext;

        public GetRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

     
        
        public List<OrderCusts> GetByIdi(int CustomerId)
        {
            var Customers = dBContext.CustomerOrder.FirstOrDefault(c => c.CustomerId == CustomerId);
               var order = dBContext.OrderCus.Where(c => c.CustomerID == Customers.CustomerId).ToList();

            return order;
          /*  return dBContext.Set<T>().Find(id);*/
        }
       


    }
}
