using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CustomerService" à la fois dans le code et le fichier de configuration.
    public class CustomerService : ICustomerService
    {
        BDContext bd = new BDContext();

        public Customer Add(Customer c)
        {
            try
            {
                bd.Customers.Add(c);
                bd.SaveChanges();
                return c;
            }catch { return null; }
        }

        public Customer Modify(Customer c)
        {
            try
            {
                var req = bd.Customers.Find(c.CustomerId);
                req.CustomerEmail = c.CustomerEmail;
                req.CustomerFirstName = c.CustomerFirstName;
                req.CustomerLastName = c.CustomerLastName;
                req.CustomerLastUpdate = c.CustomerLastUpdate;

                bd.SaveChanges();
                return c;
            }catch { return null; }
        }
    }
}
