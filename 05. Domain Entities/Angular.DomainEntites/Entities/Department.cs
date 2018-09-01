using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DomainEntites
{
    [DataContract]
    public class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }

        [DataMember]
        public int DepartmentId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual ICollection<Employee> Employees { get; set; }


    }
}
