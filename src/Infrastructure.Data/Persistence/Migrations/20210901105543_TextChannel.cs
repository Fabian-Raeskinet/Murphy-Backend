using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Persistence.Migrations
{
    public partial class TextChannel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TextChannels",
                columns: table => new
                {
                    TextChannelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNsfw = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryChannelId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GuildId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextChannels", x => x.TextChannelId);
                    table.ForeignKey(
                        name: "FK_TextChannels_CategoryChannels_CategoryChannelId",
                        column: x => x.CategoryChannelId,
                        principalTable: "CategoryChannels",
                        principalColumn: "CategoryChannelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TextChannels_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TextChannels_CategoryChannelId",
                table: "TextChannels",
                column: "CategoryChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_TextChannels_GuildId",
                table: "TextChannels",
                column: "GuildId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TextChannels");
        }
    }
}
