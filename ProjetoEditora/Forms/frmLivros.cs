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
    public partial class frmLivros : Form
    {
        LivroModel livroModel;
        Sql sql;

        private void Carrega_Grid()
        {
            dgLivros.AutoGenerateColumns = true;
            dgLivros.DataSource = sql.all();
        }

        private void Formate_Grid()
        {
            dgLivros.ReadOnly = true;
            dgLivros.ScrollBars = ScrollBars.Vertical;

            dgLivros.Columns[0].HeaderText = "ID";
            dgLivros.Columns[1].HeaderText = "Nome";
            dgLivros.Columns[2].HeaderText = "is";
            dgLivros.Columns[3].HeaderText = "Observaçãp";
            dgLivros.Columns[4].HeaderText = "Editora";

            dgLivros.Columns[0].Width = 100;
        }


        private void Atualizar_Grid()
        {
            Int32 vI = dgLivros.CurrentRow.Index;
            this.Text = dgLivros [0, vI].Value.ToString();
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
            // int id = Convert.ToInt32(dgLivros.Rows[e.RowIndex];

            int id = Convert.ToInt32(dgLivros.Rows[e.RowIndex].Cells["livid"].Value.ToString()) ;

            if (dgLivros.Columns[e.ColumnIndex] == dgLivros.Columns["editar"])
            {
                 dgLivros.Rows[e.RowIndex].Cells[e.ColumnIndex].ToString();
            }

          else  if (dgLivros.Columns[e.ColumnIndex] == dgLivros.Columns["excluir"])
            {
                Sql sql = new Sql();
                sql.Delete(null);
            }
        }

        private void dgLivros_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }
    }
}
