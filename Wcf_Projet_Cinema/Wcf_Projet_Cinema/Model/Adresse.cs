using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf_Projet_Cinema.Model
{
    public class Adresse
    {
        public int Adress_Id { get; set; }
        public String Adress_Adresse { get; set; }
        public String Adress_Phone { get; set; }
        public Country Country { get; set; }
    }
}