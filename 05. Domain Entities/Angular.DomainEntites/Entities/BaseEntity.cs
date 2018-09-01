using System;
using System.Runtime.Serialization;

namespace SMS.DomainEntites.Entities
{

    // This is the base class
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public DateTime ModifiedOn { get; set; }

        [DataMember]
        public string ModifiedBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}
