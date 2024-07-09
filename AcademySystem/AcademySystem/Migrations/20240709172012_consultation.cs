using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademySystem.Migrations
{
    /// <inheritdoc />
    public partial class consultation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultation",
                table: "Consultation");

            migrationBuilder.RenameTable(
                name: "Consultation",
                newName: "Consultations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultations",
                table: "Consultations",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultations",
                table: "Consultations");

            migrationBuilder.RenameTable(
                name: "Consultations",
                newName: "Consultation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultation",
                table: "Consultation",
                column: "Id");
        }
    }
}
