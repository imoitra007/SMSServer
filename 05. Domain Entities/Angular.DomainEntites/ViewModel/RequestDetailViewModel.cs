using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.Application.Model.Encoding
{
    public class RequestDetailViewModel 
    {
        public List<RequestSummaryModel> RequestSummary { get; set; }
        public RequesterViewModel RequesterViewModel { get; set; }
    }
}
