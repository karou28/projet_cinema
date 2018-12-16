using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Wcf_Project_Cinema.Model;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
   [KnownType(typeof(Country))]
    public class City
    {
        

        [DataMember]
        public int CityId { get; set; }

        [DataMember]
        public string CityName { get; set; }

       

        [DataMember]
        public virtual Country CityCountry { get; set; }

      public City() { CityAddresses = new HashSet<Address>(); }
       
        [DataMember]
        public String CityLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Address> CityAddresses { get; set; }
    }
}