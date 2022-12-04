using CQRS.Web.DAL.Entity;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Web.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6TUVH6H;initial catalog=CQRSDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        
    }
}
