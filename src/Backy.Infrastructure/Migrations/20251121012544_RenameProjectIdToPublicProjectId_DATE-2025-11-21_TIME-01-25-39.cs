using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameProjectIdToPublicProjectId_DATE20251121_TIME012539 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "ProjectUsers",
                newName: "PublicProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicProjectId",
                table: "ProjectUsers",
                newName: "ProjectId");
        }
    }
}
