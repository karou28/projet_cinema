using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Actor
    {
        public int Actor_Id { get; set; }
        public string Actor_FirstName { get; set; }
        public string Actor_LastName { get; set; }
        public DateTime Actor_LastUpdate { get; set; }

        public virtual ICollection<Film> Actor_Films { get; set; }
    }
}