using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgramacionV.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddTelefonoEstudiante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Estudiantes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Telefono",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Telefono",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Telefono",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Telefono",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Telefono",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Estudiantes");
        }
    }
}
