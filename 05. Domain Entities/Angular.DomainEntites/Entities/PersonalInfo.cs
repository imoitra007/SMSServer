using System.Runtime.Serialization;

namespace SMS.DomainEntites.Entities
{
    [DataContract]
    public class PersonalInfo
    {
        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string FatherLastName { get; set; }

        [DataMember]
        public string FatherFirstName { get; set; }

        [DataMember]
        public string FatherMiddleName { get; set; }

        [DataMember]
        public string MotherLastName { get; set; }

        [DataMember]
        public string MotherFirstName { get; set; }

        [DataMember]
        public string MotherMiddleName { get; set; }

    }
}
