using System;
using System.Runtime.Serialization;

namespace SMS.DomainEntites.Entities
{
    [Serializable]
    [DataContract]
    public class Requester
    {
        [DataMember]
        public string RequestSeriesNo { get; set; }

        [DataMember]
        public DateTime RequestDate { get; set; }

        [DataMember]
        public string OutletCode { get; set; }

        [DataMember]
        public string RequesterTypeCode { get; set; }

        [DataMember]
        public int CustomerCode { get; set; }

        [DataMember]
        public string LongName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string MiddleInitial { get; set; }

        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string MunicipalCode { get; set; }

        [DataMember]
        public string ProvinceCode { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public double Zip { get; set; }

        [DataMember]
        public double ContactNumber { get; set; }

        [DataMember]
        public string TIN { get; set; }

        [DataMember]
        public int RequestCount { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public double QueueTicketNumber { get; set; }

        [DataMember]
        public double AmountUSD { get; set; }

        [DataMember]
        public string RequesterTypeDescription { get; set; }

        [DataMember]
        public string ProvinceName { get; set; }

        [DataMember]
        public string CityMunicipalName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public DateTime EventDate { get; set; }

        [DataMember]

        public string DocumentType { get; set; }

        [DataMember]
        public string BREQSRefNo { get; set; }

        [DataMember]
        public string BREQSSequenceNo { get; set; }

        [DataMember]
        public string RequestType { get; set; }

        [DataMember]
        public string RequestSubType { get; set; }

        [DataMember]
        public string RequestPurposeCode { get; set; }

        [DataMember]
        public string PurposeParticulars { get; set; }

        [DataMember]
        public int Copies { get; set; }

        [DataMember]
        public string EventMunicipalCode { get; set; }

        [DataMember]
        public string EventProvinceCode { get; set; }

        [DataMember]
        public string EventCountryCode { get; set; }

        [DataMember]
        public string PrimaryLastName { get; set; }

        [DataMember]
        public string PrimaryFirstName { get; set; }

        [DataMember]
        public string PrimaryMiddleName { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public string SecondaryLastName { get; set; }

        [DataMember]
        public string SecondaryFirstName { get; set; }

        [DataMember]
        public string SecondaryMiddleName { get; set; }

        [DataMember]
        public string AuxiliaryLastName { get; set; }

        [DataMember]
        public string AuxiliaryFirstName { get; set; }

        [DataMember]
        public string AuxiliaryMiddleName { get; set; }

        [DataMember]
        public string DelayedDate { get; set; }

        [DataMember]
        public string RegistrationStatus { get; set; }

        [DataMember]
        public string BatchNumber { get; set; }

        [DataMember]
        public string ConversionStatus { get; set; }

        [DataMember]
        public string Reserved { get; set; }
    }
}