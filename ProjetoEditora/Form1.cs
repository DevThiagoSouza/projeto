using ProjetoEditora.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEditora
{
    public partial class FormEditora : Form
    {
        bool sidebarExpand;
        bool sidebarCollapse;

        public FormEditora()
        {
            InitializeComponent();
            
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;

                if(sidebar.Width == sidebar.MinimumSize.Width ) 
                { 
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width ) 
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void CadastroTImer_Tick(object sender, EventArgs e)
        {
            if(sidebarCollapse) 
            {
                Container.Height += 10;
                if(Container.Height == Container.MaximumSize.Height)
                {
                    sidebarCollapse = false;
                    CadastroTImer.Stop();
                }
            }
            else
            {
                Container.Height -= 10;
                if(Container.Height == Container.MinimumSize.Height ) 
                { 
                    sidebarCollapse = true;
                    CadastroTImer.Stop();
                }
            }
        }

        private void btnCadatro_Click(object sender, EventArgs e)
        {
            CadastroTImer.Start();
        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            frmAddLivro addLivro = new frmAddLivro();
            addLivro.ShowDialog();
        }

        private void btnAddEditora_Click(object sender, EventArgs e)
        {
            frmAddEditoras addEditoras = new frmAddEditoras();
            addEditoras.ShowDialog();
        }

        private void btnAddAutor_Click(object sender, EventArgs e)
        {
            frmAddAutores addAutores = new frmAddAutores();
            addAutores.ShowDialog();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            frmLivros livros = new frmLivros();
            livros.ShowDialog();
        }

        private void btnCloseHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
