using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace autosales.Migrations
{
    /// <inheritdoc />
    public partial class user_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("login_pkey", x => x.id);
                    table.ForeignKey(
                        name: "login_userid_fkey",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_userid",
                table: "car",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_login_userid",
                table: "login",
                column: "userid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "car_userid_fkey",
                table: "car",
                column: "userid",
                principalTable: "user",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "car_userid_fkey",
                table: "car");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropIndex(
                name: "IX_car_userid",
                table: "car");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "car");
        }
    }
}
