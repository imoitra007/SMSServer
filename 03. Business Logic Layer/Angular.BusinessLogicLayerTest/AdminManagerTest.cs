using SMS.BusinessLogicLayer.Interfaces;
using SMS.BusinessLogicLayer.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SMS.BusinessLogicLayerTest
{
    [TestClass]
    public class AdminManagerTest
    {
        private readonly IAdminManager _adminManager = null;

        public AdminManagerTest()
        {
            _adminManager = new AdminManager();
        }

        [TestMethod]
        public void GetAllTeacher()
        {
            var result = _adminManager.GetAllTeacher(null, true);
            if (result != null)
                Assert.IsNotNull(result);
            else
                Assert.IsNull(result);
        }
    }
}
