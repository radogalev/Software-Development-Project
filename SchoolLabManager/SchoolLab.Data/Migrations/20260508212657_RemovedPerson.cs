using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolLab.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_People_BorrowerId",
                table: "Loans");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Users_BorrowerId",
                table: "Loans",
                column: "BorrowerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Users_BorrowerId",
                table: "Loans");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_People_BorrowerId",
                table: "Loans",
                column: "BorrowerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
