using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio11032020.Data
{
    class Banco
    {
        public bool ExecutarInstrucao(string querySQL)
        {
            Configuracao configuracao = new Configuracao();

            string stringConexao = configuracao.StringConfiguracao;
            string query = querySQL;

            SqlConnection sqlConnection = new SqlConnection(stringConexao);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataTable BuscarRegistro(string querySQL)
        {
            Configuracao configuracao = new Configuracao();

            string stringConexao = configuracao.StringConfiguracao;
            string query = querySQL;

            SqlConnection sqlConnection = new SqlConnection(stringConexao);
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            try
            {
                sqlConnection.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                DataTable dt = new DataTable();
                return dt;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
