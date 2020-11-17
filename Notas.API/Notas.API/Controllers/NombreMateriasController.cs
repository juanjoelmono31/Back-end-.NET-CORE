using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Notas.API.Domain;
using Notas.API.Infraestructure;

namespace Notas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NombreMateriasController : ControllerBase
    {
        private EstudiantesDbContext _dbContext;

        public NombreMateriasController(EstudiantesDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NombreMateria>>> Get()
        {
            return await _dbContext.NombreMaterias.AsNoTracking().ToListAsync();
        }
    }


}
