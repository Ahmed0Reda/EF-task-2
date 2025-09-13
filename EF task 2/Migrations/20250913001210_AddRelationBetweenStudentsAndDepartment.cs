using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_task_2.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationBetweenStudentsAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dep_Id",
                table: "Students",
                newName: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptId",
                table: "Students",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Students",
                newName: "Dep_Id");
        }
    }
}
