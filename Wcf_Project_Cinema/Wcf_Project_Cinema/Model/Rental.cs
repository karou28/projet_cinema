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
       public virtual Inventory RentalInventory { get; set; }

       
       [DataMember]
        public virtual Customer RentalCustomer { get; set; }

        [DataMember]
        public DateTime RentalReturnDate { get; set; }

      public Rental() { RentalPayments = new HashSet<Payment>(); }

       [DataMember]
       public virtual Staff RentalStaff { get; set; }

        [DataMember]
        public DateTime RentalLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Payment> RentalPayments { get; set; }
    }
}