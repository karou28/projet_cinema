using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Inventory
    {
        [DataMember]
        public int InventoryId { get; set; }

        [DataMember]
        public  Film Film { get; set; }

        [DataMember]
        public Store Store { get; set; }

        [DataMember]
        public int InventoryLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Rental> Rentals { get; set; }

    }
}