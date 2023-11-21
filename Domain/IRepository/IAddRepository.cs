
using Domain.Models.Request;

namespace Domain.IRepository
{
    public interface IAddRepository
    { 
       public OrderCusts Add(OrderCusts order, int CustomerID);

    }
}
