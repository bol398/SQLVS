using Microsoft.EntityFrameworkCore.Migrations;

namespace SQL.Migrations
{
    public partial class ver4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_KursStudents_StudentID",
                table: "KursStudents",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_KursStudents_Students_StudentID",
                table: "KursStudents",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KursStudents_Students_StudentID",
                table: "KursStudents");

            migrationBuilder.DropIndex(
                name: "IX_KursStudents_StudentID",
                table: "KursStudents");
        }
    }
}
