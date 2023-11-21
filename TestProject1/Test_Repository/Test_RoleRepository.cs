using Xunit;
using Moq;
using Domain.IRepository;
using Application.service.RoleSerivce;

using Test_UserManagement;
using Domain.Entities;

namespace TestProject1.Tast_Repository
{
    public class Test_RoleRepository:Models
    {
        
        public readonly Mock<IBaseUnitOftWork> mock;
        public readonly Mock<Role> RoleMoke;
        public Test_RoleRepository()
        {
            mock = new Mock<IBaseUnitOftWork>();
             RoleMoke = new Mock<Role>();
        }
        
        [Fact]
        public void Test_POST_Shuold_call_Repository_AddRole()
        {
            //Arrange

           

            mock.Setup(unit => unit.AddRole.Add(RoleMoke.Object)).Returns(role);
            var roletest = new CreateRoleService(mock.Object);

            //act
            var result = roletest.CreateRole(role);

            //Assert
            Assert.NotNull(result);
            Assert.True(result);

        }

      

        [Fact]
        public void Test_Shuold_call_Repository_GetAllRoles()
        {
            //Arrange

            mock.Setup(unit => unit.GetAllRole.GetAll()).Returns(GetTestRoles);
            var roletest = new GetAllRoleSerivce(mock.Object);

            //Act
            var result = roletest.GetRole_All();

            //Asssert

            mock.Verify(r => r.GetAllRole.GetAll(), Times.Once());
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);

        }

        [Fact]
        public void Test_Update_POST_ReturnsViewResult_UpdateRole()
        {
            //Arrange

            mock.Setup(unit => unit.UpdateRole.Update(RoleMoke.Object)).Returns(role);

            var roletest = new UpdateRoleService(mock.Object);

            //act
            var result = roletest.Update_Role(role);
            Assert.NotNull(result);


        }


        [Theory]
        [InlineData(2)]
        public void Test_Delete_POST_ReturnsViewResult_InValidModelState(int testId)
        {
            // Arrange
          

            mock.Setup(repo => repo.DeleteRole.RemoveById(It.IsAny<int>()))
                   .Returns(role)
                   .Verifiable();

            var roletest = new DeleteRoleServiceById(mock.Object);

            // Act
            var result = roletest.RemoveById(testId);
            Assert.NotNull(result);
            Assert.True(result);
            mock.Verify();
        }

    }
}
