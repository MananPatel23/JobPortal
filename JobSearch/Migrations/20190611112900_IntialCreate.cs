using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobSeekers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                   
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Pincode = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Mobile = table.Column<long>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Ent_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobSeekers");
        }
    }
}
