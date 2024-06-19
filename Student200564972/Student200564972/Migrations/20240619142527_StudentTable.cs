using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student200564972.Migrations
{
    /// <inheritdoc />
    public partial class StudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            // Insertar datos iniciales
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "FirstName", "LastName", "EmailAddress" },
                values: new object[,]
                {
                    { "Nick", "Gautier", "nick.gautier@gmail.com" },
                    { "Samantha", "Smith", "samantha.smith@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}