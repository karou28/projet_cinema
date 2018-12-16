using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    
    [ServiceContract]
    public interface ICountryService
    {
        [OperationContract]
        Country Add(Country c);

        [OperationContract]
        List<Country> get_list_country();

        [OperationContract]
        Country Modify(Country c);
    }
}
