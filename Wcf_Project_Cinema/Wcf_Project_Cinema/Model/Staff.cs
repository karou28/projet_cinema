using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Wcf_Project_Cinema.Model;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Staff
    {
        [DataMember]
        public int StaffId { get; set; }

        [DataMember]
        public string StaffFirstName { get; set; }

        [DataMember]
        public string StaffLastName { get; set; }

        [DataMember]
        public byte[] StaffPicture { get; set; }

        [DataMember]
        public string StaffEmail { get; set; }

        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public int StaffActive { get; set; }

        [DataMember]
        public string StaffUsername { get; set; }

        [DataMember]
        public string StaffPassword { get; set; }

        [DataMember]
        public DateTime StaffLastUpdate { get; set; }

        [DataMember]
        public int? AddressId { get; set; }
        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public virtual ICollection<Staff> Payments { get; set; }

        [DataMember]
        public virtual ICollection<Store> Stores { get; set; }

        [DataMember]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}