using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StepDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepDetails", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "DetailsId",
                table: "Steps",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steps_DetailsId",
                table: "Steps",
                column: "DetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_StepDetails_DetailsId",
                table: "Steps",
                column: "DetailsId",
                principalTable: "StepDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Steps_StepDetails_DetailsId",
                table: "Steps");

            migrationBuilder.DropIndex(
                name: "IX_Steps_DetailsId",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "DetailsId",
                table: "Steps");

            migrationBuilder.DropTable(
                name: "StepDetails");
        }
    }
}
