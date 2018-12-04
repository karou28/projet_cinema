using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PaymentService" à la fois dans le code et le fichier de configuration.
    public class PaymentService : IPaymentService
    {
        BDContext bd = new BDContext();
        public Payment Add(Payment p)
        {
            throw new NotImplementedException();
            bd.Payments.Add(p);
            bd.Payments.Savechanges();
            return p;

        }

        public void DoWork()
        {
        }

        public int getDays(DateTime d)
        {
            throw new NotImplementedException();
            return DateTime.DaysInMonth(d.Year, d.Month);
        }

        public List<Payment> get_list_paiements_Autre()
        {
            throw new NotImplementedException();
            return bd.Payments.Where(a => getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) > 31).ToList();
        }

        public List<Payment> get_list_paiements_Jour()
        {
            throw new NotImplementedException();
            return bd.Payments.Where(a => getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) == 1).ToList();
        }

        public List<Payment> get_list_paiements_Mois()
        {
            throw new NotImplementedException();
            return bd.Payments.Where(a => getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) == 30 || getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) == 31).ToList();
        }

        public Payment Modify(Payment p)
        {
            throw new NotImplementedException();
            var req =(from a in bd.Payments where a.PaymentId=p.PaymentId select a ).First();
            req = p;
            bd.Payments.SaveChanges();
            return p;
        }
    }
}
