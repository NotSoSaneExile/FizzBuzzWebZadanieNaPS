using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzzWeb.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "FizzBuzz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Out",
                table: "FizzBuzz",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "FizzBuzz");

            migrationBuilder.DropColumn(
                name: "Out",
                table: "FizzBuzz");
        }
    }
}
