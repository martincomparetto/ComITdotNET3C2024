using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursosApp.Migrations
{
    /// <inheritdoc />
    public partial class VinculoAlumnosEnCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CursoID",
                table: "Alumnos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CursoID",
                table: "Alumnos",
                column: "CursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Cursos_CursoID",
                table: "Alumnos",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Cursos_CursoID",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_CursoID",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "CursoID",
                table: "Alumnos");
        }
    }
}
