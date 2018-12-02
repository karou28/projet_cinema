using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Wcf_Project_Cinema.Model;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int? StoreId { get; set; }
        [DataMember]
        public Store Store { get; set; }

        [DataMember]
        public string CustomerFirstName { get; set; }

        [DataMember]
        public string CustomerLastName { get; set; }

        [DataMember]
        public string CustomerEmail { get; set; }

        [DataMember]
        public int? AddressId { get; set; }
        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public Boolean CustomerActive { get; set; }

        [DataMember]
        public DateTime CustomerCreateDate { get; set; }

        [DataMember]
        public DateTime CustomerLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Rental> Rentals { get; set; }

        [DataMember]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}