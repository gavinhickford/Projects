using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using SIGN.Domain.Enums;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Guidelines",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Guidelines");
        }
    }
}
