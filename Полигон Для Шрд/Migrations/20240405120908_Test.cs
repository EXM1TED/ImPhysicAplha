using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Полигон_Для_Шрд.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Class = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumbersOfClasses",
                columns: table => new
                {
                    Number_of_class = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumbersOfClasses", x => x.Number_of_class);
                    table.ForeignKey(
                        name: "FK_NumbersOfClasses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(type: "TEXT", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfClassId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_NumbersOfClasses_NumberOfClassId",
                        column: x => x.NumberOfClassId,
                        principalTable: "NumbersOfClasses",
                        principalColumn: "Number_of_class");
                });

            migrationBuilder.InsertData(
                table: "NumbersOfClasses",
                columns: new[] { "Number_of_class", "UserId" },
                values: new object[,]
                {
                    { 7, null },
                    { 8, null },
                    { 9, null }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Answer", "NumberOfClassId", "Task" },
                values: new object[,]
                {
                    { 1, "наука", 7, "Что такое физика" },
                    { 2, "ялвение", 7, "Что такое диффузия" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NumbersOfClasses_UserId",
                table: "NumbersOfClasses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_NumberOfClassId",
                table: "Tasks",
                column: "NumberOfClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "NumbersOfClasses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
