using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IStaffService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IStaffService
    {
        [OperationContract]
        void DoWork();

      

        [OperationContract]
         Staff Add(Staff f);

        [OperationContract]
        Staff Update(Staff s);

        [OperationContract]
        List<Staff> get_list_staff();
    }
}
