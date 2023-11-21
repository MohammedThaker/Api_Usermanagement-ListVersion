
using Application.Interfaces.IUserService;
using Application.service;
using Domain.IRepository;
using Moq;
using Test_UserManagement;
using WebApi.Controllers;
using Xunit;
namespace TestProject1.Tast_Repository
{
    public class TastUserController : Models
    {
        public readonly Mock<IGetUserByIdService> mock;
        public readonly Mock<ICreateUserService> mockcreate;
        public TastUserController()
        {
            mock = new Mock<IGetUserByIdService>();
            mockcreate = new Mock<ICreateUserService>();
        }


        [Fact]
            public void Test_GET_Shuold_call_Repository_GetByID()
            {
                //Arrange
                int id = 22;
                mock.Setup(u => u.GetUser_ById(id)).Returns(user);
                var userController = new UserManagementController(mock.Object,null,null,null,null,null);

                //Act
                var result = userController.GetUserById(id);

                //Asssert
                mock.Verify(r => r.GetUser_ById(id), Times.Once());
                Assert.NotNull(result);
           // Assert.IsType<userDTOs>(result);
              


            

        }


        [Fact]
       
       
        public void Test_Post_Shuold_call_Repository_PostData()

        {
            //Arrange
          
            mockcreate.Setup(u => u.CreateUser(user)).Returns(true);
            var userController = new UserManagementController( null, null, mockcreate.Object, null, null, null);

            //Act
           var result = userController.PostUser(user);

            //Asssert
           Assert.NotNull(result);




        }

    }
}
