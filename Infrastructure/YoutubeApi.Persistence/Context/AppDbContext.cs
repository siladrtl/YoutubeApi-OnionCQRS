using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {
            
        }
         public AppDbContext(DbContextOptions options) : base(options)
        {

        }
         DbSet<Product> Products { get; set; }
         DbSet<Detail> Details { get; set; }
         DbSet<Category> Categories { get; set; }
         DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        
    }
}
