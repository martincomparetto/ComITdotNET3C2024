using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursosApp.Migrations
{
    /// <inheritdoc />
    public partial class VinculoCursoProfesor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProfesorPrincipalID",
                table: "Cursos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_ProfesorPrincipalID",
                table: "Cursos",
                column: "ProfesorPrincipalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesores_ProfesorPrincipalID",
                table: "Cursos",
                column: "ProfesorPrincipalID",
                principalTable: "Profesores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesores_ProfesorPrincipalID",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_ProfesorPrincipalID",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "ProfesorPrincipalID",
                table: "Cursos");
        }
    }
}
