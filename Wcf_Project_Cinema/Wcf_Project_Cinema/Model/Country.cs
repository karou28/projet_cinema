using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    
    public class Country
    {
        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        public Country() { CountryCities = new HashSet<City>(); }

        [DataMember]
        public String CountryLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<City> CountryCities { get; set; }
    }
}