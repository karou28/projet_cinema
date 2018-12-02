using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "FilmService" à la fois dans le code et le fichier de configuration.
    public class FilmService : IFilmService
    {
        public BDContext bd = new BDContext();
        public Film Add(Film f)
        {
            throw new NotImplementedException();
            bd.Films.Add(f);
        }

        public Film Modify(Film f)
        {
            throw new NotImplementedException();
            Film f1 = bd.Films.Find(f.FilmId);
            bd.Films.Remove(f1);
            f1 = f;
            bd.Films.Add(f1);
            bd.Films.SaveChanges();

        }
    }
}
