using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicTaskManager.Migrations
{
    /// <inheritdoc />
    public partial class StaticSeedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 2, 17, 11, 58, 43, 382, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 2, 24, 11, 58, 43, 384, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 2, 20, 11, 58, 43, 384, DateTimeKind.Local).AddTicks(965));
        }
    }
}
