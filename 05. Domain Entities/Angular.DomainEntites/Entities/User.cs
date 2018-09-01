using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DomainEntites.Entities
{
    [DataContract]
    public class User : BaseEntity
    {

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public  string MiddleName { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
