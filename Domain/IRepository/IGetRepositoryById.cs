using Domain.Models.Request;
using System;


namespace Domain.IRepository
{
    public interface  IGetRepositoryById
    {
        public List<OrderCusts> GetByIdi(int CustomerId);

   

    }
}
