using System;
using dotnet_core_elasticsearch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoreelasticsearch.Data.Context
{
    public class EFContext : DbContext
    {
        //public EFContext(DbContextOptions<EFContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data source=localhost,1433;Initial Catalog=TestDB; User ID=usertest; Password=user@test123");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
