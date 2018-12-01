using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Rental
    {
        public int Rental_Id { get; set; }
        public DateTime Rental_Date { get; set; }
        public int Rental_InventoryId { get; set; }
        public int Rental_CustomerId { get; set; }
        public DateTime Rental_ReturnDate { get; set; }
        public int Rental_StaffId { get; set; }
        public int Rental_LastUpdate { get; set; }

        public virtual ICollection<Payment> Rental_Payments { get; set; }
    }
}