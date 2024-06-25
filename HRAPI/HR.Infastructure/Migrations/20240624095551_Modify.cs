using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CurrentSalary",
                table: "CandidateApplication",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpectedSalary",
                table: "CandidateApplication",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ShortlistedCandidate",
                columns: table => new
                {
                    ShortlistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    JobCircularId = table.Column<int>(type: "int", nullable: false),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    ShortlistDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterviewCallDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterviewSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewerComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewMarks = table.Column<int>(type: "int", nullable: false),
                    NextSteps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortlistedCandidate", x => x.ShortlistId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShortlistedCandidate");

            migrationBuilder.DropColumn(
                name: "CurrentSalary",
                table: "CandidateApplication");

            migrationBuilder.DropColumn(
                name: "ExpectedSalary",
                table: "CandidateApplication");
        }
    }
}
