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
            
            bd.Payments.Add(p);
            bd.Payments.Savechanges();
            return p;

        }

        public void DoWork()
        {
        }

        public int getDays(DateTime d)
        {
           
            return DateTime.DaysInMonth(d.Year, d.Month);
        }

        public List<Payment> get_list_paiements_Autre()
        {
            
            return bd.Payments.Where(a => getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) > 31).ToList();
        }

        public List<Payment> get_list_paiements_Jour()
        {
            
            return bd.Payments.Where(a => getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) == 1).ToList();
        }

        public List<Payment> get_list_paiements_Mois()
        {
            
            return bd.Payments.Where(a => getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) == 30 || getDays(a.Rental.RentalReturnDate) - getDays(a.RentalDate) == 31).ToList();
        }

        public Payment Modify(Payment p)
        {
            
            
            var req =(from a in bd.Payments where a.PaymentId=p.PaymentId select a ).First();
            req = p;
            bd.Payments.SaveChanges();
            return p;
        }
    }
}
