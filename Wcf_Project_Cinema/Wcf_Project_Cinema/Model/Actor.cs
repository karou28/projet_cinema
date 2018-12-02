using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Actor
    {
        [DataMember]
        public int ActorId { get; set; }

        [DataMember]
        public string ActorFirstName { get; set; }

        [DataMember]
        public string ActorLastName { get; set; }

        [DataMember]
        public DateTime ActorLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Film> Films { get; set; }
    }
}