using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Film
    {
        [DataMember]
        public int FilmId { get; set; }

        [DataMember]
        public string FilmTitle { get; set; }

        [DataMember]
        public string FilmDescription { get; set; }

        [DataMember]
        public string FilmReleaseYear { get; set; }

        [DataMember]
        public int FilmLanguageId { get; set; }

        [DataMember]
        public int FilmOriginalLanguageId { get; set; }

        [DataMember]
        public int FilmRentalDuration { get; set; }

        [DataMember]
        public int FilmRentalRate { get; set; }

        [DataMember]
        public int FilmLength { get; set; }

        [DataMember]
        public int FilmReplacementCost { get; set; }

        [DataMember]
        public string FilmRate { get; set; }

        [DataMember]
        public string FilmSpecialFeatures { get; set; }

        [DataMember]
        public DateTime FilmLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Store>FilmStores { get; set; }

        [DataMember]
        public virtual ICollection<Category> FilmCategories { get; set; }


    }
}