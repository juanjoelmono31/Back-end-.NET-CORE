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
    public class ProfesoresController : ControllerBase
    {
        private EstudiantesDbContext _dbContext;

        public ProfesoresController(EstudiantesDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesor>>> Get()
        {
            return await _dbContext.Profesores.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Profesor>> CreateEstudent([FromBody] Profesor profesor)
        {
            _dbContext.Profesores.Add(profesor);
            await _dbContext.SaveChangesAsync();

            return StatusCode(201, profesor);
        }
    }
}

