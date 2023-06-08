using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvaluacionDocente.Server.Data;
using EvaluacionDocente.Shared.Models;

namespace EvaluacionDocente.Server.Controllers
{
    [ApiController]
    [Route("api/profesor")]
    public class ProfesorController : ControllerBase
    {
        public readonly ApplicationDbContext context;

        public ProfesorController(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Profesor>>> ListarProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();
            profesores = await context.Profesores.ToListAsync();
            return profesores;
        }

        [HttpPost]
        public async Task<ActionResult> Agregar(Profesor profesor)
        {
            context.Add(profesor);
            await context.SaveChangesAsync();
            return Ok();
        }
        
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var profesor = context.Profesores.FirstOrDefault(p => p.Id == id);
            if (profesor == null)
            {
                return NotFound();
            }
            context.Profesores.Remove(profesor);
            context.SaveChanges();
            return Ok();
        }
    }
}