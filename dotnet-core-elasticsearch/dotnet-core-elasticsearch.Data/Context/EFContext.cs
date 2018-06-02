using System;
using dotnet_core_elasticsearch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnet_core_elasticsearch.Data.Context
{
    public class EFContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data source=localhost,1433;Initial Catalog=TestDB; User ID=usertest; Password=user@test123");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
