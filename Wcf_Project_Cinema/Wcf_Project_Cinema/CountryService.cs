using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    
    
    public class CountryService : ICountryService
    {
        BDContext bd = new BDContext();
        public Country Add(Country c)
        {
            try
            {
                bd.Countries.Add(c);
                bd.SaveChanges();
                return c;
            }catch { return null; }

        }

        public List<Country> get_list_country()
        {
            try
            {
                List<Country> l = bd.Countries.ToList();
                return l;
            }
            catch { return null; }
        }

        public Country Modify(Country c)
        {
            try
            {
                Country req = bd.Countries.Find(c.CountryId);
                req.CountryLastUpdate = c.CountryLastUpdate;
                req.CountryName = c.CountryName;

                bd.SaveChanges();
                return c;
            }catch { return null; }
        }
    }
}
