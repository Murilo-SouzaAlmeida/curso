using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    /// <summary>
    /// Repository que será responsável pelas regras de negócios da entidade(tabela) Genero - assm como fazer seus CRUD
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados
        /// Data Source - nome do servidor
        /// Initial Catalogue - nome do banco de dados
        /// Autenticaçao:
        ///     Sql server:
        ///         User Id - nome do usuário
        ///         Pwd - senha do usuário
        ///     Windowns:
        ///         Integrated Securiry = true - caso esteja usando o bagulho do windowns
        /// </summary>
        private string StringConexao = "Data Source = NOTE16-S15; Initial Catalogue = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        public void AtualizarIdUrl(int _idGenero, GeneroDomain _genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPorIdGenero(GeneroDomain _genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int _idGenero)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain _novoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int _idGenero)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todos os objetos do tipo Genero
        /// </summary>
        /// <returns>Uma lista de objetos</returns>
        public List<GeneroDomain> ListarTodos()
        {
            //Lista de gêneros instanciada onde serão armazenados os gêneros
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();

            //Conexão com o banco de dados pelo System.Data.SqlClient - usando o using e o SqlConnection junto da string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Para usar scripts SQL coloco a instrução a ser executada em uma variável
                string todosGeneros = "SELECT IdGenero,Nome FROM Genero;";

                //Abre a conexão com o banco de dados
                con.Open();

                //Declara o SqlDatReader para percorrer(ler) os dados da tabela no banco de dados
                SqlDataReader rdr;

                //Recurso usado para executar o comando já estabelecido anteriormente usando a conexão já estabelecida anteriormente
                //Declara o SqlCommand passando o comando que será executado e a conexão com o banco de dados
                using (SqlCommand cmd = new SqlCommand(todosGeneros, con))
                {
                    //Executa de fato o comando e armazena os dados no leitor de dados (rdr)
                    rdr = cmd.ExecuteReader();

                    //Enquanto houver registros para serem lidos no rdr o laço se repetirá
                    while(rdr.Read())
                    {
                        GeneroDomain generoBuscado = new GeneroDomain()
                        {
                            //Atribui a propriedade IdGenero com o ou com o nome especificado da colunada da tabelal
                            //Usar o Convert.To para converter dados do rdr

                            //Aqui é por posição da coluna
                            IdGenero = Convert.ToInt32(rdr[0]),

                            //Aqui é por nome da coluna
                            Nome = Convert.ToString(rdr["Nome"])
                        };

                        ListaGeneros.Add(generoBuscado);
                    }
                }
            }

            return ListaGeneros;
        }
    }
}
