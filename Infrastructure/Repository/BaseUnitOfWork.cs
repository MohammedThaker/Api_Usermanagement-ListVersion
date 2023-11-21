using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;
using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class BaseUnitOfWork : IBaseUnitOftWork
    {
        protected LibraryDBContext dBContext;
  
        public IGetRepository<ProductOrder> GetAllOrder { get; private set; }
        public IDeleteRepository<ProductOrder> DeleteOrder { get; private set; }
        public IUpdateRepository<ProductOrder> UpdateOrder { get; private set; }
        


        public IAddRepository AddOrderCusts { get; private set; }
        public IGetRepositoryById GetOrderByCustomerById { get; private set; }

        public IGetRepository<OrderCusts> GetAllOrderB { get; private set; }

        public BaseUnitOfWork(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
         
          
            GetAllOrder = new GetAllRepository<ProductOrder>(dBContext);
            UpdateOrder = new UpdateRepository<ProductOrder>(dBContext);
            DeleteOrder = new DeleteRepository<ProductOrder>(dBContext);
            AddOrderCusts = new AddRepository(dBContext);
            GetOrderByCustomerById = new GetRepository(dBContext);
            GetAllOrderB = new GetAllRepository<OrderCusts>(dBContext);
        }



        public int Complete()
        {
            return dBContext.SaveChanges();
        }

        public void Dispose()
        {
            dBContext.Dispose();
        }
    }
}