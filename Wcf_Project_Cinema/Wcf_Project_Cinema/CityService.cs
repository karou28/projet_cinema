using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Project_Cinema.Model;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{



    
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

     

       

        public ICollection<City> get_list()
        {
           try {
                 List<City> l= bdc.Cyties.ToList();
                if(l!=null)
                { return l; }
                else { return null; }
            }
            catch { return null; }
        }

        public ICollection<City> get_list_cities()
        {
            try
            {
                List<City> l = bdc.Cyties.ToList();
                if (l != null)
                { return l; }
                else { return null; }
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
