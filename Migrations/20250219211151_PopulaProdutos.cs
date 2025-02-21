using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class Produtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "Values('Coca-Cola', 'Refrigerante de cola', 5.45, 'coca.jpg', 50, GETDATE() , 1)");

            migrationBuilder.Sql("Insert Into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "Values('Sanduiche de Atum', 'Sanduiche de Atum com maionese', 8.50, 'atum.jpg', 10, GETDATE() , 2)");

            migrationBuilder.Sql("Insert Into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "Values('Pudim 100g', 'Pudim de leite condensado 100g', 6.75, 'pudim.jpg', 20, GETDATE() , 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
