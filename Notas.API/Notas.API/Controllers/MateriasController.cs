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
    public class MateriasController : ControllerBase
    {
        private EstudiantesDbContext _dbContext;

        public MateriasController(EstudiantesDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> Get()
        {
            return await _dbContext.Materias.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Materia>> CreateEstudent([FromBody] Materia materia)
        {
            _dbContext.Materias.Add(materia);
            await _dbContext.SaveChangesAsync();

            return StatusCode(201, materia);
        }
    }
}
