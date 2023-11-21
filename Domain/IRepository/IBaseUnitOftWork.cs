using Domain.Models.Request;
namespace Domain.IRepository
{
    public interface IBaseUnitOftWork : IDisposable
    {
        IGetRepository<ProductOrder> GetAllOrder { get; }

        IDeleteRepository<ProductOrder> DeleteOrder { get; }

        IUpdateRepository<ProductOrder> UpdateOrder { get; }
        IAddRepository AddOrderCusts { get; }
        IGetRepositoryById GetOrderByCustomerById { get; }
        IGetRepository<OrderCusts> GetAllOrderB { get; }
        int Complete();
     
      
    }
    
}
