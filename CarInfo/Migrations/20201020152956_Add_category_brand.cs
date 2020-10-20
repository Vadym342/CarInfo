using Microsoft.EntityFrameworkCore.Migrations;

namespace CarInfo.Migrations
{
    public partial class Add_category_brand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_carBrands_CarBrandid",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carBrands",
                table: "carBrands");

            migrationBuilder.RenameTable(
                name: "carBrands",
                newName: "CarBrands");

            migrationBuilder.AddColumn<int>(
                name: "CarBrandCategoryid",
                table: "Car",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarBrands",
                table: "CarBrands",
                column: "id");

            migrationBuilder.CreateTable(
                name: "carBrandCategories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgBrand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carBrandCategories", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarBrandCategoryid",
                table: "Car",
                column: "CarBrandCategoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_carBrandCategories_CarBrandCategoryid",
                table: "Car",
                column: "CarBrandCategoryid",
                principalTable: "carBrandCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarBrands_CarBrandid",
                table: "Car",
                column: "CarBrandid",
                principalTable: "CarBrands",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_carBrandCategories_CarBrandCategoryid",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarBrands_CarBrandid",
                table: "Car");

            migrationBuilder.DropTable(
                name: "carBrandCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarBrands",
                table: "CarBrands");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarBrandCategoryid",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarBrandCategoryid",
                table: "Car");

            migrationBuilder.RenameTable(
                name: "CarBrands",
                newName: "carBrands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carBrands",
                table: "carBrands",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_carBrands_CarBrandid",
                table: "Car",
                column: "CarBrandid",
                principalTable: "carBrands",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
