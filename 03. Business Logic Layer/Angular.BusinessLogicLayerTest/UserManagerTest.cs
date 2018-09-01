using System;
using SMS.BusinessLogicLayer.Implementations;
using SMS.BusinessLogicLayer.Interfaces;
using SMS.DomainEntites.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMS.BusinessLogicLayerTest
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void GetAllUsersTest()
        {
            IUserManager obj = new UserManager();
            var listOfUsers  = obj.GetAllUsers();
            Assert.IsNotNull(listOfUsers);
        }

        [TestMethod]
        public void GetUserById()
        {
            IUserManager obj = new UserManager();
            User user = obj.GetUserById(4);
            Assert.IsNotNull(user);
        }
    }
}
