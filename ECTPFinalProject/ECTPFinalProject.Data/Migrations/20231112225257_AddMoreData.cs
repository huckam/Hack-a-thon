using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECTPFinalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "League",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberId", "FirstName", "Handicap", "LastName", "LeagueId" },
                values: new object[,]
                {
                    { 3, "Heath", 22.0, "Murphy", 1 },
                    { 4, "Jana", 18.0, "Patchen", 1 },
                    { 5, "Josh", 16.0, "Kulp", 1 },
                    { 6, "Olivia", 11.0, "Whitman", 1 },
                    { 7, "David", 6.0, "Houchens", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "ScoreId",
                keyValue: 2,
                columns: new[] { "MemberId", "WeekNumber" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "ScoreId", "Hole1Score", "Hole2Score", "Hole3Score", "Hole4Score", "Hole5Score", "Hole6Score", "Hole7Score", "Hole8Score", "Hole9Score", "MemberId", "WeekNumber" },
                values: new object[,]
                {
                    { 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1, 3 },
                    { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2, 1 },
                    { 5, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2, 2 },
                    { 6, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "MemberId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "ScoreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "ScoreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "ScoreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Score",
                keyColumn: "ScoreId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "League",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Score",
                keyColumn: "ScoreId",
                keyValue: 2,
                columns: new[] { "MemberId", "WeekNumber" },
                values: new object[] { 2, 1 });
        }
    }
}
