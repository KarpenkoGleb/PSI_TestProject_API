using Microsoft.EntityFrameworkCore;
using PSI_TestProject_API.Models;
using System.Diagnostics.Metrics;

namespace PSI_TestProject_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Invoices> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Invoices>()
                    .HasOne(c => c.Client)
                    //.WithMany()       //.WithMany(i => i.Invoices)
                    //.HasForeignKey(c => c.ClientId)
                    //.HasPrincipalKey(c => c.Id)
                    //.IsRequired(false)
                    ;

            modelBuilder.Entity<Invoices>()
                    .HasOne(s => s.Service)
                    //.WithMany(i => i.Invoices)
                    //.HasForeignKey(s => s.ServiceId)
                    //.HasPrincipalKey(s => s.Id)
                    //.IsRequired(false)
                    ;

        }

    }
}