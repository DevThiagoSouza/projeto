using MySql.Data.MySqlClient;
using ProjetoEditora.Conection;
using ProjetoEditora.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEditora.DB
{
    public class Sql
    {
        private MySqlConnection _connection;
        private MySqlCommand _command;
        private MySqlDataReader _Reader;
        private MySqlDataAdapter _Adaptador;

        public DataTable all()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = ConectionDB.Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tbllivros ";
            cmd.CommandTimeout = 3000;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Prepare();


            try
            {

                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                //_connection = ConectionDB.Connection();
                //_command = new MySqlCommand();
                //_command.Connection = _connection;
                //_command.CommandText =  "SELECT livid, livnome, livanopublicacao,livsbn,livobservacoes,ediid" +
                // "FROM tbllivros ORDER BY edinome";

                //DataTable dt = new DataTable();

                //_Adaptador = new MySqlDataAdapter(_command);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer seleção no banco de dados" + ex.Message, "Erro" + MessageBoxIcon.Error , MessageBoxButtons.OK);
              
            }
            finally { ConectionDB.CloseConection(con); } return dt;
        }

        public List<LivroModel> livros()
        {
            List<LivroModel> livroModels = new List<LivroModel>();

            try
            {
                _connection = ConectionDB.Connection();
                _command = new MySqlCommand();
                _command.Connection = _connection;
                _command.CommandText = "select f.* , l.autnome from tbllivros  as f inner join tblautores as l on f.livnome = l.autid ";

                _Reader = _command.ExecuteReader();

                while (_Reader.Read())
                {
                    LivroModel livro = new LivroModel();
                    livro.livid = Convert.ToInt32(_Reader["ID"]);
                    livro.nome = _Reader["nome"].ToString();
                    livro.isbn = Convert.ToDecimal(_Reader["isbn"]);
                    livro.anoPublicacao = (DateTime)_Reader["Ano_Publicação"];
                    livro.observacao = _Reader["Observação"].ToString();
                    livro.ediid = Convert.ToInt32(_Reader["EdiId"]);
                    livroModels.Add(livro);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao fazer seleção no banco de dados" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
            finally 
            {
                ConectionDB.CloseConection(_connection); 
            }
            return livroModels;
        }
        

        public void Save(LivroModel livroModel) 
        {
            DataTable dt = new DataTable();
            MySqlConnection con = ConectionDB.Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tbllivros(livid, livnome, livanopublicacao, livsbn, livobservacoes, ediid)" +
                "VALUES(@livid, @livnome, @livanopublicacao, @livsbn, @livobservacoes); ";
            cmd.CommandTimeout = 3000;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Prepare();




            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);


               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar na tabela de livros" + ex.Message , "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);
                
            }
            finally
            {
                ConectionDB.CloseConection(con);
            }
        
        }

        public void Update(LivroModel livroModel)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = ConectionDB.Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"UPDATE tbllivros SET {livroModel.nome}, {livroModel.anoPublicacao}, {livroModel.isbn}, {livroModel.observacao} WHERE {livroModel.livid};";
            cmd.CommandTimeout = 3000;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Prepare();

            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Atualizar na tabela de livros" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
            finally
            {
                ConectionDB.CloseConection(con);
            }
        }


        public void Delete(LivroModel livroModel)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = ConectionDB.Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"DELETE FROM tbllivros WHERE @livid;";
            cmd.CommandTimeout = 3000;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Prepare();

            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Deletar na tabela de livros" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
            finally
            {
                ConectionDB.CloseConection(con);
            }
        }


        public void Pesquisar(LivroModel livroModel)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = ConectionDB.Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"SELECT {livroModel.nome} FROM tbllivros WHERE {livroModel.livid};";
            cmd.CommandTimeout = 3000;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Prepare();

            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Pesquisar na tabela de livros" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
            finally
            {
                ConectionDB.CloseConection(con);
            }
        }

    }
}
