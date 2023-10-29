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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer seleção no banco de dados" + ex.Message, "Erro" + MessageBoxIcon.Error , MessageBoxButtons.OK);
              
            }
            finally { ConectionDB.CloseConection(con); } return dt;
        }


        public void NewBook(LivroModel livroModel)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = ConectionDB.Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO tbllivros (nome, anoPublicacao, isbn, observacao) VALUES ( @livnome, @livanopublicacao, @livsbn, @livobservacoes)";
                    cmd.Parameters.AddWithValue("@livnome", livroModel.nome);
                    cmd.Parameters.AddWithValue("@livanopublicacao", livroModel.anoPublicacao);
                    cmd.Parameters.AddWithValue("@livsbn", livroModel.isbn);
                    cmd.Parameters.AddWithValue("@livobservacoes", livroModel.observacao);
                   // cmd.Parameters.AddWithValue("@ediid", livroModel.ediid);
                    cmd.CommandTimeout = 3000;
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        dt.Load(dataReader);
                    }
                    catch (Exception ex) 
                    {

                        MessageBox.Show("Erro ao salvar na tabela de livros" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);
                    }
                }
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
            MySqlConnection con = ConectionDB.Connection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM tbllivros WHERE livid = @livid", con);
                cmd.Parameters.AddWithValue("@livid", livroModel.livid);
                cmd.CommandTimeout = 3000;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar o livro com ID {livroModel.livid}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConectionDB.CloseConection(con);
            }
        }


        public void Pesquisar(LivroModel livroModel)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = ConectionDB.Connection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT @nome FROM tbllivros WHERE @livid;";
                    cmd.Parameters.AddWithValue("@nome", livroModel.nome);
                    cmd.Parameters.AddWithValue("@livid", livroModel.livid);
                    cmd.CommandTimeout = 3000;
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        dt.Load(dataReader);
                    }
                    catch (Exception ex)
                    {
                    
                        MessageBox.Show("Erro ao Pesquisar na tabela de livros" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);
                    }
                }
            }
        }



    }
}
