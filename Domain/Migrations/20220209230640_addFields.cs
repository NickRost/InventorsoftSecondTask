using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class addFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employers",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Employers",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Employers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Employers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Employers");
        }
    }
}
