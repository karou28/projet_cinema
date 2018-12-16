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
            try
            {

                bd.Payments.Add(p);
                bd.SaveChanges();
                return p;
            }catch { return null; }

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
            try
            {
                
              return bd.Payments.Where(a => getDays(a.PaymentRental.RentalReturnDate) - getDays(a.PaymentRental.RentalDate) > 31).ToList();
            }catch { return null; }
            }

        public List<Payment> get_list_paiements_Jour()
        {
            try
            {
                
                return bd.Payments.Where(a => getDays(a.PaymentRental.RentalReturnDate) - getDays(a.PaymentRental.RentalDate) == 1).ToList();
            }catch { return null; }
            }

        public List<Payment> get_list_paiements_Mois()
        {
            try
            {
                
               return bd.Payments.Where(a => getDays(a.PaymentRental.RentalReturnDate) - getDays(a.PaymentRental.RentalDate) == 30 || getDays(a.PaymentRental.RentalReturnDate) - getDays(a.PaymentRental.RentalDate) == 31).ToList();
            }catch { return null; }
            }

        public Payment Modify(Payment p)
        {

            try
            {
                Payment req = bd.Payments.Find(p.PaymentId);
                req.PaymentAmount = p.PaymentAmount;
                
                req.PaymentLastUpdate = p.PaymentLastUpdate;
                
                bd.SaveChanges();

                return p;
            }catch { return null; }
        }
    }
}
