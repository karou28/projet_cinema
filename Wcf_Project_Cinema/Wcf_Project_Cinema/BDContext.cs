using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Wcf_Project_Cinema;
using Wcf_Project_Cinema.Model;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    public class BDContext : DbContext
    {
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Address> Adresses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cyties { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        
        public BDContext() : base("name=filmContext")

        {
            Database.SetInitializer<BDContext>(new DropCreateDatabaseIfModelChanges<BDContext>());
        }
    }
}
