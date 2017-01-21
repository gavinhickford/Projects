using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Steps",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Steps_DetailId",
                table: "Steps",
                column: "DetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_StepDetails_DetailId",
                table: "Steps",
                column: "DetailId",
                principalTable: "StepDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Steps_StepDetails_DetailId",
                table: "Steps");

            migrationBuilder.DropIndex(
                name: "IX_Steps_DetailId",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Steps");

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
    }
}
