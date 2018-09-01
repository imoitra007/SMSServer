using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DomainEntites.ViewModel;
using Unisys.Application.Model.Encoding;

namespace SMS.BusinessLogicLayer.Interfaces
{
    public interface IEncodingManager
    {
        //object GetMvReportInfo();
        //object SearchMvRequestWithHistory(int requestId);

        //IEnumerable<object> GetTrasactionType();
        //IEnumerable<RequestDetailViewModel> GetRequestSummaryByQueueNumber(int queueNumber);

        IEnumerable<object> GetRequestType(string outletCode, bool requestTypeOnly = false);
    }
}
;