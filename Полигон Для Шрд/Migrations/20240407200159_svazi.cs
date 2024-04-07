using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Полигон_Для_Шрд.Migrations
{
    /// <inheritdoc />
    public partial class svazi : Migration
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
                    Number_of_class_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number_of_class = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumbersOfClasses", x => x.Number_of_class_id);
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Task = table.Column<string>(type: "TEXT", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", nullable: false),
                    NumberOfClassId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_NumbersOfClasses_Id",
                        column: x => x.Id,
                        principalTable: "NumbersOfClasses",
                        principalColumn: "Number_of_class_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NumbersOfClasses",
                columns: new[] { "Number_of_class_id", "Number_of_class", "UserId" },
                values: new object[,]
                {
                    { 1, 7, null },
                    { 2, 8, null },
                    { 3, 9, null }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Answer", "NumberOfClassId", "Task" },
                values: new object[,]
                {
                    { 4, "по формуле", 3, "Как найти количество теплоты" },
                    { 1, "наука", 1, "Что такое физика" },
                    { 2, "ялвение", 1, "Что такое диффузия" },
                    { 3, "явление", 3, "Что такое магнетизм" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NumbersOfClasses_UserId",
                table: "NumbersOfClasses",
                column: "UserId");
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
