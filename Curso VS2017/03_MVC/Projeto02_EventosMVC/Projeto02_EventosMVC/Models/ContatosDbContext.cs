using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC.Models
{
    public class ContatosDbContext : DbContext
    {
        public ContatosDbContext() : base("ContatosEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Redefinindo o nome da tabela
            modelBuilder.Entity<Contato>().ToTable("TBContatos");
            
            // Especificando a propriedade Id como chave primária.
            modelBuilder.Entity<Contato>().HasKey(p => p.Id);

            // Especificando a chave Id como Identity (auto-incremento)
            modelBuilder.Entity<Contato>()
                .Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }

        public DbSet<Contato> Contatos { get; set; }

    }
}