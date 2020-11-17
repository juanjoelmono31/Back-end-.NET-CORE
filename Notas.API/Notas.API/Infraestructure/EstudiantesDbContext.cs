using Microsoft.EntityFrameworkCore;
using Notas.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notas.API.Infraestructure
{
    public class EstudiantesDbContext : DbContext
    {
        public EstudiantesDbContext(DbContextOptions<EstudiantesDbContext> data) : base(data)
        {

        }

        public virtual DbSet<Estudiante> Estudiantes{ get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<EstudianteMateria> EstudiantesMaterias { get; set; }
        public DbSet<NombreMateria> NombreMaterias { get; set; }

    }
}
