using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace Notas.API.Domain
{
    public class Materia
    {
        [Key]
        public Guid Id_materia { get; set; }
        public string Nombre { get; set; }
        public int Corte1 { get; set; }
        public int Corte2 { get; set; }
        public int Corte3 { get; set; }


        public Profesor Profesores { get; set; }
        public Guid Id_profesor;
    }
}
