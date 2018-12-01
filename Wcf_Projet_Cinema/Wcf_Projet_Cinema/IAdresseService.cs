using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_Projet_Cinema
{
    [ServiceContract]
	public interface IAdresseService

	{
        [OperationContract]
         void Add_Adresse(IAdresseService a);
	}
}