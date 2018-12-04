using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CountryService" à la fois dans le code et le fichier de configuration.
    public class CountryService : ICountryService
    {
        BDContext bd = new BDContext();
        public Country Add(Country c)
        {
            throw new NotImplementedException();
            bd.Countries.Add(c);
            bd.Countries.SaveChanges();
            return c;

        }

        public Country Modify(Country c)
        {
            throw new NotImplementedException();
            var req = (from a in bd.Countries where a.CountryId = c.CountryId select a).First();
                req = c;
            bd.Countries.SaveChanges();
            return c;
        }
    }
}
