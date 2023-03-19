using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunGroupWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Viewmodelfx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "EntryFee",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Races");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntryFee",
                table: "Races",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Races",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
