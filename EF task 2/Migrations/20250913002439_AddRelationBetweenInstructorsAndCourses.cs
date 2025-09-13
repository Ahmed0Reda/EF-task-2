using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_task_2.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationBetweenInstructorsAndCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_CourseID",
                table: "Course_Insts",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_InstructorID",
                table: "Course_Insts",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_CourseID",
                table: "Course_Insts",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorID",
                table: "Course_Insts",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_CourseID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorID",
                table: "Course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_CourseID",
                table: "Course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_InstructorID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Course_Insts");
        }
    }
}
