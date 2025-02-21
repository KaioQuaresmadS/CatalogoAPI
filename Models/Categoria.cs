using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace CatalogoAPI.Models;

[Table("Categorias")]

public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>(); // Boa pratica para inicializar uma coleção
    }
    [Key]
    public int CategoriaId { get; set; } // Sempre usar Id ou CategoriaId porque eles o APS.NET não vai conseguir identificar a chave primária

    [Required]
    [StringLength(50)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public ICollection<Produto>? Produtos { get; set; }
}

