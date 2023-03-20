using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunGroupWebApp.Migrations
{
    /// <inheritdoc />
    public partial class initialuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Milage",
                table: "AspNetUsers",
                newName: "Mileage");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "AspNetUsers",
                newName: "Milage");
        }
    }
}
