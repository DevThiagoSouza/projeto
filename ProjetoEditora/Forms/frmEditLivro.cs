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
    public partial class frmEditLivro : Form
    {
        Sql sql;
        private LivroModel _livro;
        public frmEditLivro(LivroModel livro)
        {
            InitializeComponent();
            _livro = livro;

            txtNomeLivro.Text = _livro.nome;
            txtAno.Text = _livro.anoPublicacao.ToString();
            sbn.Text = Convert.ToString(_livro.isbn);
            txtObs.Text = _livro.observacao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            _livro.nome = txtNomeLivro.Text;
            _livro.anoPublicacao = int.Parse(txtAno.Text);
            _livro.isbn = Convert.ToDecimal(sbn.Text);
            _livro.observacao = txtObs.Text;

            sql.Update(_livro);

            this.Close();
        }
    }
}
