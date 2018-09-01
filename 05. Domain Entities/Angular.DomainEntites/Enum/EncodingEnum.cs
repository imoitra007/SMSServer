using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DomainEntites.Enum
{
   public  class EncodingEnum
    {
        public enum MvSearchField
        {
            RequestNumber = 1,
            KisoskId,
            CrsWebSiteReferenceNumber,
            DocumentOwnerName
        };

        public enum RequesterTypes
        {
            PsaEmployee = 7,
            Public
        };

        public enum RequestStatus
        {

            Cancelled = 1,
            ForIndexCorrection,
            ForManualProcessing,
            ForRSOProcessing,
            InProcessIC,
            InProcessMV,
            InProcess,
            Processed,
            Paid,
            Temporary,
            WaitingForPayment,
            ForSupervisorProcessing,
            ForManualVerification,
            Released,
            ReadyforReleased

        };

        public enum CertificateType
        {
            COPYISSUANCEBIRTHCERTIFICATE = 1,
            COPYISSUANCEDEATHCERTIFICATE = 2,
            COPYISSUANCEMARRIAGECERTIFICATE = 3,
            CENOMAR = 4,
            CENODEATH = 5,
            AUTHENTICATIONBIRTHCERTIFICATE = 6,
            AUTHENTICATIONDEATHCERTIFICATE = 7,
            AUTHENTICATIONMARRIAGECERTIFICATE = 8,
            VIEWABLEONLINEBIRTHCERTIFICATE = 9,
            VIEWABLEONLINEDEATHCERTIFICATE = 10,
            VIEWABLEONLINEMARRIAGECETIFICATE = 11,
            VIEWABLEONLINECENOMAR = 12,
            VIEWABLEONLINECENODEATH = 13,
            DOCPRINTBIRTHCERTIFICATE = 14,
            DOCPRINTDEATHCERTIFICATE = 15,
            DOCPRINTMARRIAGECERTIFICATE = 16,
            DOCPRINTCENOMAR = 17,
            DOCPRINTCENODEATH = 18,
            PREMIUMANNOTATIONBIRTH = 19,
            PREMIUMANNOTATIONDEATH = 20,
            PREMIUMANNOTATIONMARRIAGE = 21,
            REGULARANNOTATIONBIRTH = 22,
            REGULARANNOTATIONDEATH = 23,
            REGULARANNOTATIONMARRIAGE = 24,
            TRANSACTIONVERIFICATION = 25,
            CDLIPROPERCOPYISSUANCEBIRTH = 26,
            CDLIPROPERCOPYISSUANCEDEATH = 27,
            CDLIPROPERCOPYISSUANCEMARRIAG = 28,
            CDLIATTACHMENTCOPYISSUANCEBIRTH = 29,
            CDLIATTACHMENTCOPYISSUANCEDEATH = 30,
            CDLIATTACHMENTCOPYISSUANCEMARRIAGE = 31,
            CDLICOMPLETECOPYISSUANCEBIRTH = 32,
            CDLICOMPLETECOPYISSUANCEDEATH = 33,
            CDLICOMPLETECOPYISSUANCEMARRIAGE = 34
        }
    }
}
