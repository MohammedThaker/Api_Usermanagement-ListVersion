using Application.DTOs.RequestDTO;
using Application.DTOs.ResponseDTO;
using Application.Interfaces;
using Domain.IRepository;
using Domain.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/CusomerOrder")]
    [ApiController]
    public class OrderCustomerController : ControllerBase
    {
        public readonly IBaseUnitOftWork unitOftWork;
        public readonly ICreateOrderCustomerSerivce orderCusts;
        public readonly IGetOrderCustomerService orderCustomerService;

        public OrderCustomerController(IBaseUnitOftWork unitOftWork, ICreateOrderCustomerSerivce orderCusts, IGetOrderCustomerService orderCustomerService)
        {
            this.unitOftWork = unitOftWork;
            this.orderCusts = orderCusts;
            this.orderCustomerService = orderCustomerService;
        }

        [HttpGet]
            public IActionResult GetOrder()
            {
            try
            {
                var Custpay = unitOftWork.GetAllOrderB.GetAll();

                if (Custpay == null)
                    return NotFound(" Invalid Order Id");
                return Ok(Custpay);
            }

            catch (Exception ex)
            {
                return NotFound(" Invalid Order");

            }

        }



        [HttpGet("{Id}")]
        public IActionResult GetOrderById(int Id)
        {
            try
            {
               
                var Cust = orderCustomerService.GetALLOrderByCustomerID(Id);

              /*  var order = new OrderCustomerResponseDTOs
                {
                    OrderName = Cust.OrderName,
                    Customer = new CustomerResponseDTO
                    {
                        CustomerID = Cust.CustomerID,
                        CustomerName = Cust.Customer.CustomerName
                    },
                    CustomerID = Cust.CustomerID,
                    OrderNo = Cust.OrderNo
                };

*/
                return Ok(Cust);

           }
         catch (Exception ex)
           {
                return NotFound("Invalid Order");
             
           }

       }

       [HttpPost]
           public IActionResult Setorder([FromBody] OrderCustomerReqDTO NewOrder)
           {

                var OrderCusts = new OrderCusts
                {
                    OrderName = NewOrder.OrderName,
                    OrderNo = NewOrder.OrderNo,

                    CustomerID = NewOrder.CustomerID,

                };

            if (NewOrder.CustomerID <= 0)
                return NotFound("يرجى ادخال رقم العميل");
           

            orderCusts.CreateOrder(OrderCusts, NewOrder.CustomerID);
                return Ok(NewOrder);


            }







        }
    }
