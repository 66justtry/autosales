using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace autosales.Migrations
{
    /// <inheritdoc />
    public partial class model_changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "model",
                newName: "brandid");

            migrationBuilder.RenameIndex(
                name: "IX_model_BrandId",
                table: "model",
                newName: "IX_model_brandid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "brandid",
                table: "model",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_model_brandid",
                table: "model",
                newName: "IX_model_BrandId");
        }
    }
}
