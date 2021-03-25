using Microsoft.EntityFrameworkCore.Migrations;

namespace DropDown.Migrations
{
    public partial class addingmigratons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DropDowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DropDowns_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DropDownValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DropDownId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDownValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DropDownValues_DropDowns_DropDownId",
                        column: x => x.DropDownId,
                        principalTable: "DropDowns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DropDowns_QuestionId",
                table: "DropDowns",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DropDownValues_DropDownId",
                table: "DropDownValues",
                column: "DropDownId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DropDownValues");

            migrationBuilder.DropTable(
                name: "DropDowns");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
