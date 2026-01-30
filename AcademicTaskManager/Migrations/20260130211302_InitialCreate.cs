using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AcademicTaskManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskItems_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Descripción del Proyecto 1", "Proyecto 1" },
                    { 2, "Descripción del Proyecto 2", "Proyecto 2" }
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "Description", "DueDate", "IsCompleted", "ProjectId", "Title" },
                values: new object[,]
                {
                    { 1, "Primera tarea", new DateTime(2026, 2, 6, 17, 13, 2, 424, DateTimeKind.Local).AddTicks(7040), false, 1, "Tarea 1" },
                    { 2, "Segunda tarea", new DateTime(2026, 2, 13, 17, 13, 2, 424, DateTimeKind.Local).AddTicks(7059), false, 1, "Tarea 2" },
                    { 3, "Tercera tarea", new DateTime(2026, 2, 9, 17, 13, 2, 424, DateTimeKind.Local).AddTicks(7061), true, 2, "Tarea 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_ProjectId",
                table: "TaskItems",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
