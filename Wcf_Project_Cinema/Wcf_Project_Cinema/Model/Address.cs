using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema.Model
{
    [DataContract]
   
    public class Address
    {
        [DataMember]
        public int AddressId { get; set; }

        [DataMember]
        public string AddressName { get; set; }

        [DataMember]
        public string Address2 { get; set; }

        [DataMember]
        public string AddressDistrict { get; set; }

        [DataMember]
        public Nullable<int> CityId { get; set; }

        [DataMember]
        public virtual City City { get; set; }

       public Address()
        {
            AddressStaffs = new HashSet<Staff>();
            AddressStores = new HashSet<Store>();
            AddressCustomers = new HashSet<Customer>();
        }

        [DataMember]
        public string AddressPostalCode { get; set; }

        [DataMember]
        public string Address_Phone { get; set; }

        [DataMember]
        public DateTime AddressLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Staff> AddressStaffs { get; set; }

        [DataMember]
        public virtual ICollection<Store> AddressStores { get; set; }

        [DataMember]
        public virtual ICollection<Customer> AddressCustomers { get; set; }
    }
}
