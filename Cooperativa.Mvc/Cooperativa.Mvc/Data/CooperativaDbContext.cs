using Cooperativa.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperativa.Mvc.Data
{
    public class CooperativaDbContext : DbContext
    {
        //public CooperativaDbContext(DbContextOptions<CooperativaDbContext> options) : base(options) { }

        //public CooperativaDbContext() { }

        //public DbSet<Produto> Produtos { get; set; }

        public DbSet<Produto> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;User Id=root;Password=p2cew0rd;Database=Cooperativas");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
