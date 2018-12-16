using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Category
    {
        public Category() { CategoryFilms = new HashSet<Film>(); }
        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public DateTime CategoryLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Film> CategoryFilms { get; set; }
    }
}