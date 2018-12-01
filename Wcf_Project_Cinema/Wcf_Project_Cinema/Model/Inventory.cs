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
        public int InventoryFilmId { get; set; }

        [DataMember]
        public int InventoryStoreId { get; set; }

        [DataMember]
        public int InventoryLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Rental> InventoryRentals { get; set; }

    }
}