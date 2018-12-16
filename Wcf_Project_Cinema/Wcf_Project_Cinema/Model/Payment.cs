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

        public Payment() { }
       
        [DataMember]
        public virtual Customer PaymentCustomer { get; set; }

        


        [DataMember]
       public virtual Staff PaymentStaff { get; set; }

       

      [DataMember]
       public virtual Rental PaymentRental { get; set; }

        [DataMember]
        public int PaymentAmount { get; set; }

        [DataMember]
        public DateTime PaymentDate { get; set; }

        [DataMember]
        public DateTime PaymentLastUpdate { get; set; }


    }
}