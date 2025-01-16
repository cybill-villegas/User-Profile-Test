using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RRHI_Technical_Exam.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValueSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
