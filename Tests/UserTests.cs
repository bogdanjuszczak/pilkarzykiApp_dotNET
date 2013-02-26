using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;
using DataAccess.Repositories.Interfaces;

namespace Tests
{
    public class UserTests
    {
        public void CreateUserTest()
        {
            var user = new Mock<IUsersRepository>();
            user.Setup(usr => usr.CreateUser("abc", "gffad")).Returns(CreateUserStatus.DuplicatedUsername);

            
        }
    }
}
