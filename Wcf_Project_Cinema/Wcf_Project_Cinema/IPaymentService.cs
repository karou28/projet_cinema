using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IPaymentService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPaymentService
    {
        [OperationContract]
        void DoWork();
    }
}
