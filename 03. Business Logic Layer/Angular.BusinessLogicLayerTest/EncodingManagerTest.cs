using SMS.BusinessLogicLayer.Implementations;
using SMS.BusinessLogicLayer.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMS.DataAccessLayer.Implementation;
using SMS.DomainEntites.Enum;
using SMS.DomainEntites.ViewModel;

namespace SMS.BusinessLogicLayerTest
{
    [TestClass]
    public class EncodingManagerTest
    {
        private readonly IEncodingManager _encodingManager = null;

        public EncodingManagerTest()
        {
            _encodingManager = new EncodingManager();
        }


        //[TestMethod]
        //public void GetMvReportInfo()
        //{
        //    var listOfUsers = _encodingManager.GetMvReportInfo();
        //    Assert.IsNotNull(listOfUsers);
        //}


        //[TestMethod]
        //public void GetMvRequestWithHistoryById()
        //{
        //    var result = _encodingManager.SearchMvRequestWithHistory(100);
        //    if (result != null)
        //        Assert.IsNotNull(result);
        //    else
        //        Assert.IsNull(result);

        //}

        //[TestMethod]
        //public void GetTrasactionType()
        //{
        //    var result = _encodingManager.GetTrasactionType();
        //    if (result != null)
        //        Assert.IsNotNull(result);
        //    else
        //        Assert.IsNull(result);
        //}

        [TestMethod]
        public void GetRequestTypeTest()
        {
            var result = _encodingManager.GetRequestType("003", false);
            if (result != null)
                Assert.IsNotNull(result);
            else
                Assert.IsNull(result);
        }

    }
}
