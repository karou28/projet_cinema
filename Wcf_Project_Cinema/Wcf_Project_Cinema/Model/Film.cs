using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Film
    {
        public int Film_Id { get; set; }
        public string Film_Title { get; set; }
        public string Film_Description { get; set; }
        public string Film_ReleaseYear { get; set; }
        public int Film_LanguageId { get; set; }
        public int Film_OriginalLanguageId { get; set; }
        public int Film_RentalDuration { get; set; }
        public int Film_RentalRate { get; set; }
        public int Film_Length { get; set; }
        public int Film_ReplacementCost { get; set; }
        public string Film_Rate { get; set; }
        public string Film_SpecialFeatures { get; set; }
        public DateTime Film_LastUpdate { get; set; }

        public virtual ICollection<Store>Film_Stores { get; set; }
        public virtual ICollection<Category> Film_Categories { get; set; }


    }
}