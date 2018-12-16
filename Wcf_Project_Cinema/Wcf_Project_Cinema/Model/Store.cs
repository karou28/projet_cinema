using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Wcf_Project_Cinema.Model;

namespace Wcf_Projet_Cinema.Model
{
    [DataContract]
    public class Store
    {
        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public int StoreManagerStaffId { get; set; }

        public Store() { StoreFilms = new HashSet<Film>();
            StoreCustomers = new HashSet<Customer>();

            StoreStaffs = new HashSet<Staff>();
        }

       

        [DataMember]
        public virtual Address StoreAddress { get; set; }

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