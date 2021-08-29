using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Persistence.Migrations
{
    public partial class AddGuildIdonRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GuildId",
                table: "Roles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_GuildId",
                table: "Roles",
                column: "GuildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Guilds_GuildId",
                table: "Roles",
                column: "GuildId",
                principalTable: "Guilds",
                principalColumn: "GuildId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Guilds_GuildId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_GuildId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "GuildId",
                table: "Roles");
        }
    }
}
