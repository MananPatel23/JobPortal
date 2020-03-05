using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class IntialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eduProfiles",
                columns: table => new
                {
                    EId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JSId = table.Column<int>(nullable: false),
                    CollegeName = table.Column<string>(nullable: true),
                    Branch = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: false),
                    CGPA = table.Column<short>(nullable: false),
                    Skill = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Passing_Year = table.Column<int>(nullable: false),
                    Experiance = table.Column<int>(nullable: false),
                    Ent_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eduProfiles", x => x.EId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eduProfiles");
        }
    }
}
