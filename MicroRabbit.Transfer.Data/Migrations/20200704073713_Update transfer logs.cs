using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Transfer.Data.Migrations
{
    public partial class Updatetransferlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account",
                table: "TransferLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "TransferLogs",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "TransferLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "Account",
                table: "TransferLogs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
