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

        public Staff() { StaffRentals = new HashSet<Rental>();
            StaffPayments = new HashSet<Payment>();
        }
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
     public virtual Store StaffStore { get; set; }


        [DataMember]
        public int StaffActive { get; set; }

        [DataMember]
        public string StaffUsername { get; set; }

        [DataMember]
        public string StaffPassword { get; set; }

        [DataMember]
        public DateTime StaffLastUpdate { get; set; }

       
        [DataMember]
       public virtual Address StaffAddress { get; set; }

        [DataMember]
        public virtual ICollection<Payment> StaffPayments { get; set; }

      

        [DataMember]
        public virtual ICollection<Rental> StaffRentals { get; set; }
    }
}