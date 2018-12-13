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
            try
            {
                bd.Stores.Add(s);
                bd.SaveChanges();
                return s;
            }
            catch { return null; }
        }

        public List<Film> getListFilms(int id)
        {
            return new List<Film>();
        }

        public List<Store> get_list_store()
        {
            try { return bd.Stores.ToList(); }
            catch { return null; }
        }

        public Store Modify(Store s)
        {
            throw new NotImplementedException();
        }
    }
}
