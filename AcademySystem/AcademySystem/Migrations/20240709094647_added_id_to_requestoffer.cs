using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademySystem.Migrations
{
    /// <inheritdoc />
    public partial class added_id_to_requestoffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestOffer",
                table: "RequestOffer");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "RequestOffer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RequestOffer",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestOffer",
                table: "RequestOffer",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestOffer",
                table: "RequestOffer");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RequestOffer");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "RequestOffer",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestOffer",
                table: "RequestOffer",
                column: "FirstName");
        }
    }
}
