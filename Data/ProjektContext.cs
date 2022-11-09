using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROJEKT.Models;

namespace PROJEKT.Data
{
    public class ProjektContext : DbContext
    {
        public ProjektContext (DbContextOptions<ProjektContext> options)
            : base(options)
        {
        }

        public DbSet<PROJEKT.Models.Product> Product { get; set; }
        public DbSet<PROJEKT.Models.Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteUser>().ToTable("SiteUser");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");  
        }

        public DbSet<PROJEKT.Models.SiteUser> SiteUser { get; set; }
    }
}
