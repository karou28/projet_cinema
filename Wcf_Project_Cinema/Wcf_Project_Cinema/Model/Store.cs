using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Store
    {
        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public int StoreManagerStaffId { get; set; }

        [DataMember]
        public int StoreAdresseId { get; set; }

        [DataMember]
        public DateTime StoreLastUpdate { get; set; }

        [DataMember]
        public virtual ICollection<Film> StoreFilms { get; set; }

        [DataMember]
        public virtual ICollection<Customer> StoreCustomers { get; set; }

        [DataMember]
        public virtual ICollection<Staff> StoreStaffs { get; set; }
    }
}