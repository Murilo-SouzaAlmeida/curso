using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    /// <summary>
    /// Repository que será responsável pelas regras de negócios da entidade(tabela) Filme - assm como fazer seus CRUD
    /// </summary>
    public class FilmeRepository : IFilmeRepository
    {
        public void AtualizarPelaUrl(int _idFilme, FilmeDomain _filmeAtualizado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPeloCorpo(FilmeDomain _filmeAtualizado)
        {
            throw new NotImplementedException();
        }

        public FilmeDomain BurcarPorId(int _idFilme)
        {
            throw new NotImplementedException();
        }

        public void CadastrarFilme(FilmeDomain _novoFilme)
        {
            throw new NotImplementedException();
        }

        public void DeletarFilme(int _idFilme)
        {
            throw new NotImplementedException();
        }

        public List<FilmeDomain> ListarFilmes()
        {
            throw new NotImplementedException();
        }
    }
}
