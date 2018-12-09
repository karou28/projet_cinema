using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CityService" à la fois dans le code et le fichier de configuration.
    public class CityService : ICityService
    {
        BDContext bdc = new BDContext();
  

        public City Add(City c)
        {
            bdc.Cyties.Add(c);
            bdc.Cyties.SaveChanges();
            return c;
        }

        public City Modify(City c)
        {
            
            var req = (from a in bdc.Cyties where a.CityId=c.CityId select a).First();
            req = c;
            bdc.Cyties.SaveChanges();
            return c;
        }
    }
}
