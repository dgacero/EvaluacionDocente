using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvaluacionDocente.Server.Data;
using EvaluacionDocente.Shared.Models;

namespace EvaluacionDocente.Server.Controllers
{
    [ApiController]
    [Route("api/evaluacion")]
    public class EvaluacionController : ControllerBase
    {
        public readonly ApplicationDbContext context;

        public EvaluacionController(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Evaluacion>>> ListarEvaluaciones()
        {
            List<Evaluacion> evaluaciones = new List<Evaluacion>();
            evaluaciones = await context.Evaluaciones.ToListAsync();
            return evaluaciones;
        }

        [HttpPost]
        public async Task<ActionResult> Publicar(Evaluacion evaluacion)
        {
            context.Add(evaluacion);
            await context.SaveChangesAsync();
            return Ok();
        }
        
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Eliminar(int id)
        {
            var evaluacion = context.Evaluaciones.FirstOrDefault(p => p.Id == id);
            if (evaluacion == null)
            {
                return NotFound();
            }
            context.Evaluaciones.Remove(evaluacion);
            context.SaveChanges();
            return Ok();
        }
    }
}