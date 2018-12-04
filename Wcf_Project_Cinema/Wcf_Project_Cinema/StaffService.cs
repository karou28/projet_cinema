using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "StaffService" à la fois dans le code et le fichier de configuration.
    public class StaffService : IStaffService
    {
        BDContext bd = new BDContext();
        public Staff Add(Staff f)
        {
            throw new NotImplementedException();
            bd.Staffs.Add(f);
            bd.Staffs.SaveChanges();
            return f;
        }

        public void DoWork()
        {
        }

      

        public List<Staff> get_list_staff()
        {
            throw new NotImplementedException();
            var req = (from a in bd.Staffs select a).ToList();
            return req;
        }

        public Staff Update(Staff s)
        {
            throw new NotImplementedException();
            var req= (from a in bd.Staffs where a.Staff.StaffId = s.StaffId select a).First();
            req = s;
            bd.Staffs.SaveChanges();
            return s;
        }
    }
}
