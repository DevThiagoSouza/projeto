using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoEditora.Conection
{
    public class ConectionDB
    {
        private static MySqlConnection _connection;
        private static MySqlCommand _command;
        private static MySqlDataAdapter _Adaptador;
        private static DataTable _dataTable;
        private static string Conexao = "datasource=127.0.0.1;port=3306;username=root;password=123456789;database=SistemaEditoras";


        public static MySqlConnection Connection()
        {
            try
            {
                _connection = new MySqlConnection(Conexao);
                _connection.Open();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);

            }
            return _connection;

        }

        public static void CloseConection(MySqlConnection connection)
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
