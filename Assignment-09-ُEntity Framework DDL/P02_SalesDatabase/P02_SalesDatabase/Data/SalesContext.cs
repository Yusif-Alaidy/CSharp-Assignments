using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Data
{
    internal class SalesContext:DbContext
    {

        public DbSet<Store> strores { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Sale> sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Sales database;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(
                e =>
                {
                    e.Property(p => p.Name).HasColumnType("nvarchar(50)");
                    e.Property(p => p.Description).HasColumnType("nvarchar(250)");
                });
            modelBuilder.Entity<Product>().HasData(new
            {
                ProductId = 1,
                Name = "no name",
                Description = "no description",
                Quantity = 1,
                Price = 0m,

            });

            modelBuilder.Entity<Customer>(
                e =>
                {
                    e.Property(p => p.Name).HasColumnType("nvarchar(100)");
                    e.Property(p => p.Email).HasColumnType("varchar(80)");
                });
            modelBuilder.Entity<Customer>().HasData(new
            {
                CustomerId = 1,
                Name = "no name",
                Email = "no Email",
                PhoneNumber = "0123456789",
       

            });

            modelBuilder.Entity<Store>(
                e =>
                {
                    e.Property(p => p.Name).HasColumnType("nvarchar(80)");
                });
            modelBuilder.Entity<Store>().HasData(new
            {
                StoreId = 1,
                Name = "no name",

            });

            modelBuilder.Entity<Sale>(
                e =>
                {
                    e.Property(p => p.date).HasDefaultValueSql("GETDATE()");
                });
            modelBuilder.Entity<Sale>().HasData(new
            {
                SaleId = 1,
                CustomerId = 1,
                ProductId = 1,
                StoreId = 1,

            });
        }
    }
}
