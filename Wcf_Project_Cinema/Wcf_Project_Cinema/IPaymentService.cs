using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IPaymentService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPaymentService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int getDays(DateTime d);

        [OperationContract]
        List<Payment> get_list_paiements_Jour();

        [OperationContract]
        List<Payment> get_list_paiements_Mois();

        [OperationContract]
        List<Payment> get_list_paiements_Autre();

        [OperationContract]
        Payment Add(Payment p);

        [OperationContract]
        Payment Modify(Payment p);
    }
}
