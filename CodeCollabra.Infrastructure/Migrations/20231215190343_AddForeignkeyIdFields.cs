using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeCollabra.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignkeyIdFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BadgeId",
                table: "ChatParticipantBadges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChatParticiPantId",
                table: "ChatParticipantBadges",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BadgeId",
                table: "ChatParticipantBadges");

            migrationBuilder.DropColumn(
                name: "ChatParticiPantId",
                table: "ChatParticipantBadges");
        }
    }
}
