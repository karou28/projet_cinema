using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Payment
    {
        public int Payment_Id { get; set; }
        public int Payment_CustomerId { get; set; }
        public int Payment_StaffId { get; set; }
        public int Payment_RentalId { get; set; }
        public int Payment_Amount { get; set; }
        public DateTime Payment_Date { get; set; }
        public DateTime Payment_LastUpdate { get; set; }


    }
}