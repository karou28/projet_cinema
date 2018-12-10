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
            
            
            try
            {
                bd.Staffs.Add(f);
                bd.SaveChanges();
                return f;
            }
            catch

            {
                
                return null;
            }
        }

        public void DoWork()
        {
        }

      

        public List<Staff> get_list_staff()
        {
            try
            {
                return bd.Staffs.ToList();
            }catch { return null; }
            }

        public Staff Update(Staff s)
        {
            try
            {
                Staff req = bd.Staffs.Find(s.StaffId);
                req.StaffEmail = s.StaffEmail;
                req.StaffFirstName = s.StaffFirstName;
                req.StaffLastName = s.StaffLastName;

                bd.SaveChanges();
                return s;
            }
            catch { return null; }        }
    }
}
