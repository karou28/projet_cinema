using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Project_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "AddressService" à la fois dans le code et le fichier de configuration.
    public class AddressService : IAddressService
    {
        BDContext bd = new BDContext();
        public Address Add(Address a)
        {
            
            bd.Adresses.Add(a);
            bd.Adresses.SaveChanges();
            return a;
        }

        public void DoWork()
        {
        }

        public Address Modify(Address b)
        {
            
            var req = (from a in bd.Adresses where a.AddressId = b.AddressId select a).First();
            req = b;
            bd.Adresses.SaveChanges();
            return b;
        }
    }
}
