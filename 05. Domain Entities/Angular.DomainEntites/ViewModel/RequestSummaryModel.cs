using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DomainEntites.ViewModel;

namespace Unisys.Application.Model.Encoding
{
    public class RequestSummaryModel : BaseModel
    {
        public int Id { get; set; }
        public string CertificateType { get; set; }
        public string DocumentOwnerName { get; set; }
        public int NoOfCopy { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public int ReferenceNumber { get; set; }
        public string Sex { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string RequestPurpose { get; set; }
        public string PurposeCountry { get; set; }
        public string OtherPurpose { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }
        public int RequesterId { get; set; }
        public RequesterModel RequesterDetail { get; set; }

       
    }
}


