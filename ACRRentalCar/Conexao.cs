using System.Data.SqlClient;

namespace ACRRentalCar
{
    public class Conexao
    {
        //método para realizar a conexão com o Banco de Dados
        public static SqlConnection getConnection()
        {
            //cria um objeto (variável cnn) do tipo SqlConnection
            //e configura a string de conexão
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RENTAL_CAR;Integrated Security=True;Pooling=False");

            //retorna uma conexão com o banco de dados quando esse método for chamado
            return cnn;
        }
    }
}