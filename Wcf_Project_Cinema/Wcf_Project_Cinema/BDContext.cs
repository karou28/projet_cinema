using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Wcf_Project_Cinema.Model;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    public class BDContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cyties { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Store> Stores { get; set; }

        
        public BDContext() : base("name=filmContext")

        {
            Database.SetInitializer<BDContext>(new DropCreateDatabaseIfModelChanges<BDContext>());
        }
    }
}
