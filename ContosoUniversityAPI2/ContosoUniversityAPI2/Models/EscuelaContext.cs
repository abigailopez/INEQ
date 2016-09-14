using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversityAPI2.Models
{
    public class EscuelaContext : DbContext
    {
        public EscuelaContext() : base("EscuelaContext")
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Enrolamiento> Enrolamientos { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}