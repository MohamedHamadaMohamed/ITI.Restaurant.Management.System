using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 266, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 251, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 258, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 202, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 245, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 182, DateTimeKind.Local).AddTicks(9130));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 266, DateTimeKind.Local).AddTicks(5007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 251, DateTimeKind.Local).AddTicks(1702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 258, DateTimeKind.Local).AddTicks(9757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 202, DateTimeKind.Local).AddTicks(9709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 245, DateTimeKind.Local).AddTicks(4028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Sales",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 10, 20, 21, 13, 22, 182, DateTimeKind.Local).AddTicks(9130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
