using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto14.Migrations
{
    public partial class initialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaSubCategorias_subCategorias_SubCategoriaidSubCategoria",
                table: "CategoriaSubCategorias");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaSubCategorias_categorias_categoriaidCategoria",
                table: "CategoriaSubCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subCategorias",
                table: "subCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categorias",
                table: "categorias");

            migrationBuilder.RenameTable(
                name: "subCategorias",
                newName: "SubCategorias");

            migrationBuilder.RenameTable(
                name: "categorias",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "SubCategorias",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "idSubCategoria",
                table: "SubCategorias",
                newName: "IdSubCategoria");

            migrationBuilder.RenameColumn(
                name: "idSubCategoria",
                table: "CategoriaSubCategorias",
                newName: "IdSubCategoria");

            migrationBuilder.RenameColumn(
                name: "idCategoria",
                table: "CategoriaSubCategorias",
                newName: "IdCategoria");

            migrationBuilder.RenameColumn(
                name: "categoriaidCategoria",
                table: "CategoriaSubCategorias",
                newName: "CategoriaIdCategoria");

            migrationBuilder.RenameColumn(
                name: "SubCategoriaidSubCategoria",
                table: "CategoriaSubCategorias",
                newName: "SubCategoriaIdSubCategoria");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CategoriaSubCategorias",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaSubCategorias_categoriaidCategoria",
                table: "CategoriaSubCategorias",
                newName: "IX_CategoriaSubCategorias_CategoriaIdCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaSubCategorias_SubCategoriaidSubCategoria",
                table: "CategoriaSubCategorias",
                newName: "IX_CategoriaSubCategorias_SubCategoriaIdSubCategoria");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Categoria",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "idCategoria",
                table: "Categoria",
                newName: "IdCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategorias",
                table: "SubCategorias",
                column: "IdSubCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaSubCategorias_Categoria_CategoriaIdCategoria",
                table: "CategoriaSubCategorias",
                column: "CategoriaIdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaSubCategorias_SubCategorias_SubCategoriaIdSubCategoria",
                table: "CategoriaSubCategorias",
                column: "SubCategoriaIdSubCategoria",
                principalTable: "SubCategorias",
                principalColumn: "IdSubCategoria",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaSubCategorias_Categoria_CategoriaIdCategoria",
                table: "CategoriaSubCategorias");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaSubCategorias_SubCategorias_SubCategoriaIdSubCategoria",
                table: "CategoriaSubCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategorias",
                table: "SubCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "SubCategorias",
                newName: "subCategorias");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "categorias");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "subCategorias",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IdSubCategoria",
                table: "subCategorias",
                newName: "idSubCategoria");

            migrationBuilder.RenameColumn(
                name: "SubCategoriaIdSubCategoria",
                table: "CategoriaSubCategorias",
                newName: "SubCategoriaidSubCategoria");

            migrationBuilder.RenameColumn(
                name: "IdSubCategoria",
                table: "CategoriaSubCategorias",
                newName: "idSubCategoria");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "CategoriaSubCategorias",
                newName: "idCategoria");

            migrationBuilder.RenameColumn(
                name: "CategoriaIdCategoria",
                table: "CategoriaSubCategorias",
                newName: "categoriaidCategoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CategoriaSubCategorias",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaSubCategorias_SubCategoriaIdSubCategoria",
                table: "CategoriaSubCategorias",
                newName: "IX_CategoriaSubCategorias_SubCategoriaidSubCategoria");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaSubCategorias_CategoriaIdCategoria",
                table: "CategoriaSubCategorias",
                newName: "IX_CategoriaSubCategorias_categoriaidCategoria");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "categorias",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "categorias",
                newName: "idCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subCategorias",
                table: "subCategorias",
                column: "idSubCategoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categorias",
                table: "categorias",
                column: "idCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaSubCategorias_subCategorias_SubCategoriaidSubCategoria",
                table: "CategoriaSubCategorias",
                column: "SubCategoriaidSubCategoria",
                principalTable: "subCategorias",
                principalColumn: "idSubCategoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaSubCategorias_categorias_categoriaidCategoria",
                table: "CategoriaSubCategorias",
                column: "categoriaidCategoria",
                principalTable: "categorias",
                principalColumn: "idCategoria",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
