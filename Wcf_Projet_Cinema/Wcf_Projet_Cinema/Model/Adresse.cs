﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Adresse
    {
        public int Address_Id { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address_District { get; set; }
        public int Address_CityId { get; set; }
        public string Address_PostalCode { get; set; }
        public string Address_Phone { get; set; }
        public DateTime Address_LastUpdate { get; set; }

        public virtual ICollection<Staff> Address_Staffs { get; set; }
        public virtual ICollection<Customer> Address_Customers { get; set; }
    }
}