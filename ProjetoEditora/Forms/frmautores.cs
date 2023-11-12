using ProjetoEditora.DB;
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
    public partial class frmautores : Form
    {
        Sql sql;
        private void Carrega_Grid()
        {
            dtgridAutores.AutoGenerateColumns = true;
            dtgridAutores.DataSource = sql.allAutores();

        }
        public frmautores()
        {
            InitializeComponent();
           
        }

        private void dtgridAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmautores_Load(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            Carrega_Grid();
        }
    }
}
