using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Payment
    {
        [DataMember]
        public int PaymentId { get; set; }

        [DataMember]
        public int? CustomerId { get; set; }
        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public int? StaffId { get; set; }
        [DataMember]
        public Staff Staff { get; set; }

        [DataMember]
        public int RentalId { get; set; }
        [DataMember]
        public Rental Rental { get; set; }

        [DataMember]
        public int PaymentAmount { get; set; }

        [DataMember]
        public DateTime PaymentDate { get; set; }

        [DataMember]
        public DateTime PaymentLastUpdate { get; set; }


    }
}