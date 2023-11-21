
using Application.Interfaces;
using Domain.IRepository;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IBaseUnitOftWork unitOftWork;
      

        public UserController(IBaseUnitOftWork unitOftWork)
        {
            this.unitOftWork = unitOftWork;
        
          
        }

        [HttpGet]
            public IActionResult Getuser()
            {
            try
            {
                var Custpay = unitOftWork.GetAllUser.GetAll();

                if (Custpay == null)
                    return NotFound(" Invalid  Id");
                return Ok(Custpay);
            }

            catch (Exception ex)
            {
                return NotFound(" Invalid ");

            }

        }









        }
    }
