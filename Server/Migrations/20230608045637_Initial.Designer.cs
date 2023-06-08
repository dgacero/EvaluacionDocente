﻿// <auto-generated />
using EvaluacionDocente.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvaluacionDocente.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230608045637_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EvaluacionDocente.Shared.Models.Evaluacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Calificacion")
                        .HasColumnType("real");

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Evaluaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calificacion = 10f,
                            Comentarios = "Excelente profesor. Explica muy bien.",
                            ProfesorId = 1
                        });
                });

            modelBuilder.Entity("EvaluacionDocente.Shared.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Escuela")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Materia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Escuela = "Universidad de Guanajuato",
                            Imagen = "https://scontent.fbjx1-1.fna.fbcdn.net/v/t1.6435-9/49897277_10156417991262950_6701913758052122624_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=bHZy_He8_pcAX8ovVSm&_nc_ht=scontent.fbjx1-1.fna&oh=00_AfBX-PHmQxJ9IbvdlyI1KUXc42E6kt57ZFDcr4WMyNmMHg&oe=64A8A133",
                            Materia = "Programación Web",
                            Nombre = "Omar Alejandro Rodríguez Márquez"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}