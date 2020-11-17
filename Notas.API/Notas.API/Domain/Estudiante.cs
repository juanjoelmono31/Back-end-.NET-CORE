using System;
using System.ComponentModel.DataAnnotations;

namespace Notas.API.Domain
{
    public class Estudiante
    {
        [Key]
        public Guid Id_estudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }


    }
   
}
