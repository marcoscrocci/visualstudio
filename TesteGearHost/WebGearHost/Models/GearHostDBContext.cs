using ControleFinanceiroWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebGearHost.Models
{
    public class GearHostDBContext: DbContext
    {
        public GearHostDBContext(): base("GearHostEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Redefinindo o nome da tabela
            modelBuilder.Entity<TipoConta>().ToTable("TipoContas");
            modelBuilder.Entity<Conta>().ToTable("Contas");

            // Especificando a propriedade Id como chave primária.
            modelBuilder.Entity<TipoConta>().HasKey(p => p.Id);
            modelBuilder.Entity<Conta>().HasKey(p => p.Id);

            // Especificando a chave Id como Identity (auto-incremento)
            modelBuilder.Entity<TipoConta>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Conta>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

        public DbSet<TipoConta> TipoContas { get; set; }
        public DbSet<Conta> Contas { get; set; }


    }
}