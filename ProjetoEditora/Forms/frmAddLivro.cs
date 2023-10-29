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
            Sql sql = new Sql();

            LivroModel livroModel = new LivroModel();
            livroModel.nome = txtNomeLivro.Text; 
            livroModel.anoPublicacao =Convert.ToInt32( txtAno.Text); 
            livroModel.isbn =Convert.ToDecimal( sbn.Text); 
            livroModel.observacao = txtObs.Text; 
          //  livroModel.ediid = int.Parse(txtEdiid.Text); 

            sql.NewBook(livroModel);
        }

    }
}
