using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDirty",
                table: "StepActions");

            migrationBuilder.DropColumn(
                name: "IsDirty",
                table: "RecommendationGrades");

            migrationBuilder.DropColumn(
                name: "IsDirty",
                table: "Recommendations");

            migrationBuilder.DropColumn(
                name: "IsDirty",
                table: "Decisions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDirty",
                table: "StepActions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDirty",
                table: "RecommendationGrades",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDirty",
                table: "Recommendations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDirty",
                table: "Decisions",
                nullable: false,
                defaultValue: false);
        }
    }
}
