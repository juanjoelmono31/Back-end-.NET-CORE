using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Notas.API.Domain
{
    public class Profesor
    {
        [Key]
        public Guid Id_profesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        
    }
}


