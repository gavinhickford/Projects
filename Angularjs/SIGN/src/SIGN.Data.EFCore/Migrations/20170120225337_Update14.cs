using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SIGN.Data.EFCore.Migrations
{
    public partial class Update14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecommendationGrades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<string>(nullable: true),
                    IsDirty = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecommendationGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    GradeId = table.Column<int>(nullable: true),
                    GuidelineId = table.Column<int>(nullable: true),
                    IsDirty = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommendations_RecommendationGrades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "RecommendationGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recommendations_Guidelines_GuidelineId",
                        column: x => x.GuidelineId,
                        principalTable: "Guidelines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_GradeId",
                table: "Recommendations",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_GuidelineId",
                table: "Recommendations",
                column: "GuidelineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "RecommendationGrades");
        }
    }
}
