using MySql.Data.MySqlClient;
using ProjetoEditora.Conection;
using ProjetoEditora.Model;
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
    public partial class frmAddEditoras : Form
    {
        public frmAddEditoras()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void salvar()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = ConectionDB.Connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tbleditoras (ediid,edinome, edisigla, ediobservacoes) VALUES (20, '"+ NomeEditora.Text+ "', '"+ sigla.Text + "', '"+ Obs.Text + "') ";
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            salvar();
        }


    }
}
