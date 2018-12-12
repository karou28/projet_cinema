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
            try
            {
                bdc.Cyties.Add(c);
                bdc.SaveChanges();
                return c;
            }catch { return null; }
        }

        public List<City> get_list_cities()
        {
            try {  var req=(from a in bdc.Cyties select a ).ToList();
                return req;
            }
            catch { return null; }
        }

        public City Modify(City c)
        {
            try
            {
                City req = bdc.Cyties.Find(c.CityId);
                req.CityLastUpdate = c.CityLastUpdate;
                req.CityName = c.CityName;

                bdc.SaveChanges();
                return c;
            }catch { return null; }
        }
    }
}
