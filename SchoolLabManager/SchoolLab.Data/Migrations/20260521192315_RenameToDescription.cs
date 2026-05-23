using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolLab.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameToDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Locations",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Locations",
                newName: "Category");
        }
    }
}
