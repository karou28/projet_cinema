using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "StoreService" à la fois dans le code et le fichier de configuration.
    public class StoreService : IStoreService
    {
        BDContext bd = new BDContext();

        public Store Add(Store s)
        {
            throw new NotImplementedException();
            bd.Stores.Add(s);
            bd.Stores.SaveChanges();
            return s;
        }

        public List<Film> getListFilms(int id)
        {
            throw new NotImplementedException();
            return bd.Films.Where(a => a.Store.StoreId == id).First();
        }

        public Store Modify(Store s)
        {
            throw new NotImplementedException();
            var req = (from a in bd.Stores where a.StoreIs.StoreId select a).First();
            req = s;
            bd.Stores.SaveChanges();
            return s;
        }
    }
}
