using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicTaskManager.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskStatusToTaskItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TaskItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 2, 9, 11, 6, 47, 67, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DueDate", "Status" },
                values: new object[] { new DateTime(2026, 2, 16, 11, 6, 47, 67, DateTimeKind.Local).AddTicks(6753), 1 });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DueDate", "Status" },
                values: new object[] { new DateTime(2026, 2, 12, 11, 6, 47, 67, DateTimeKind.Local).AddTicks(6755), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TaskItems");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 2, 6, 17, 13, 2, 424, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 2, 13, 17, 13, 2, 424, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 2, 9, 17, 13, 2, 424, DateTimeKind.Local).AddTicks(7061));
        }
    }
}
