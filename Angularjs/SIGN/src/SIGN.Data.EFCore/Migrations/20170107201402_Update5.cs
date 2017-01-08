using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Guidelines_GuidelineId",
                table: "Assessment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assessment",
                table: "Assessment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assessments",
                table: "Assessment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Guidelines_GuidelineId",
                table: "Assessment",
                column: "GuidelineId",
                principalTable: "Guidelines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_Assessment_GuidelineId",
                table: "Assessment",
                newName: "IX_Assessments_GuidelineId");

            migrationBuilder.RenameTable(
                name: "Assessment",
                newName: "Assessments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Guidelines_GuidelineId",
                table: "Assessments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assessments",
                table: "Assessments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assessment",
                table: "Assessments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Guidelines_GuidelineId",
                table: "Assessments",
                column: "GuidelineId",
                principalTable: "Guidelines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_Assessments_GuidelineId",
                table: "Assessments",
                newName: "IX_Assessment_GuidelineId");

            migrationBuilder.RenameTable(
                name: "Assessments",
                newName: "Assessment");
        }
    }
}
