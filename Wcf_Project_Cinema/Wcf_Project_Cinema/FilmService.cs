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
            try
            {
                bd.Films.Add(f);
                bd.SaveChanges();
                return f;
            }catch { return null; }
        }

        public List<Film> getFilms(int[] tabId)
        {

            try
            {
                List<Film> l = new List<Film>();
                for (int i = 0; i < tabId.Length; i++)
                {
                    Film f = bd.Films.Find(tabId[i]);
                    l.Add(f);
                }
                return l;
            }catch { return null; }
        }

        public Film getOneFilm(int id)
        {
            try
            {
                Film f = bd.Films.Find(id);
                return f;
            }catch { return null; }
        }

        public Film Modify(Film f)
        {

            try
            {
                Film req = bd.Films.Find(f.FilmId);
                
                
                req.FilmRate = f.FilmRate;
                
                req.FilmRentalDuration = f.FilmRentalDuration;
                
                req.FilmReplacementCost = f.FilmReplacementCost;
                req.FilmSpecialFeatures = f.FilmSpecialFeatures;
                req.FilmTitle = f.FilmTitle;
                req.FilmLastUpdate = f.FilmLastUpdate;
                bd.SaveChanges();
                return f;
            }catch { return null; }
        }
    }
}
