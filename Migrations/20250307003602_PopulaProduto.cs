using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Cola-Cola','Refrigerante de Coca-Cola',5.45,'cocacola.jpg',50,GETDATE(),1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Hamburguer','Hamburguer de carne com queijo, alface e tomate',15.90,'hamburguer.jpg',100,GETDATE(),2)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Sorvete','Sorvete de chocolate',7.50,'sorvete.jpg',200,GETDATE(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
