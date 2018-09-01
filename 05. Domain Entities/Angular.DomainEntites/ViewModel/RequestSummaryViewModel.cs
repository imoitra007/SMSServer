using System.Collections.Generic;
using SMS.DomainEntites.ViewModel;

namespace Unisys.Application.Model.Encoding
{
    public class RequestSummaryViewModel : BaseModel
    {
       public IEnumerable<RequestSummaryModel> RequestSummary { get; set; }
       public IEnumerable<RequesterModel> RequesterDetail { get; set; }
       public IEnumerable<RequesterViewModel> RequesterViewModel { get; set; }
    }
}
