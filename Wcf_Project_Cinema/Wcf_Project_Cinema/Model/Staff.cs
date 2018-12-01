using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Staff
    {
        public int Staff_Id { get; set; }
        public string Staff_FirstName { get; set; }
        public string Staff_LastName { get; set; }
        public int Staff_AddressId { get; set; }
        public byte[] Staff_Picture { get; set; }
        public string Staff_Email { get; set; }
        public int Staff_StoreId { get; set; }
        public int Staff_Active { get; set; }
        public string Staff_Username { get; set; }
        public string Staff_Password { get; set; }
        public DateTime Staff_LastUpdate { get; set; }

        public virtual ICollection<Staff> Staff_Payments { get; set; }
        public virtual ICollection<Store> Staff_Stores { get; set; }
        public virtual ICollection<Rental> Staff_Rentals { get; set; }
    }
}