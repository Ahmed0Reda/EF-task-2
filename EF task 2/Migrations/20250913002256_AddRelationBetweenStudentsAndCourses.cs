using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_task_2.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationBetweenStudentsAndCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_CourseID",
                table: "Stud_Courses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_StudentId",
                table: "Stud_Courses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_CourseID",
                table: "Stud_Courses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_StudentId",
                table: "Stud_Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_CourseID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_StudentId",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_CourseID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_StudentId",
                table: "Stud_Courses");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Stud_Courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Stud_Courses");
        }
    }
}
