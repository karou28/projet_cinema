using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Rental
    {
        [DataMember]
        public int RentalId { get; set; }

        [DataMember]
        public DateTime RentalDate { get; set; }

        [DataMember]
        public int RentalInventoryId { get; set; }

        [DataMember]
        public int RentalCustomerId { get; set; }

        [DataMember]
        public DateTime RentalReturnDate { get; set; }

        [DataMember]
        public int RentalStaffId { get; set; }

        [DataMember]
        public int RentalLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Payment> RentalPayments { get; set; }
    }
}