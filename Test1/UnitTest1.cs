using System.Linq;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.Repositories;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace HiQo.StaffManagement.DAL.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            UserRepository userRepository = new UserRepository(new CompanyContext());
            var User = userRepository.Get(x => x.UserId == 1);
            Assert.AreEqual("Dmitry", User.First().FirstName);
        }
    }
}
