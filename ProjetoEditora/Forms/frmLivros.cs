using MySql.Data.MySqlClient;
using ProjetoEditora.Conection;
using ProjetoEditora.DB;
using ProjetoEditora.Model;
using System;
using System.Collections;
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
    public partial class frmLivros : Form
    {
        Sql sql;

        private void Carrega_Grid()
        {
            dgLivros.AutoGenerateColumns = true;
            dgLivros.DataSource = sql.all();
           
        }

        private void Formate_Grid()
        {
            dgLivros.Columns["ID"].DisplayIndex = 0;
            dgLivros.Columns["Nome"].DisplayIndex = 1;
            dgLivros.Columns["is"].DisplayIndex = 2;
            dgLivros.Columns["Observaçãp"].DisplayIndex = 3;
            dgLivros.Columns["Editora"].DisplayIndex = 4;
            dgLivros.Columns["Excluir"].DisplayIndex = 5;

         
        }


        public frmLivros()
        {
            InitializeComponent();
            
        }

        private void tbnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            sql = new Sql();
            Carrega_Grid();
        }

        private void dgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgLivros.Columns[e.ColumnIndex].Name == "excluir" && e.RowIndex >= 0)
            {
                int livroId = Convert.ToInt32(dgLivros.Rows[e.RowIndex].Cells["livid"].Value);

                LivroModel livroModel = new LivroModel { livid = livroId };

                sql.Delete(livroModel);

                dgLivros.Rows.RemoveAt(e.RowIndex);
            }

            if(dgLivros.Columns[e.ColumnIndex].Name == "editar" && e.RowIndex >= 0)
            {
                frmEditLivro frmEdit = new frmEditLivro();
                frmEdit.ShowDialog();
            }
            if (dgLivros.Columns[e.ColumnIndex].Name == "editar" && e.RowIndex >= 0)
            {
                int livroId = Convert.ToInt32(dgLivros.Rows[e.RowIndex].Cells["livid"].Value);

                LivroModel livroModel = sql.GetLivroById(livroId);

                sql.Update(livroModel);

                dgLivros.Rows[e.RowIndex].Cells["nome"].Value = livroModel.nome;
                dgLivros.Rows[e.RowIndex].Cells["anoPublicacao"].Value = livroModel.anoPublicacao;
                dgLivros.Rows[e.RowIndex].Cells["isbn"].Value = livroModel.isbn;
                dgLivros.Rows[e.RowIndex].Cells["observacao"].Value = livroModel.observacao;
            }
        }

        private void dgLivros_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void pesquisa_TextChanged(object sender, EventArgs e)
        {
            LivroModel livroModel = new LivroModel();
            livroModel.nome = pesquisa.Text;
            livroModel.livid = 1; 

            sql.Pesquisar(livroModel);
        }
    }
}
