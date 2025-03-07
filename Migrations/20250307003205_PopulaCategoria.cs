using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES('Bebidas', 'bebidas.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES('Lanches', 'lanhes.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES('Sobremesas', 'sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
