using System;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionDocente.Shared.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        
        [Required]
        public string Nombre{ get; set; } = string.Empty;
        
        [Required]
        public string Materia { get; set; } = string.Empty;
        
        [Required]
        public string Escuela { get; set; } = string.Empty;
        
        public string? Imagen { get; set; }
    }
}