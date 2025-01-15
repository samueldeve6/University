using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityApiBakend.Migrations
{
    /// <inheritdoc />
    public partial class Newmigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Chapters_ChapterId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ChapterId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ChapterId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Courses_CourseId",
                table: "Chapters",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Courses_CourseId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Chapters");

            migrationBuilder.AddColumn<int>(
                name: "ChapterId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ChapterId",
                table: "Courses",
                column: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Chapters_ChapterId",
                table: "Courses",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
