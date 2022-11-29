using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart_API.Migrations
{
    public partial class hel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Payment",
                newName: "CardCVV");

            migrationBuilder.RenameColumn(
                name: "Tstatus",
                table: "Payment",
                newName: "Fullname");

            migrationBuilder.AddColumn<long>(
                name: "Cardnumber",
                table: "Payment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cardnumber",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Payment",
                newName: "Tstatus");

            migrationBuilder.RenameColumn(
                name: "CardCVV",
                table: "Payment",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
