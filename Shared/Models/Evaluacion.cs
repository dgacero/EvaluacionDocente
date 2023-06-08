using System;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionDocente.Shared.Models
{
    public class Evaluacion
    {
        public int Id { get; set; }
        
        public int ProfesorId { get; set; }

        public float Calificacion { get; set; }
        
        public string? Comentarios { get; set; }
    }
}