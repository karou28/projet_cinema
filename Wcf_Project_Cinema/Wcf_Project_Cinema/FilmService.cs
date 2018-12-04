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
            bd.Films.SaveChanges();
            return f;
        }

        public List<Film> getFilms(int[] tabId)
        {
            throw new NotImplementedException();
            List<Film> l = new List<Film>();
            for(int i=0;i<tabId.Length;i++)
            {
                Film f = bd.Films.Find(tabId[i]);
                l.Add(f);
            }
            return l;
        }

        public Film getOneFilm(int id)
        {
            throw new NotImplementedException();
            Film f= bd.Films.Find(id);
            return f;
        }

        public Film Modify(Film f)
        {
            throw new NotImplementedException();
            var req = (from a in bd.Films where a.FilmId = f.FilmId select a).First();
            req = f;
            bd.Films.SaveChanges();

        }
    }
}
