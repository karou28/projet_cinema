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
            throw new NotImplementedException();
            bd.Customers.Add(c);
            bd.Customers.SaveChanges();
            return c;
        }

        public Customer Modify(Customer c)
        {
            throw new NotImplementedException();
            var req = (from a in bd.Customers where a.CustomerId = c.CustomerId select a).First();
            req = c;
            bd.Customers.SaveChanges();
            return c;
        }
    }
}
