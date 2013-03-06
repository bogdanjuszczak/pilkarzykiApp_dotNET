using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;
using DataAccess.Repositories.Interfaces;
using DataAccess;
using NUnit.Framework;

namespace Tests
{
    //MethodName_StateUnderTest_ExpectedBehavior
    [TestFixture]
    public class UserTests
    {
        private IEnumerable<User> users;

        [TestFixtureSetUp]
        public void SetUp()
        {
            users = new List<User>();
            users.ToList().Add(new User {Username="test"});
        }


        [Test]
        public void CreateUser_UserExistsInDB_ReturnsDuplicatedUsernameStatus()
        {
            //var userMock = new Mock<IUsersRepository>();
            //userMock.Setup(mock => mock.GetUserByUsername("duplicatedUser")).Returns(new User});

            //var username = "test";
            

            

        }

        public void CreateUserTest()
        {
            var user = new Mock<IUsersRepository>();
            //user.Setup(usr => usr.CreateUser("abc", "gffad")).Returns(CreateUserStatus.DuplicatedUsername);

            
        }
    }
}
