using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Categorias(Nome, ImagemUrl) Values('Bebidas', 'bebidas.jpg')");
            migrationBuilder.Sql("Insert Into Categorias(Nome, ImagemUrl) Values('Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("Insert Into Categorias(Nome, ImagemUrl) Values('Sobremesas', 'sobremesas.jpg')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");

        }
    }
}
