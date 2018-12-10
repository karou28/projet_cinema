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
            try
            {

                bd.Adresses.Add(a);
                bd.SaveChanges();
                return a;
            }catch { return null; }
        }

        public void DoWork()
        {
        }

        public Address Modify(Address b)
        {
            try
            {

                Address req = bd.Adresses.Find(b.AddressId);
                req.Address2=b.Address2;
                req.AddressDistrict = b.AddressDistrict;
                req.AddressLastUpdate = b.AddressLastUpdate;
                req.AddressName = b.AddressName;
                req.AddressPostalCode = b.AddressPostalCode;
                req.Address_Phone = b.Address_Phone;
                
                bd.SaveChanges();
                return b;
            }catch { return null; }
        }
    }
}
