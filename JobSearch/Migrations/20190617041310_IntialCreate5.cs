using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class IntialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Job_Tit",
                table: "postedJobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Job_Tit",
                table: "postedJobs");
        }
    }
}
