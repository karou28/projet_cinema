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
        public virtual Film InventoryFilm { get; set; }

      public Inventory() { InventoryRentals = new HashSet<Rental>(); }

        

        [DataMember]
       public virtual Store IventoryStore { get; set; }

        [DataMember]
        public int InventoryLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Rental> InventoryRentals { get; set; }

    }
}