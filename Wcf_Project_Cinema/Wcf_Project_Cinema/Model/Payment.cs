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
        public int PaymentCustomerId { get; set; }

        [DataMember]
        public int PaymentStaffId { get; set; }

        [DataMember]
        public int PaymentRentalId { get; set; }

        [DataMember]
        public int PaymentAmount { get; set; }

        [DataMember]
        public DateTime PaymentDate { get; set; }

        [DataMember]
        public DateTime PaymentLastUpdate { get; set; }


    }
}