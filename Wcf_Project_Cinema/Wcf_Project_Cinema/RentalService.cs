using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Project_Cinema;


using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "RentalService" à la fois dans le code et le fichier de configuration.
    public class RentalService : IRentalService
    {
        BDContext bd = new BDContext();
        public Rental Add(Rental l)
        {
            bd.Rentals.Add(l);
            bd.Rentals.SaveChanges();
            return l;
            
        }

        public void DoWork()
        {
        }

        public int getDays(DateTime d)
        {
            return DateTime.DaysInMonth(d.Year, d.Month);
        }

        public List<Rental> getListRentals_depasse()
        {
          
           
            var req=(from a in bd.Rentals where getDays(DateTime.Now- a.RentalDate)> getDays(a.RentalReturnDate-a.RentalDate) select a).ToList();
            return req;
        }

        public List<Rental> getListRentals_encour()
        {
           
            var req = (from a in bd.Rentals where getDays(DateTime.Now - a.RentalDate) < getDays(a.RentalReturnDate - a.RentalDate) select a).ToList();
            return req;
        }

        public List<Rental> getListRentals_rendu()
        {
            throw new NotImplementedException();
        }

        public Rental Modify(Rental r)
        {
            var req = (from a in bd.Rentals where a.RentalId = r.RentalId select a).First();
            req = r;
            bd.Rentals.SaveChanges();
            return r; 
        }
    }
}
