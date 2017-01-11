using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decisions_StepActions_ActionId",
                table: "Decisions");

            migrationBuilder.AlterColumn<int>(
                name: "ActionId",
                table: "Decisions",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Decisions_StepActions_ActionId",
                table: "Decisions",
                column: "ActionId",
                principalTable: "StepActions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decisions_StepActions_ActionId",
                table: "Decisions");

            migrationBuilder.AlterColumn<int>(
                name: "ActionId",
                table: "Decisions",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Decisions_StepActions_ActionId",
                table: "Decisions",
                column: "ActionId",
                principalTable: "StepActions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
