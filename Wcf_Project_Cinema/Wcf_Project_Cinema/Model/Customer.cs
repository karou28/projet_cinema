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
        public Nullable<int> StoreId { get; set; }

        [DataMember]
        public virtual Store CustomerStore { get; set; }

        [DataMember]
        public string CustomerFirstName { get; set; }

        [DataMember]
        public string CustomerLastName { get; set; }

        [DataMember]
        public string CustomerEmail { get; set; }

        [DataMember]
        public Nullable<int> AddressId { get; set; }

        [DataMember]
        public virtual Address CustomerAddress { get; set; }

        [DataMember]
        public Boolean CustomerActive { get; set; }

        [DataMember]
        public DateTime CustomerCreateDate { get; set; }

        [DataMember]
        public DateTime CustomerLastUpdate { get; set; }

        public Customer() { CustomerRentals = new HashSet<Rental>();
            CustomerPayments = new HashSet<Payment>();
        }

        [DataMember]
        public virtual ICollection<Rental> CustomerRentals { get; set; }

        [DataMember]
        public virtual ICollection<Payment> CustomerPayments { get; set; }
    }
}