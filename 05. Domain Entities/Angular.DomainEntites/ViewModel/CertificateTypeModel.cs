using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DomainEntites.ViewModel
{
    public class CertificateTypeModel : BaseModel
    {
        public string Type { get; set; }
        public string SubType { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public double Rate { get; set; }

    }
}
