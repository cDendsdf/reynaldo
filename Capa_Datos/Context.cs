using Capa_Datos.Entidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionStrings = "Server=.;Initial Catalog=Registro;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(ConnectionStrings);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Matricula>().HasKey(x => new { x.AsignaturaId, x.EstudianteId });
        }

        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }



    }
}
