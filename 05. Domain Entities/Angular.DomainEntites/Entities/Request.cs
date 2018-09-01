using System;
using System.Runtime.Serialization;

namespace SMS.DomainEntites.Entities
{

    [Serializable]
    [DataContract]
    public class Request:BaseEntity
    {
        [DataMember]
        public string SeriesNo { get; set; }

        [DataMember]
        public int SequenceNo { get; set; }

        [DataMember]
        public string OutletCode { get; set; }

        [DataMember]
        public DateTime RequestDate { get; set; }

        [DataMember]
        public string KioskReferenceNo { get; set; }

        [DataMember]
        public float WebReferenceNo { get; set; }

        [DataMember]
        public string RequestType { get; set; }

        [DataMember]
        public string RequestSubType { get; set; }

        [DataMember]
        public string DocumentType { get; set; }

        [DataMember]
        public string DocumentSubType { get; set; }

        [DataMember]
        public string RequestSource { get; set; }

        [DataMember]
        public DateTime RegistrationDate { get; set; }

        [DataMember]
        public string RegistrationStatus { get; set; }

        [DataMember]
        public string RequestStatusCode { get; set; }

        [DataMember]
        public string ReferenceRequestNumber { get; set; }

        [DataMember]
        public string RequestPurposeCode { get; set; }

        [DataMember]
        public string PurposeParticular { get; set; }

        [DataMember]
        public string RelationshipType { get; set; }

        [DataMember]
        public string ResultTypeCode { get; set; }

        [DataMember]
        public int Copies { get; set; }

        [DataMember]
        public double BaseAmount { get; set; }

        [DataMember]
        public double Cost { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public double AmountUsd { get; set; }

        [DataMember]
        public string Crn { get; set; }

        [DataMember]
        public string ReN { get; set; }

        [DataMember]
        public DateTime EventDate { get; set; }

        [DataMember]
        public string MunicipalCode { get; set; }

        [DataMember]
        public string ProvinceCode { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public string PriLastName { get; set; }

        [DataMember]
        public string PriFirstName { get; set; }

        [DataMember]
        public string PriMiddleName { get; set; }

        [DataMember]
        public string PriGender { get; set; }

        [DataMember]
        public string PriTin { get; set; }

        [DataMember]
        public string SecLastName { get; set; }

        [DataMember]
        public string SecFirstName { get; set; }

        [DataMember]
        public string SecMiddleName { get; set; }

        [DataMember]
        public string SecTin { get; set; }

        [DataMember]
        public string AuxLastName { get; set; }

        [DataMember]
        public string AuxFirstName { get; set; }

        [DataMember]
        public string AuxMiddleName { get; set; }

        //[DataMember]
        //public string ReworkReason { get; set; }
        [DataMember]
        public string Courier { get; set; }

        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        public string PaymentId { get; set; }

        [DataMember]
        public string ImageId { get; set; }

        [DataMember]
        public string DocumentFlag { get; set; }

        [DataMember]
        public char ConversionFlag { get; set; }

        [DataMember]
        public string Etr { get; set; }

        [DataMember]
        public string NumSecpa { get; set; }

        [DataMember]
        public string NoOfPage { get; set; }

        [DataMember]
        public DateTime TimeStart { get; set; }

        [DataMember]
        public DateTime TimeEnd { get; set; }

        [DataMember]
        public string PaymentStatusCode { get; set; }

        [DataMember]
        public string RequestTypeDescription { get; set; }


        [DataMember]
        public string RequestStatusCodeDescription { get; set; }

        [DataMember]
        public string RequestPurposeDescription { get; set; }

        [DataMember]
        public string CityMunicipalName { get; set; }

        [DataMember]
        public string ProvinceName { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public string RequestTypeCode { get; set; }

        [DataMember]
        public string TransactionNumber { get; set; }

        [DataMember]
        public string FormattedTransactionNumber { get; set; }

        [DataMember]
        public string Documents { get; set; }

        [DataMember]
        public string AuthenticationdocumentImageData { get; set; }

        //[DataMember]
        //public DocumentImageModel documentImageModel { get; set; }

        [DataMember]
        public string FileNameDetail { get; set; }

        [DataMember]
        public int AuthDocImageId { get; set; }

        //[DataMember]
        //public CDLIRequirement[] lstCDLIRequirement { get; set; }
    }
}