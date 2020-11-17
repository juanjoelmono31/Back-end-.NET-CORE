using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Notas.API.Domain;
using Notas.API.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private EstudiantesDbContext _dbContext;

        public EstudiantesController(EstudiantesDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> Get() 
        {
            return await _dbContext.Estudiantes.AsNoTracking().ToListAsync();   
        }

        [HttpPost]
        public async Task<ActionResult<Estudiante>> CreateEstudent([FromBody] Estudiante estudiante )
        {
             _dbContext.Estudiantes.Add(estudiante);
            await _dbContext.SaveChangesAsync();

            return StatusCode(201, estudiante);
        }
    }
}
