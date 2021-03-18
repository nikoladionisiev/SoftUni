using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
      
        public SalesContext()
        {
        }

        public SalesContext(DbContextOptions<SalesContext> options) 
            : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;DataBase=HospitalDatabase;Integrated Security=true;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(x => x.Email).IsUnicode(false);

            modelBuilder.Entity<Product>().Property(x => x.Description).HasDefaultValue("No description");

            modelBuilder.Entity<Sale>().Property(x => x.Date).HasDefaultValueSql("GETDATE()");
        }
    }
}
