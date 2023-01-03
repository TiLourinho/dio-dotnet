using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exemplos.Migrations
{
    /// <inheritdoc />
    public partial class BookTableCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ratings = table.Column<double>(type: "float", nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
