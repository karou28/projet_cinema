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
        public int FilmId { get; set; }

        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public int InventoryLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Rental> Rentals { get; set; }

    }
}