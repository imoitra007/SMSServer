using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DomainEntites
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public int DepartmentId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public virtual Department Department { get; set; }

    }
}
