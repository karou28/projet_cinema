using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Category
    {
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public DateTime Category_LastUpdate { get; set; }

        public virtual ICollection<Film> Category_Film { get; set; }
    }
}