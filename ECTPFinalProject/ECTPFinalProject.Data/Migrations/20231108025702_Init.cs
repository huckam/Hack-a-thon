using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECTPFinalProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GolfCourse",
                columns: table => new
                {
                    GolfCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfCourse", x => x.GolfCourseId);
                });

            migrationBuilder.CreateTable(
                name: "Hole",
                columns: table => new
                {
                    HoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GolfCourseId = table.Column<int>(type: "int", nullable: false),
                    HoleNumber = table.Column<int>(type: "int", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hole", x => x.HoleId);
                    table.ForeignKey(
                        name: "FK_Hole_GolfCourse_GolfCourseId",
                        column: x => x.GolfCourseId,
                        principalTable: "GolfCourse",
                        principalColumn: "GolfCourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GolfCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_League", x => x.LeagueId);
                    table.ForeignKey(
                        name: "FK_League_GolfCourse_GolfCourseId",
                        column: x => x.GolfCourseId,
                        principalTable: "GolfCourse",
                        principalColumn: "GolfCourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Handicap = table.Column<double>(type: "float", nullable: false),
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Member_League_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "League",
                        principalColumn: "LeagueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekNumber = table.Column<int>(type: "int", nullable: false),
                    Hole1Score = table.Column<int>(type: "int", nullable: false),
                    Hole2Score = table.Column<int>(type: "int", nullable: false),
                    Hole3Score = table.Column<int>(type: "int", nullable: false),
                    Hole4Score = table.Column<int>(type: "int", nullable: false),
                    Hole5Score = table.Column<int>(type: "int", nullable: false),
                    Hole6Score = table.Column<int>(type: "int", nullable: false),
                    Hole7Score = table.Column<int>(type: "int", nullable: false),
                    Hole8Score = table.Column<int>(type: "int", nullable: false),
                    Hole9Score = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreId);
                    table.ForeignKey(
                        name: "FK_Score_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GolfCourse",
                columns: new[] { "GolfCourseId", "Name" },
                values: new object[,]
                {
                    { 1, "Pebble Beach" },
                    { 2, "Augusta National" }
                });

            migrationBuilder.InsertData(
                table: "Hole",
                columns: new[] { "HoleId", "GolfCourseId", "HoleNumber", "Par" },
                values: new object[,]
                {
                    { 1, 1, 1, 4 },
                    { 2, 1, 2, 3 },
                    { 3, 1, 3, 4 },
                    { 4, 1, 4, 5 },
                    { 5, 1, 5, 4 },
                    { 6, 1, 6, 4 },
                    { 7, 1, 7, 3 },
                    { 8, 1, 8, 4 },
                    { 9, 1, 9, 5 },
                    { 10, 1, 10, 4 },
                    { 11, 1, 11, 3 },
                    { 12, 1, 12, 4 },
                    { 13, 1, 13, 5 },
                    { 14, 1, 14, 4 },
                    { 15, 1, 15, 4 },
                    { 16, 1, 16, 3 },
                    { 17, 1, 17, 4 },
                    { 18, 1, 18, 5 },
                    { 19, 2, 1, 3 },
                    { 20, 2, 2, 4 },
                    { 21, 2, 3, 5 },
                    { 22, 2, 4, 4 },
                    { 23, 2, 5, 4 },
                    { 24, 2, 6, 3 },
                    { 25, 2, 7, 4 },
                    { 26, 2, 8, 5 },
                    { 27, 2, 9, 4 },
                    { 28, 2, 10, 3 },
                    { 29, 2, 11, 4 },
                    { 30, 2, 12, 5 },
                    { 31, 2, 13, 4 },
                    { 32, 2, 14, 4 },
                    { 33, 2, 15, 3 },
                    { 34, 2, 16, 4 },
                    { 35, 2, 17, 5 },
                    { 36, 2, 18, 4 }
                });

            migrationBuilder.InsertData(
                table: "League",
                columns: new[] { "LeagueId", "GolfCourseId", "Name" },
                values: new object[] { 1, 1, "CGI Golf" });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "MemberId", "FirstName", "Handicap", "LastName", "LeagueId" },
                values: new object[,]
                {
                    { 1, "Anthony", 20.0, "Huck", 1 },
                    { 2, "Patrick", 3000.0, "Dewey", 1 }
                });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "ScoreId", "Hole1Score", "Hole2Score", "Hole3Score", "Hole4Score", "Hole5Score", "Hole6Score", "Hole7Score", "Hole8Score", "Hole9Score", "MemberId", "WeekNumber" },
                values: new object[,]
                {
                    { 1, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1, 1 },
                    { 2, 4, 4, 4, 4, 4, 4, 4, 4, 4, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hole_GolfCourseId",
                table: "Hole",
                column: "GolfCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_League_GolfCourseId",
                table: "League",
                column: "GolfCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_LeagueId",
                table: "Member",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_MemberId",
                table: "Score",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hole");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.DropTable(
                name: "GolfCourse");
        }
    }
}
