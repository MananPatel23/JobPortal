using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearch.Migrations
{
    public partial class IntialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CId",
                table: "appliedJobs");

            migrationBuilder.RenameColumn(
                name: "JobID",
                table: "appliedJobs",
                newName: "JobId");

            migrationBuilder.AddColumn<int>(
                name: "RecId",
                table: "appliedJobs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_eduProfiles_JSId",
                table: "eduProfiles",
                column: "JSId");

            migrationBuilder.CreateIndex(
                name: "IX_appliedJobs_JSId",
                table: "appliedJobs",
                column: "JSId");

            migrationBuilder.CreateIndex(
                name: "IX_appliedJobs_JobId",
                table: "appliedJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_appliedJobs_RecId",
                table: "appliedJobs",
                column: "RecId");

            migrationBuilder.AddForeignKey(
                name: "FK_appliedJobs_JobSeekers_JSId",
                table: "appliedJobs",
                column: "JSId",
                principalTable: "JobSeekers",
                principalColumn: "JSId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appliedJobs_postedJobs_JobId",
                table: "appliedJobs",
                column: "JobId",
                principalTable: "postedJobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appliedJobs_recruiters_RecId",
                table: "appliedJobs",
                column: "RecId",
                principalTable: "recruiters",
                principalColumn: "RecId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_eduProfiles_JobSeekers_JSId",
                table: "eduProfiles",
                column: "JSId",
                principalTable: "JobSeekers",
                principalColumn: "JSId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appliedJobs_JobSeekers_JSId",
                table: "appliedJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_appliedJobs_postedJobs_JobId",
                table: "appliedJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_appliedJobs_recruiters_RecId",
                table: "appliedJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_eduProfiles_JobSeekers_JSId",
                table: "eduProfiles");

            migrationBuilder.DropIndex(
                name: "IX_eduProfiles_JSId",
                table: "eduProfiles");

            migrationBuilder.DropIndex(
                name: "IX_appliedJobs_JSId",
                table: "appliedJobs");

            migrationBuilder.DropIndex(
                name: "IX_appliedJobs_JobId",
                table: "appliedJobs");

            migrationBuilder.DropIndex(
                name: "IX_appliedJobs_RecId",
                table: "appliedJobs");

            migrationBuilder.DropColumn(
                name: "RecId",
                table: "appliedJobs");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "appliedJobs",
                newName: "JobID");

            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "appliedJobs",
                nullable: false,
                defaultValue: 0);
        }
    }
}
