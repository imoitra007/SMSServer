using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.Application.Model.Encoding
{
    public class EncodingMvSearchModel : IDisposable
    {
        public int Id { get; set; }
        public int SearchFiledId { get; set;  }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
