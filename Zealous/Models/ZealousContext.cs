using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Zealous.Models
{
    public class ZealousContext : DbContext
    {

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Event> Events { get; set; }
        
        public ZealousContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}