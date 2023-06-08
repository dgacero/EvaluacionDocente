using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluacionDocente.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evaluaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfesorId = table.Column<int>(type: "int", nullable: false),
                    Calificacion = table.Column<float>(type: "real", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Materia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Escuela = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Evaluaciones",
                columns: new[] { "Id", "Calificacion", "Comentarios", "ProfesorId" },
                values: new object[] { 1, 10f, "Excelente profesor. Explica muy bien.", 1 });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "Id", "Escuela", "Imagen", "Materia", "Nombre" },
                values: new object[] { 1, "Universidad de Guanajuato", "https://scontent.fbjx1-1.fna.fbcdn.net/v/t1.6435-9/49897277_10156417991262950_6701913758052122624_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=bHZy_He8_pcAX8ovVSm&_nc_ht=scontent.fbjx1-1.fna&oh=00_AfBX-PHmQxJ9IbvdlyI1KUXc42E6kt57ZFDcr4WMyNmMHg&oe=64A8A133", "Programación Web", "Omar Alejandro Rodríguez Márquez" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluaciones");

            migrationBuilder.DropTable(
                name: "Profesores");
        }
    }
}
