using System;
using System.Runtime.Serialization;
using SMS.DomainEntites.ViewModel;

namespace Unisys.Application.Model.Encoding
{

    [DataContract]
    public class DocumentAuditModel: BaseModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Int64 DocumentId { get; set; }

        [DataMember]
        public string ActionPerformed { get; set; }

        [DataMember]
        public int ProcessingUnit { get; set; }

        [DataMember]
        public string Remarks { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public string BusinessUnitName { get; set; }
    }
}
