using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto14.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    idCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "subCategorias",
                columns: table => new
                {
                    idSubCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCategorias", x => x.idSubCategoria);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaSubCategorias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCategoria = table.Column<int>(nullable: false),
                    idSubCategoria = table.Column<int>(nullable: false),
                    categoriaidCategoria = table.Column<int>(nullable: true),
                    SubCategoriaidSubCategoria = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaSubCategorias", x => x.id);
                    table.ForeignKey(
                        name: "FK_CategoriaSubCategorias_subCategorias_SubCategoriaidSubCategoria",
                        column: x => x.SubCategoriaidSubCategoria,
                        principalTable: "subCategorias",
                        principalColumn: "idSubCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoriaSubCategorias_categorias_categoriaidCategoria",
                        column: x => x.categoriaidCategoria,
                        principalTable: "categorias",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaSubCategorias_SubCategoriaidSubCategoria",
                table: "CategoriaSubCategorias",
                column: "SubCategoriaidSubCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaSubCategorias_categoriaidCategoria",
                table: "CategoriaSubCategorias",
                column: "categoriaidCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaSubCategorias");

            migrationBuilder.DropTable(
                name: "subCategorias");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
