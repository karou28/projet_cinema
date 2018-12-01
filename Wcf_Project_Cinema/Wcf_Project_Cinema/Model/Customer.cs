using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public int Customer_StoreId { get; set; }
        public string Customer_FirstName { get; set; }
        public string Customer_LastName { get; set; }
        public string Customer_Email { get; set; }
        public int Customer_AddressId { get; set; }
        public string Customer_Active { get; set; }
        public DateTime Customer_CreateDate { get; set; }
        public DateTime Customer_LastUpdate { get; set; }

        public virtual ICollection<Payment> Customer_Payments { get; set; }
    }
}