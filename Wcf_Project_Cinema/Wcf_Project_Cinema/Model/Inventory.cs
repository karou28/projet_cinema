using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Inventory
    {
        public int Inventory_Id { get; set; }
        public int Inventory_FilmId { get; set; }
        public int Inventory_StoreId { get; set; }
        public int Inventory_LastUpdate { get; set; }

        public virtual ICollection<Rental> Inventory_Rentals { get; set; }

    }
}