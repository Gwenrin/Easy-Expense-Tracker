using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToBankTransactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BankTransactions",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BankTransactions");
        }
    }
}
