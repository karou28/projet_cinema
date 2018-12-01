using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Store
    {
        public int Store_Id { get; set; }
        public int Store_ManagerStaffId { get; set; }
        public int Store_AdresseId { get; set; }
        public DateTime Store_LastUpdate { get; set; }

        public virtual ICollection<Film> Store_Films { get; set; }
        public virtual ICollection<Customer> Store_Customers { get; set; }
        public virtual ICollection<Staff> Store_Staffs { get; set; }
    }
}