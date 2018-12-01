using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

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
        public int StaffAddressId { get; set; }

        [DataMember]
        public byte[] StaffPicture { get; set; }

        [DataMember]
        public string StaffEmail { get; set; }

        [DataMember]
        public int StaffStoreId { get; set; }

        [DataMember]
        public int StaffActive { get; set; }

        [DataMember]
        public string StaffUsername { get; set; }

        [DataMember]
        public string StaffPassword { get; set; }

        [DataMember]
        public DateTime StaffLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Staff> StaffPayments { get; set; }

        [DataMember]
        public virtual ICollection<Store> StaffStores { get; set; }

        [DataMember]
        public virtual ICollection<Rental> StaffRentals { get; set; }
    }
}