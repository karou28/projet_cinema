using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Project_Cinema.Model;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
   

    [ServiceContract]
    
    [ServiceKnownType(typeof(Country))]

    public interface ICityService
    {
        [OperationContract]
        City Add(City c);

       
       
        [OperationContract]
        ICollection<City> get_list_cities();

        [OperationContract]
        City Modify(City c);

        [OperationContract]
        ICollection<City> get_list();
    }
}
