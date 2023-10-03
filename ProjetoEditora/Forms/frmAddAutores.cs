using MySql.Data.MySqlClient;
using ProjetoEditora.Conection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEditora.Forms
{
    public partial class frmAddAutores : Form
    {
        public frmAddAutores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        public void salvar()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = ConectionDB.Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblautores (autid, autnome, autseudominio, autobservacoes)VALUES (1, '" + NomeAutor.Text + "', '" + dominio.Text + "', '" + Obs.Text + "') ";
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
                MessageBox.Show("Erro ao salvar na tabela de livros" + ex.Message, "Erro" + MessageBoxIcon.Error, MessageBoxButtons.OK);

            }
            finally
            {
                ConectionDB.CloseConection(con);
            }
        }

    }
}
