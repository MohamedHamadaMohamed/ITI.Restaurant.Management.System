using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name_LastName",
                schema: "Sales",
                table: "Staffs",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name_FirstName",
                schema: "Sales",
                table: "Staffs",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Price_currency",
                table: "MenuItems",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "Price_Price",
                table: "MenuItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Address_street",
                schema: "Sales",
                table: "Clients",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Address_state",
                schema: "Sales",
                table: "Clients",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Address_city",
                schema: "Sales",
                table: "Clients",
                newName: "City");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "Sales",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ApplicationUserId",
                schema: "Sales",
                table: "Clients",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_ApplicationUserId",
                schema: "Sales",
                table: "Clients",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_ApplicationUserId",
                schema: "Sales",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ApplicationUserId",
                schema: "Sales",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "Sales",
                table: "Staffs",
                newName: "Name_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "Sales",
                table: "Staffs",
                newName: "Name_FirstName");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "MenuItems",
                newName: "Price_Price");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "MenuItems",
                newName: "Price_currency");

            migrationBuilder.RenameColumn(
                name: "Street",
                schema: "Sales",
                table: "Clients",
                newName: "Address_street");

            migrationBuilder.RenameColumn(
                name: "State",
                schema: "Sales",
                table: "Clients",
                newName: "Address_state");

            migrationBuilder.RenameColumn(
                name: "City",
                schema: "Sales",
                table: "Clients",
                newName: "Address_city");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "Sales",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
