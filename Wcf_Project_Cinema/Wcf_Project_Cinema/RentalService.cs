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
            try
            {
                bd.Rentals.Add(l);
                bd.SaveChanges();
                return l;
            }catch { return null; }
            
        }

        public void DoWork()
        {
        }

        public int getDays(DateTime d)
        {
            return DateTime.DaysInMonth(d.Year, d.Month);
        }

        public int getSpanDays(TimeSpan t)
        {
            return t.Days;
        }

        public List<Rental> getListRentals_depasse()
        {

            try
            {

                return (from a in bd.Rentals where (getDays(DateTime.Now) - getSpanDays(a.RentalDate)) > getSpanDays(a.RentalReturnDate - a.RentalDate) && a.Returned==0 select a).ToList();
            }catch { return null; }
        }

        private int getSpanDays(DateTime rentalReturnDate)
        {
            throw new NotImplementedException();
        }

        public List<Rental> getListRentals_encour()
        {
            try
            {
                return (from a in bd.Rentals where (getDays(DateTime.Now) - getSpanDays(a.RentalDate)) < (getSpanDays(a.RentalReturnDate - a.RentalDate)) select a).ToList();
            }catch { return null; }
        }

        public List<Rental> getListRentals_rendu()
        {
            try
            {
                return (from a in bd.Rentals where a.Returned==1 select a).ToList();
            }
            catch { return null; }
        }

        public Rental Modify(Rental r)
        {
            try
            {
                Rental req = bd.Rentals.Find(r.RentalId);

                req.RentalLastUpdate = r.RentalLastUpdate;
                req.RentalReturnDate = r.RentalReturnDate;

                bd.SaveChanges();
                return r;
            }catch { return null; }
        }
    }
}
