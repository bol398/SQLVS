using Microsoft.EntityFrameworkCore.Migrations;

namespace SQL.Migrations
{
    public partial class ver3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentBetyg",
                columns: table => new
                {
                    BetygID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    KursID = table.Column<int>(nullable: false),
                    Betyg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentBetyg", x => x.BetygID);
                    table.ForeignKey(
                        name: "FK_StudentBetyg_Kurser_KursID",
                        column: x => x.KursID,
                        principalTable: "Kurser",
                        principalColumn: "KursID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentBetyg_KursID",
                table: "StudentBetyg",
                column: "KursID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentBetyg");
        }
    }
}
