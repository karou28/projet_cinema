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
        public int Returned { get; set; }

        [DataMember]
        public DateTime RentalDate { get; set; }

        [DataMember]
        public int? InventoryId { get; set; }
        [DataMember]
        public Inventory Inventory { get; set; }

        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public DateTime RentalReturnDate { get; set; }

        [DataMember]
        public int? StaffId { get; set; }
        [DataMember]
        public Staff Staff { get; set; }

        [DataMember]
        public DateTime RentalLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}