using Microsoft.EntityFrameworkCore.Migrations;

namespace Safari_Online.Migrations
{
    public partial class AddedAnimalsControllerGetPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SeenAnimalsTable",
                table: "SeenAnimalsTable");

            migrationBuilder.RenameTable(
                name: "SeenAnimalsTable",
                newName: "SeenAnimals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeenAnimals",
                table: "SeenAnimals",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SeenAnimals",
                table: "SeenAnimals");

            migrationBuilder.RenameTable(
                name: "SeenAnimals",
                newName: "SeenAnimalsTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeenAnimalsTable",
                table: "SeenAnimalsTable",
                column: "Id");
        }
    }
}
