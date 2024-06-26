﻿// <auto-generated />
using System;
using HR.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240612120501_candidateApplication")]
    partial class candidateApplication
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HR.Domain.Models.LoginUser", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CREATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UPDATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("Username");

                    b.ToTable("LoginUser", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Models.Recruitment.CandidateApplication", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<string>("AdditionalInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CandidateEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("CandidateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidatePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverLetter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentEmployer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentJobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceYears")
                        .HasColumnType("int");

                    b.Property<string>("LinkedinProfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortfolioLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecruitmentCircularId")
                        .HasColumnType("int");

                    b.Property<string>("References")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResumeLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationId");

                    b.ToTable("CandidateApplication", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Models.Recruitment.RecruitmentCircular", b =>
                {
                    b.Property<int>("RecruitmentCircularId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecruitmentCircularId"));

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Benefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DID")
                        .HasColumnType("int");

                    b.Property<int?>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("EmploymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HowToApply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobAdditionalSkillRequirement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobApplicationProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobBaseSkillRequirement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobEducationalRequirement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobExperienceMaxYear")
                        .HasColumnType("int");

                    b.Property<int?>("JobExperienceMinYear")
                        .HasColumnType("int");

                    b.Property<string>("JobLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobResponsibilites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobSalaryRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoOfVacancies")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("isActive")
                        .HasColumnType("int");

                    b.HasKey("RecruitmentCircularId");

                    b.ToTable("RecruitmentCircular", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Models.Setup.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Models.Setup.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("CREATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LateDayCountForDeduction")
                        .HasColumnType("int");

                    b.Property<bool?>("LateDeductionOnGross")
                        .HasColumnType("bit");

                    b.Property<string>("UPDATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("CompanyId");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Models.Setup.Department", b =>
                {
                    b.Property<int>("DID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DID"));

                    b.Property<string>("CREATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("DEP_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IS_SHOP")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderNo")
                        .HasColumnType("int");

                    b.Property<string>("UPDATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("DID");

                    b.ToTable("Department", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Models.Setup.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignationId"));

                    b.Property<string>("CREATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("UPDATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("DesignationId");

                    b.ToTable("Designation", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Models.Setup.EmployeeSetup", b =>
                {
                    b.Property<int>("EID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EID"));

                    b.Property<string>("ACC_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("AttendanceCheck")
                        .HasColumnType("bit");

                    b.Property<int?>("BANK_ID")
                        .HasColumnType("int");

                    b.Property<int?>("BID")
                        .HasColumnType("int");

                    b.Property<string>("BLOOD_GROUP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CARD_NO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COUNTRY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CP_AMOUNT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CREATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CREATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DE_ACTIVE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DID")
                        .HasColumnType("int");

                    b.Property<string>("DISTRICT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DesignationId")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EID2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMP_ADDRES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMP_ADDRES_PRESENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMP_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FloorId")
                        .HasColumnType("int");

                    b.Property<int?>("GID")
                        .HasColumnType("int");

                    b.Property<decimal?>("GRADE_AMOUNT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IS_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<bool?>("IS_OT")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRosterWiseAttendance")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("JOIN_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("JTID")
                        .HasColumnType("int");

                    b.Property<int?>("LineId")
                        .HasColumnType("int");

                    b.Property<string>("MOTHER_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MarketingAllowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NATIONAL_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OT_RATE")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PAYTYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PER_HOUR_RATE")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PHONE_MOBILE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SPOUSE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("STAMP_AMOUNT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TAX_AMOUNT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UPDATE_BY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.HasKey("EID");

                    b.ToTable("EMPLOYEE_SETUP", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
