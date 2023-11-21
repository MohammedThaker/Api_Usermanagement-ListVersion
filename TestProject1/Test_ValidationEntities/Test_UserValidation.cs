using Application.Interfaces.IUserService;
using Application.service.UsersService;
using Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1.Test_ValidationEntities
{
    public class Test_UserValidation
    {
        [Theory]
        [InlineData("m@m.com")]
        public void Teat_validatiion_Emaile(string defauitEmail)
        {
            //Arrange
            var userMock = new Mock<IUserService>();



            //act

            userMock.Setup(user => user.Email).Returns(defauitEmail);
            IUserService mock = userMock.Object;
            var result_value = mock.Email;

            //Assert
            Assert.Matches(@"^[a-z0-9._%+-]+@[a-z]+\.[a-z]{2,}$", result_value);

        }
        [Theory]
        [InlineData("771159921")]
        public void Teat_validatiion_phone(string defauitphone)
        {
            //Arrange
            var userMock = new Mock<User>();



            //act

            userMock.Setup(user => user.Phone).Returns(defauitphone);
            User mock = userMock.Object;
            var result_value = mock.Phone;

            //Assert
            Assert.Matches(@"^[a-z0-9._%+-]+@[a-z]+\.[a-z]{2,}$", result_value);

        }
    }
}
