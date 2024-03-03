using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteProject.Migrations
{
    public partial class NotesChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateToComlete",
                table: "Notes",
                newName: "DateSelect");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateSelect",
                table: "Notes",
                newName: "DateToComlete");
        }
    }
}
