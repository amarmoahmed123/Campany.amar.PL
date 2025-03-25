using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Campany.amar.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace Campany.amar.DAL.Data.Context
{
    public class CampanyDbContext : DbContext
    {
        public CampanyDbContext(DbContextOptions<CampanyDbContext>options) : base(options)
        { 
        
           
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=3MAR\\SQLEXPRESS;Database=Campanyamar;Trusted_Connection=True;TrustServerCertificate=True");

        }

        public DbSet<Department> Departments { get; set; } 

    }
}
