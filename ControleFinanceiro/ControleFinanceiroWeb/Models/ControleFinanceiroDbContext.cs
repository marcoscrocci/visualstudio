using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiroWeb.Models
{
    public class ControleFinanceiroDbContext : DbContext
    {
        public ControleFinanceiroDbContext(DbContextOptions<ControleFinanceiroDbContext> options): base(options) { }

        public DbSet<TipoConta> TipoContas { get; set; }
        public DbSet<Conta> Contas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoConta>().ToTable("TipoContas");
            modelBuilder.Entity<Conta>().ToTable("Contas");            
        }

    }
}
