using DataAccess;
using DataAccess.Repositories.Interfaces;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    [TestFixture]
    class ProfileControllerTests
    {
        private IUserRepository _userRepo;

        [TestFixtureSetUp]
        public void Initialize()
        {
            var mock = new Mock<IUserRepository>();
            mock.Setup(m => m.GetAll())
                .Returns(new[]
                    {
                        new User {Id = 1, Username = "Marian", Password = "jasnePelne"},
                        new User {Id = 2, Username = "Jaro", Password = "fifa2013"}
                    }.AsQueryable());

            _userRepo = mock.Object;
        }

        [Test]
        public void GetAll_ReturnTwoUsers()
        {
            Assert.AreEqual(2, _userRepo.GetAll().Count());
        }
    }
}
