using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        //Utilizada para conectar ao banco de dados
        /// String de conexão com o banco de dados que recebe os seguintes parâmetros:
        /// Data Source: nome do servidor do banco
        /// Initial catalog: Nome do BD
        /// Autenticação:
        /// -Windows: Integrated Security = True
        /// SqlServer: User Id = sa; Pwd = Senha
        /// </summary>
        private string StringConexao = "Data Source = NOTE16-S15; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";
        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdURL(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int _idGenero, GeneroDomain _genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPorIdGenero(GeneroDomain _genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {

            /*using (SqlConnection con = new SqlConnection(StringConexao)
            {
                string queryNome = "SELECT Nome FROM Genero";

            }*/
            throw new NotImplementedException();
        }

        /// <summary>
        /// Esse método vai cadastrar um novo gênero
        /// </summary>
        /// <param name="NovoGenero">Objeto com as informações que serão cadastradas</param>
        public void Cadastrar(GeneroDomain NovoGenero)
        {
            //Declara o SqlConnection passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a query que será executada
                string QueryInsert = $"INSERT INTO Genero (Nome) VALUES ('{NovoGenero.Nome}')";

                //declara o SqlCommand passando a query que será executada e a conexão com o banco de dados
                using (SqlCommand command = new SqlCommand(QueryInsert, con))
                {
                    //abre a conexão com o banco de dados
                    con.Open();

                    //apenas executar o que está na variável como uma query
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int _idGenero)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Listar todos os objetos do tipo genero
        /// </summary>
        /// <returns>Lista de objetos do tipo gênero</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<GeneroDomain> ListarTodos()
        {
            //Cria uma lista de generos onde serão armazenados os generos
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();


            //Declara a SqlConnection, passando a string de conexão como parâmetro. É o objeto que faz a conexão com o BD
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a instrução a ser executada, no caso, é o select
                string querySelectAll = "SELECT IdGenero, Nome FROM Genero";


                //Abre a conexão com o BD
                con.Open();

                //Declara o SqlDataReader para percorrer/ler a tabela no BD
                SqlDataReader rdr;


                //Declara o SqlCommand passando a query que será executada e a conexão
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    //executa a query e armazena os dados na rdr
                    rdr = cmd.ExecuteReader();


                    //Enquanto houver registros a serem lidos no rdr, o laço se repetirá
                    while (rdr.Read())
                    {
                        GeneroDomain gennero = new GeneroDomain()
                        {
                            //Atribui a propriedade IdGenero ao valor da primeira coluna da tabela
                            IdGenero = Convert.ToInt32(rdr[0]),

                            //Atribui a propriedade nome ao valor da coluna nome
                            Nome = Convert.ToString(rdr[1])

                            //ou: NomeGenero = rdr["Nome"].ToString()

                        };

                        //Adiciona o objeto criado dentro da lista
                        ListaGeneros.Add(gennero);


                    }
                }
            }

            //Retorna a lista de generos
            return ListaGeneros;
        }


    }
}