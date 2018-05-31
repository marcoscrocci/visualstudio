using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01_ConsoleApp.Models
{
    public class CursoContext : DbContext
    {
        public CursoContext() : base(new DbContextOptionsBuilder<CursoContext>()
            .UseSqlServer("Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DBNETCORE;Data Source=.")
            .Options) { }

        public DbSet<Curso> CursoInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().ToTable("TBCursos");            
        }
    }
}
