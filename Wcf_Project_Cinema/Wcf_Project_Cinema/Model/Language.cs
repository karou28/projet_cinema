using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Language
    {
        [DataMember]
        public int LanguageId { get; set; }

        [DataMember]
        public string LanguageName { get; set; }

        [DataMember]
        public DateTime LanguageLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Film> Films { get; set; }
    }
}