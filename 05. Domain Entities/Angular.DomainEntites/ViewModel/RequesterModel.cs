using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using SMS.DomainEntites.ViewModel;


namespace Unisys.Application.Model.Encoding
{
    //[Serializable]
    [DataContract]
    public class RequesterModel: BaseModel
    {
        public RequesterModel()
        {
          //  this.Requests = new HashSet<RequestModel>();
        }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
       
        public string LastName { get; set; }

        [DataMember]
       
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public int CityId { get; set; }

        [DataMember]
        public int ProvinceId { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public Int64? ContactNumber { get; set; }

        public int QueueTicketNumber { get; set; }
        
        //[DataMember]
        //public virtual ICollection<RequestModel> Requests { get; set; }

        public string GenerateRequesterXml(int queueTicketNumber, RequesterModel requesterModel)
        {
            XmlDocument xml = new XmlDocument();
            XmlElement root = xml.CreateElement("Requester");
            xml.AppendChild(root);

            XmlElement requesterId = xml.CreateElement("RequesterId");
            requesterId.InnerText = requesterModel.Id.ToString();
            root.AppendChild(requesterId);

            XmlElement queueNumber = xml.CreateElement("QueueNumber");
            queueNumber.InnerText = queueTicketNumber.ToString();
            root.AppendChild(queueNumber);

            XmlElement requesterLastName = xml.CreateElement("RequesterLastName");
            requesterLastName.InnerText = requesterModel.LastName;
            root.AppendChild(requesterLastName);

            XmlElement requesterFirstName = xml.CreateElement("RequesterFirstName");
            requesterFirstName.InnerText = requesterModel.FirstName;
            root.AppendChild(requesterFirstName);

            XmlElement requesterMiddleName = xml.CreateElement("RequesterMiddleName");
            requesterMiddleName.InnerText = requesterModel.MiddleName;
            root.AppendChild(requesterMiddleName);

            XmlElement streetAddress1 = xml.CreateElement("StreetAddress1");
            streetAddress1.InnerText = requesterModel.AddressLine1;
            root.AppendChild(streetAddress1);

            XmlElement streetAddress2 = xml.CreateElement("StreetAddress2");
            streetAddress2.InnerText = requesterModel.AddressLine2;
            root.AppendChild(streetAddress2);

            XmlElement cityId = xml.CreateElement("CityId");
            cityId.InnerText = requesterModel.CityId.ToString();
            root.AppendChild(cityId);

            XmlElement provinceId = xml.CreateElement("ProvinceId");
            provinceId.InnerText = requesterModel.ProvinceId.ToString();
            root.AppendChild(provinceId);

            XmlElement countryId = xml.CreateElement("CountryId");
            countryId.InnerText = requesterModel.CountryId.ToString();
            root.AppendChild(countryId);

            XmlElement contactNumber = xml.CreateElement("ContactNumber");
            contactNumber.InnerText = requesterModel.ContactNumber.ToString();
            root.AppendChild(contactNumber);

            XmlElement createdBy = xml.CreateElement("CreatedBy");
            createdBy.InnerText = requesterModel.CreatedBy;
            root.AppendChild(createdBy);

            XmlElement modifiedBy = xml.CreateElement("ModifiedBy");
            modifiedBy.InnerText = requesterModel.ModifiedBy;
            root.AppendChild(modifiedBy);

            string finalXml = xml.OuterXml;
            return finalXml;
        }

    }

   
}
