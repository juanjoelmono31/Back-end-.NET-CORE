using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notas.API.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Notas.API.Infraestructure.Entity
{
    public class MateriaEntityConfiguration: IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.HasKey(m => m.Id_materia);

            builder.Property<Guid>("Profesor_id");
        }
        
    }
}
