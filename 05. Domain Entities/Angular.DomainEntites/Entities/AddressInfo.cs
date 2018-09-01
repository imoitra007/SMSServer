using System.Runtime.Serialization;

namespace SMS.DomainEntites.Entities
{
    [DataContract]
    public class AddressInfo
    {
        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string Landmark { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string PinCode { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string ContactNumber { get; set; }
    }
}
