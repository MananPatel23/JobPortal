using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class IntialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

           

          

           
            migrationBuilder.CreateTable(
                name: "postedJobs",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecId = table.Column<int>(nullable: false),
                    CName = table.Column<string>(nullable: true),
                    Job_Cat = table.Column<string>(nullable: true),
                    Skill = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Salary = table.Column<long>(nullable: false),
                    Vacancy = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Ent_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postedJobs", x => x.JobId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postedJobs");

            migrationBuilder.RenameColumn(
                name: "JSId",
                table: "JobSeekers",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "JobSeekers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobSeekers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "JobSeekers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "JobSeekers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "JobSeekers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "JobSeekers",
                nullable: false,
                defaultValue: "");
        }
    }
}
