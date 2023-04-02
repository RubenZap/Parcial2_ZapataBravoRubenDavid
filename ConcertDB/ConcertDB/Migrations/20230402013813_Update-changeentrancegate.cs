using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertDB.Migrations
{
    /// <inheritdoc />
    public partial class Updatechangeentrancegate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EntraceGate",
                table: "Tickets",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EntraceGate",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);
        }
    }
}
