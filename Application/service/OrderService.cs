using Application.Interfaces;
using Application.DTOs.ResponseDTO;
using Domain.Models.Request;
using Domain.IRepository;

namespace Application.service
{
    public class OrderService: IOrderService
    {

        public readonly IBaseUnitOftWork addUnitOfWork;

        public OrderService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;
        }


        public void CreateOrder(OederResquestDTO producrOrder)
        {
            try
            {


                if (String.IsNullOrEmpty(producrOrder.OrderNo))
                {
                    base.Equals("the product is empty");
                }

                var ProducrOrder = new ProductOrder
                {
                    Adresss = producrOrder.Adresss,
                    OrderNo = producrOrder.OrderNo,
                    ProductName = producrOrder.ProductName,


                };
              
            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }

        }







        
    }
}
