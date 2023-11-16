using MySql.Data.MySqlClient;
using ProjetoEditora.Conection;
using ProjetoEditora.DB;
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
    public partial class frmAddLivro : Form
    {
        public frmAddLivro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddLivro_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validação de entrada
            if (string.IsNullOrEmpty(txtNomeLivro.Text) ||
                string.IsNullOrEmpty(txtAno.Text) ||
                string.IsNullOrEmpty(sbn.Text) ||
                string.IsNullOrEmpty(txtObs.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (!int.TryParse(txtAno.Text, out int anoPublicacao))
            {
                MessageBox.Show("Por favor, insira um ano válido.");
                return;
            }

            if (!decimal.TryParse(sbn.Text, out decimal isbn))
            {
                MessageBox.Show("Por favor, insira um ISBN válido.");
                return;
            }

            LivroModel livroModel = new LivroModel();
            livroModel.nome = txtNomeLivro.Text;
            livroModel.anoPublicacao = anoPublicacao;
            livroModel.isbn = isbn;
            livroModel.observacao = txtObs.Text;

            try
            {
                Sql sql = new Sql();
                sql.NewBook(livroModel);
                MessageBox.Show("Livro adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao adicionar o livro: {ex.Message}");
            }
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void sbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeLivro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
