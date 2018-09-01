using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DomainEntites.ViewModel;

namespace Unisys.Application.Model.Encoding
{
    public class MvRequestWithHistoryModel : BaseModel
    {
        public List<MvRequestModel> MvRequest { get; set; }
        public IEnumerable<DocumentAuditModel> RequestHistory { get; set; }

    }
}
