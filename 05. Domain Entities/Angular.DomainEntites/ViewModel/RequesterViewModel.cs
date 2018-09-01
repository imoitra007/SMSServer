using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DomainEntites.ViewModel;

namespace Unisys.Application.Model.Encoding
{
    public class RequesterViewModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName  { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityName { get; set; }
        public int CityId { get; set; }
        public string ProvinceName { get; set; }
        public int ProvinceId { get; set; }
        public string CountryName { get; set; }
        public int CountryId { get; set; }


    }
}
