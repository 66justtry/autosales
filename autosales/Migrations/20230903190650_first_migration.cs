using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace autosales.Migrations
{
    /// <inheritdoc />
    public partial class first_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("brand_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "car",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<int>(type: "int", nullable: false),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("car_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("color_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("state_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("type_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "model",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("model_pkey", x => x.id);
                    table.ForeignKey(
                        name: "model_brandid_fkey",
                        column: x => x.BrandId,
                        principalTable: "brand",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "usage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isnew = table.Column<bool>(type: "bit", nullable: false),
                    isdamaged = table.Column<bool>(type: "bit", nullable: false),
                    mileage = table.Column<int>(type: "int", nullable: false),
                    carid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("usage_pkey", x => x.id);
                    table.ForeignKey(
                        name: "usage_carid_fkey",
                        column: x => x.carid,
                        principalTable: "car",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "info",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carid = table.Column<int>(type: "int", nullable: false),
                    typeid = table.Column<int>(type: "int", nullable: false),
                    colorid = table.Column<int>(type: "int", nullable: false),
                    stateid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info_pkey", x => x.id);
                    table.ForeignKey(
                        name: "info_carid_fkey",
                        column: x => x.carid,
                        principalTable: "car",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "info_colorid_fkey",
                        column: x => x.colorid,
                        principalTable: "color",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "info_stateid_fkey",
                        column: x => x.stateid,
                        principalTable: "state",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "info_typeid_fkey",
                        column: x => x.typeid,
                        principalTable: "type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "creation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<int>(type: "int", nullable: false),
                    carid = table.Column<int>(type: "int", nullable: false),
                    brandid = table.Column<int>(type: "int", nullable: false),
                    modelid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("creation_pkey", x => x.id);
                    table.ForeignKey(
                        name: "creation_brandid_fkey",
                        column: x => x.brandid,
                        principalTable: "brand",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "creation_carid_fkey",
                        column: x => x.carid,
                        principalTable: "car",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "creation_modelid_fkey",
                        column: x => x.modelid,
                        principalTable: "model",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_creation_brandid",
                table: "creation",
                column: "brandid");

            migrationBuilder.CreateIndex(
                name: "IX_creation_carid",
                table: "creation",
                column: "carid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_creation_modelid",
                table: "creation",
                column: "modelid");

            migrationBuilder.CreateIndex(
                name: "IX_info_carid",
                table: "info",
                column: "carid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_info_colorid",
                table: "info",
                column: "colorid");

            migrationBuilder.CreateIndex(
                name: "IX_info_stateid",
                table: "info",
                column: "stateid");

            migrationBuilder.CreateIndex(
                name: "IX_info_typeid",
                table: "info",
                column: "typeid");

            migrationBuilder.CreateIndex(
                name: "IX_model_BrandId",
                table: "model",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_usage_carid",
                table: "usage",
                column: "carid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "creation");

            migrationBuilder.DropTable(
                name: "info");

            migrationBuilder.DropTable(
                name: "usage");

            migrationBuilder.DropTable(
                name: "model");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.DropTable(
                name: "type");

            migrationBuilder.DropTable(
                name: "car");

            migrationBuilder.DropTable(
                name: "brand");
        }
    }
}
