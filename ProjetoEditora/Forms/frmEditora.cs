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
    public partial class frmEditora : Form
    {
        Sql sql;

        private void Carrega_Grid()
        {
            dtEditora.AutoGenerateColumns = true;
            dtEditora.DataSource = sql.allEditoras();

        }

        public frmEditora()
        {
            InitializeComponent();
        }

        private void frmEditora_Load(object sender, EventArgs e)
        {
            sql = new Sql();
            Carrega_Grid();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
