using System;
using System.Runtime.Serialization;

namespace Unisys.Application.Model.Encoding
{
    [DataContract]
    public class MvRequestModel 
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public DateTime? DateRequested { get; set; }

        [DataMember]
        public bool IsConverted { get; set; }

        [DataMember]
        public string MvReason { get; set; }

        [DataMember]
        public string UnitAssignedTo { get; set; }

        [DataMember]
        public int? DayPendingInUnit { get; set; }

        [DataMember]
        public int? TotalDayPending { get; set; }

        [DataMember]
        public DateTime? TargetReleaseDate { get; set; }

        [DataMember]
        public int? TotalDaysOverdue { get; set; }

        [DataMember]
        public string MvRequestStatus { get; set; }
    }
}
