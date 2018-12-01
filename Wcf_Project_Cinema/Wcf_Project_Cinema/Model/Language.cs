using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Language
    {
        public int Language_Id { get; set; }
        public string Language_Name { get; set; }
        public DateTime Language_LastUpdate { get; set; }

        public virtual ICollection<Film> Language_Films { get; set; }
    }
}