using System;
using System.Linq;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserRepository userRepository = new UserRepository(new CompanyContext());
            var User = userRepository.Get(x => x.UserId == 1);
            Assert.AreEqual("Dmitry", User.First().FirstName);
        }
    }
}
