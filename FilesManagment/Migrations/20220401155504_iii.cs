using Microsoft.EntityFrameworkCore.Migrations;

namespace FilesManagement.Migrations
{
    public partial class iii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(maxLength: 500, nullable: true),
                    FileExtension = table.Column<string>(maxLength: 50, nullable: true),
                    MimeType = table.Column<string>(maxLength: 50, nullable: true),
                    FilePath = table.Column<string>(maxLength: 500, nullable: true),
                    FileSize = table.Column<long>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileData");
        }
    }
}
