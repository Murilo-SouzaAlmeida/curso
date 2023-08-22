using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.tarde.Domains
{
    /// <summary>
    /// Classe que representa a entidade(tabela) Filme
    /// </summary>
    public class FilmeDomain
    {
        public int IdFilme { get; set; }

        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string? Titulo { get; set; }


        public int IdGenero { get; set; }

        //Referêcia para a classe Genero (GeneroDomain) - para Filme "enxergar" gênero
        public GeneroDomain? Genero { get; set; }
    }
}
