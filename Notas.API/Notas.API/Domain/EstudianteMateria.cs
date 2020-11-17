using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notas.API.Domain
{
    public class EstudianteMateria
    {
        public Guid id { get; set; }
        public Estudiante Estudiante { get; set; }
        public Guid Id_estudiante;
        public Materia Materia{ get; set; }
        public Guid Id_materia;
    }
}
