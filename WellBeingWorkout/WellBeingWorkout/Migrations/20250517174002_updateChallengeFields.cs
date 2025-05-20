using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WellBeingWorkout.Migrations
{
    /// <inheritdoc />
    public partial class updateChallengeFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Challenge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Challenge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Challenge");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Challenge");
        }
    }
}
