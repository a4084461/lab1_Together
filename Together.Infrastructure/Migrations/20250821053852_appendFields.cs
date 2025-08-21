using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Together.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class appendFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Events",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Events");
        }
    }
}
