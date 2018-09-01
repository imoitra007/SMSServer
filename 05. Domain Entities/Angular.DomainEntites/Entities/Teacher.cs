using System.Runtime.Serialization;

namespace SMS.DomainEntites.Entities
{

    // This is the base class
    [DataContract]
    public class Teacher : BaseEntity
    {
        [DataMember]
        public PersonalInfo personalInfo { get; set; }

        [DataMember]
        public AddressInfo addressInfo { get; set; }
    }
}
