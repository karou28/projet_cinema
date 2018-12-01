using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Wcf_Project_Cinema.Model;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class City
    {
        [DataMember]
        public int CityId { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public int CityCountryId { get; set; }

        [DataMember]
        public DateTime CityLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Address> CityAddress { get; set; }
    }
}