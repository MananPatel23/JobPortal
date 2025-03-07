﻿// <auto-generated />
using System;
using JobSearch.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobSearch.Migrations
{
    [DbContext(typeof(OurDbContext))]
    [Migration("20190617041929_IntialCreate6")]
    partial class IntialCreate6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobSearch.Models.EduProfile", b =>
                {
                    b.Property<int>("EId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch");

                    b.Property<short>("CGPA");

                    b.Property<string>("Category");

                    b.Property<string>("CollegeName");

                    b.Property<string>("Degree")
                        .IsRequired();

                    b.Property<DateTime>("Ent_date");

                    b.Property<int>("Experiance");

                    b.Property<int>("JSId");

                    b.Property<int>("Passing_Year");

                    b.Property<string>("Skill");

                    b.HasKey("EId");

                    b.ToTable("eduProfiles");
                });

            modelBuilder.Entity("JobSearch.Models.JobSeeker", b =>
                {
                    b.Property<int>("JSId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dob");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<DateTime>("Ent_date");

                    b.Property<string>("Gender");

                    b.Property<long>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("Pincode");

                    b.HasKey("JSId");

                    b.HasAlternateKey("Email")
                        .HasName("AlternateKey_Email");

                    b.ToTable("JobSeekers");
                });

            modelBuilder.Entity("JobSearch.Models.PostedJob", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CName");

                    b.Property<string>("City");

                    b.Property<string>("Degree");

                    b.Property<DateTime>("Ent_date");

                    b.Property<string>("Job_Cat");

                    b.Property<string>("Job_Tit");

                    b.Property<int>("RecId");

                    b.Property<long>("Salary");

                    b.Property<string>("Skill");

                    b.Property<int>("Vacancy");

                    b.HasKey("JobId");

                    b.ToTable("postedJobs");
                });

            modelBuilder.Entity("JobSearch.Models.Recruiter", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CName");

                    b.Property<string>("Email");

                    b.Property<DateTime>("Ent_date");

                    b.Property<long>("Mobile");

                    b.Property<string>("Password");

                    b.Property<int>("Pincode");

                    b.HasKey("CId");

                    b.ToTable("recruiters");
                });
#pragma warning restore 612, 618
        }
    }
}
