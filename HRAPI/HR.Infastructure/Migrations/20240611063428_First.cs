using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LateDeductionOnGross = table.Column<bool>(type: "bit", nullable: true),
                    LateDayCountForDeduction = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEP_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_SHOP = table.Column<bool>(type: "bit", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DID);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE_SETUP",
                columns: table => new
                {
                    EID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARD_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JTID = table.Column<int>(type: "int", nullable: true),
                    PAYTYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GID = table.Column<int>(type: "int", nullable: true),
                    BID = table.Column<int>(type: "int", nullable: true),
                    DID = table.Column<int>(type: "int", nullable: true),
                    NATIONAL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMP_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FATHER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MOTHER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPOUSE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONE_MOBILE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JOIN_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EMP_ADDRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COUNTRY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    DE_ACTIVE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ACC_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BANK_ID = table.Column<int>(type: "int", nullable: true),
                    GRADE_AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PER_HOUR_RATE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_OT = table.Column<bool>(type: "bit", nullable: true),
                    OT_RATE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BLOOD_GROUP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    DesignationId = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TAX_AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CP_AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    STAMP_AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: true),
                    LineId = table.Column<int>(type: "int", nullable: true),
                    AttendanceCheck = table.Column<bool>(type: "bit", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketingAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EID2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRosterWiseAttendance = table.Column<bool>(type: "bit", nullable: true),
                    EMP_ADDRES_PRESENT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE_SETUP", x => x.EID);
                });

            migrationBuilder.CreateTable(
                name: "LoginUser",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUser", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "RecruitmentCircular",
                columns: table => new
                {
                    RecruitmentCircularId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    DID = table.Column<int>(type: "int", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: true),
                    NoOfVacancies = table.Column<int>(type: "int", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobResponsibilites = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobEducationalRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobBaseSkillRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobAdditionalSkillRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobSalaryRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobApplicationProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobExperienceMinYear = table.Column<int>(type: "int", nullable: true),
                    JobExperienceMaxYear = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToApply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<int>(type: "int", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitmentCircular", x => x.RecruitmentCircularId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "EMPLOYEE_SETUP");

            migrationBuilder.DropTable(
                name: "LoginUser");

            migrationBuilder.DropTable(
                name: "RecruitmentCircular");
        }
    }
}
