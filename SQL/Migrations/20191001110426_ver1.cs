using Microsoft.EntityFrameworkCore.Migrations;

namespace SQL.Migrations
{
    public partial class ver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(nullable: true),
                    Ålder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "Kurser",
                columns: table => new
                {
                    KursID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rum = table.Column<int>(nullable: false),
                    Namn = table.Column<string>(nullable: true),
                    TeacherID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurser", x => x.KursID);
                    table.ForeignKey(
                        name: "FK_Kurser_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KursStudents",
                columns: table => new
                {
                    KursStudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    KursID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KursStudents", x => x.KursStudentID);
                    table.ForeignKey(
                        name: "FK_KursStudents_Kurser_KursID",
                        column: x => x.KursID,
                        principalTable: "Kurser",
                        principalColumn: "KursID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kurser_TeacherID",
                table: "Kurser",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_KursStudents_KursID",
                table: "KursStudents",
                column: "KursID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KursStudents");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Kurser");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
