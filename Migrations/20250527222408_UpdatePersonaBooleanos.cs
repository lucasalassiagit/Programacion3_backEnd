using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonaBooleanos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Otros",
                table: "Personas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "Futbol",
                table: "Personas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "Basquet",
                table: "Personas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Otros",
                table: "Personas",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Futbol",
                table: "Personas",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Basquet",
                table: "Personas",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
