using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plants_Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "PlantDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlantDetails",
                table: "PlantDetails",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PlantDetails",
                table: "PlantDetails");

            migrationBuilder.RenameTable(
                name: "PlantDetails",
                newName: "Blogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "id");
        }
    }
}
