using Microsoft.EntityFrameworkCore;
using EvaluacionDocente.Shared.Models;

namespace EvaluacionDocente.Server.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profesor>().HasData(new Profesor
            {
				Id = 1,
    	        Nombre = "Omar Alejandro Rodríguez Márquez",
    	        Materia = "Programación Web",
    	        Escuela = "Universidad de Guanajuato",
				Imagen = "https://scontent.fbjx1-1.fna.fbcdn.net/v/t1.6435-9/49897277_10156417991262950_6701913758052122624_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=bHZy_He8_pcAX8ovVSm&_nc_ht=scontent.fbjx1-1.fna&oh=00_AfBX-PHmQxJ9IbvdlyI1KUXc42E6kt57ZFDcr4WMyNmMHg&oe=64A8A133"
            });
			
			//modelBuilder.Entity<Profesor>().HasData(new Profesor
			//{
			//	Id = 2,
    	    //    Nombre = "Luisa María Vázquez Gutiérrez",
    	    //    Materia = "Macroeconomía",
    	    //    Escuela = "Universidad de Guanajuato",
			//	Imagen = "https://scontent.fbjx1-1.fna.fbcdn.net/v/t1.6435-9/49897277_10156417991262950_6701913758052122624_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=bHZy_He8_pcAX8ovVSm&_nc_ht=scontent.fbjx1-1.fna&oh=00_AfBX-PHmQxJ9IbvdlyI1KUXc42E6kt57ZFDcr4WMyNmMHg&oe=64A8A133"
			//});
			
			modelBuilder.Entity<Evaluacion>().HasData(new Evaluacion
			{
				Id = 1,
				ProfesorId = 1,
				Calificacion = 10,
				Comentarios = "Excelente profesor. Explica muy bien."
			});
		}

        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
	}
}


