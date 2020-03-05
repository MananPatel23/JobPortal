using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class IntialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateIndex(
                name: "IX_postedJobs_RecId",
                table: "postedJobs",
                column: "RecId");

            migrationBuilder.AddForeignKey(
                name: "FK_postedJobs_recruiters_RecId",
                table: "postedJobs",
                column: "RecId",
                principalTable: "recruiters",
                principalColumn: "RecId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_postedJobs_recruiters_RecId",
                table: "postedJobs");

            migrationBuilder.DropIndex(
                name: "IX_postedJobs_RecId",
                table: "postedJobs");

            migrationBuilder.RenameColumn(
                name: "RecId",
                table: "recruiters",
                newName: "CId");
        }
    }
}
