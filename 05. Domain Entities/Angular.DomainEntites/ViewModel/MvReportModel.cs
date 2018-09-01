using System.Collections.Generic;
using System.Runtime.Serialization;
using SMS.DomainEntites.ViewModel;

namespace Unisys.Application.Model.Encoding
{
    [DataContract]
    public class MvReportModel : BaseModel
    {
        [DataMember]
        public IEnumerable<MvPendingRequestModel> MvPendingRequestModel { get; set; }

        [DataMember]
        public List<MvTagReportModel> MvTagReportModel { get; set; }

        [DataMember]
        public List<MvTagReportModel> MvOverdueTagModel { get; set; }

        [DataMember]
        public List<MvTagReportModel> MvNotMovingTagModel { get; set; }


    }
}
