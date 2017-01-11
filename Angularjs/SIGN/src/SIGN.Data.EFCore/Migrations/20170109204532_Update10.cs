using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decisions_StepActions_ActionId",
                table: "Decisions");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Assessments_AssessmentId",
                table: "Steps");

            migrationBuilder.DropForeignKey(
                name: "FK_StepActions_Steps_NextStepId",
                table: "StepActions");

            migrationBuilder.DropIndex(
                name: "IX_Steps_AssessmentId",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "AssessmentId",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "IsStartStep",
                table: "Steps");

            migrationBuilder.AddColumn<int>(
                name: "FirstStepId",
                table: "Assessments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "NextStepId",
                table: "StepActions",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActionId",
                table: "Decisions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_FirstStepId",
                table: "Assessments",
                column: "FirstStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Steps_FirstStepId",
                table: "Assessments",
                column: "FirstStepId",
                principalTable: "Steps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Decisions_StepActions_ActionId",
                table: "Decisions",
                column: "ActionId",
                principalTable: "StepActions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StepActions_Steps_NextStepId",
                table: "StepActions",
                column: "NextStepId",
                principalTable: "Steps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Steps_FirstStepId",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_Decisions_StepActions_ActionId",
                table: "Decisions");

            migrationBuilder.DropForeignKey(
                name: "FK_StepActions_Steps_NextStepId",
                table: "StepActions");

            migrationBuilder.DropIndex(
                name: "IX_Assessments_FirstStepId",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "FirstStepId",
                table: "Assessments");

            migrationBuilder.AddColumn<int>(
                name: "AssessmentId",
                table: "Steps",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsStartStep",
                table: "Steps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "NextStepId",
                table: "StepActions",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Steps_AssessmentId",
                table: "Steps",
                column: "AssessmentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Assessments_AssessmentId",
                table: "Steps",
                column: "AssessmentId",
                principalTable: "Assessments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StepActions_Steps_NextStepId",
                table: "StepActions",
                column: "NextStepId",
                principalTable: "Steps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
