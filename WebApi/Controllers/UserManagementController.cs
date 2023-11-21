using Application.DTOs.RequestDTO;
using Application.DTOs.ResponseDTO;
using Application.Interfaces;
using Application.Interfaces.IUserService;
using Domain.Entities;
using Domain.IRepository;
using Domain.Models.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/UserMangement")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        public readonly IGetUserByIdService getUserByIdService;
        public readonly IGetAllUserSerivce getAllUserSerivce;
        public readonly ICreateUserService createUserSerivce;
        public readonly IUpdateUserService  updateUserService;
        public readonly IDeleteUserServiceById deleteUserServiceById;
        public readonly IBaseUnitOftWork addUnitOfWork;
        public UserManagementController(IGetUserByIdService getUserByIdService, 
            IGetAllUserSerivce getAllUserSerivce, ICreateUserService createUserSerivce, 
            IUpdateUserService updateUserService,
            IDeleteUserServiceById deleteUserServiceById, IBaseUnitOftWork addUnitOfWork)
        {
            this.getUserByIdService = getUserByIdService;
            this.getAllUserSerivce = getAllUserSerivce;
            this.createUserSerivce = createUserSerivce;
            this.updateUserService = updateUserService;
            this.deleteUserServiceById = deleteUserServiceById;
            this.addUnitOfWork=addUnitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
              
                var Users = getAllUserSerivce.GetUser_All();
                var UserDTOs = new List<UserResponseDTOs>();

                foreach (var UserDTO in UserDTOs)
                    UserDTOs.Add(new UserResponseDTOs
                    {
                        UserId = UserDTO.UserId,
                        Name = UserDTO.Name,
                        Phone = UserDTO.Phone,
                        Email = UserDTO.Email,
                    });
               
                return Ok(Users);
            }

            catch (Exception)
            {
                return NotFound(" لا يوجد بيانات ");

            }

        }



        [HttpGet("{Id}")]
        public IActionResult GetUserById(int Id)
        {
            try
            {

                var User = getUserByIdService.GetUser_ById(Id);
                if (User != null)
                {
                    var UserDTOs = new UserDTOs
                    {
                        Phone = User.Phone,
                        UserName = User.Name,
                        UserEmail = User.Email,


                    };


                   

                    return Ok(UserDTOs);
                }
                return NotFound(" Invalid User Id");

            }
            catch (Exception )
            {
                return NotFound("Invalid User");

            }

        }

        [HttpPost]
        public IActionResult PostUser([FromBody] UserDTOs NewUser)
        {


            try
            {
               

                string IsValid = NewUser.IsValid();
                if (!string.IsNullOrEmpty(IsValid))
                {


                    return NotFound(IsValid);

                }

                else
                {
                    var user = new User
                    {
                        Name = NewUser.UserName,
                        Email = NewUser.UserEmail,
                        Phone = NewUser.Phone,
                        Address = NewUser.Address,
                        Password = NewUser.Password,

                    };
                  createUserSerivce.CreateUser(user);

                    return Ok("تم الاضافة");

                };

                

            }
            catch (Exception)
            {
                return NotFound(" لم يتم الاضافة");

            }
            
            
            }







    }
}
