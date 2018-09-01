using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccessLayer
{
    public static class StoredProcedure
    {
        #region Administration

        public const string GetAllUser = "sp_GetAllUsers";
        public const string GetUserById = "sp_GetUserById";

        #endregion

        #region Encoding

        public const string GetMvReportInfo = "GetMVReportInfo";
        public const string GetMvRequestById = "GetMvRequestById";
        public const string GetMvRequestWithHistoryById = "GetMvRequestWithHistoryById";
        public const string TestGetTrasactionType = "testGetTrasactionType";
        public const string GetRequestSummaryByQueueNumber = "GetRequestSummaryByQueueNumber";


        public const string AdminUpRequestTypeRetrieve = @"[admin].[up_RequestType_retrieve]";
        #endregion
    }
}
