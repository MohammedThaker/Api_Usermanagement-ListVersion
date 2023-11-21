/*
using Application.DTOs.ResponseDTO;
using Application.Interfaces;

using Domain.IRepository;

using Domain.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IBaseUnitOftWork unitOftWork;
        public readonly IOrderService orderService;

        public OrderController(IBaseUnitOftWork unitOftWork, IOrderService orderService)
        {

            this.unitOftWork = unitOftWork;
            this.orderService = orderService;
        }

       

        [HttpGet]
        public IActionResult GetOrder()
        {
            try
            {
                var Custpay = unitOftWork.GetAllOrder.GetAll();

                if (Custpay == null)
                    return NotFound(" Invalid Order Id");
                return Ok(Custpay);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



        [HttpGet("{Id}")]
        public IActionResult GetOrderById(int Id)
        {

            var Cust = unitOftWork.GetOrderById.GetByIdi(Id);
            if (Cust == null)
                return NotFound(" Invalid Order Id");
            return Ok(Cust);




        }









        [HttpPost]
        public IActionResult Setorder([FromBody] OederResquestDTO NewOrder)
        {

            *//*if (String.IsNullOrEmpty(NewOrder.OrderNo))
            {
                return BadRequest(new { ErrorCode = 400, ErrorMessage = " Invalid Order name" });

            }*//*

            orderService.CreateOrder(NewOrder);

            return Ok(NewOrder);

        }

        [HttpPut("Id")]
        public IActionResult UpdateOrder(int Id, [FromBody] ProductOrder NewOrder)
        {


            var UpdateOrder = unitOftWork.GetOrderById.GetByIdi(Id);

            if (UpdateOrder == null)
                return NotFound($"Movie with Id = {Id} not found");

            UpdateOrder.OrderNo = NewOrder.OrderNo;


            unitOftWork.Complete();
            return Ok(UpdateOrder);
        }
        [HttpDelete("Id")]
        public IActionResult RemoveById(int Id)
        {


            // var Cust = Customers.Where(x => x.CustomerId == NewCustmoer.CustomerId).FirstOrDefault();
            // if (Cust != null) {
            //   return Conflict(new { ErrorCode = 502, ErrorMessage = "Duplicate In customer id" });
            //}RemoveById

            // Customers.Add(NewCustmoer);
            var orderRemove = unitOftWork.GetOrderById.GetByIdi(Id);
            if (orderRemove == null)
                return NotFound(" Not found Order Id");
            unitOftWork.DeleteOrder.RemoveById(orderRemove);
            unitOftWork.Complete();
            return Ok("Removeed Order  ");





        }
    }
}
*/