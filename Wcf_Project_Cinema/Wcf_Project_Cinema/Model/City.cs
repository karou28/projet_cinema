using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class City
    {
        public int City_Id { get; set; }
        public string City_Name { get; set; }
        public int City_CountryId { get; set; }
        public DateTime City_LastUpdate { get; set; }

        public virtual ICollection<Adresse> City_Address { get; set; }
    }
}