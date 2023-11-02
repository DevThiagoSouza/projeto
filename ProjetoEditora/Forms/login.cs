using DocumentFormat.OpenXml.Spreadsheet;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEditora.Forms
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        
    
        public Login()
        {
            InitializeComponent();


            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if ( txtLogin.Text == "admin" && txtSenha.Text == "admin") 
            { 
            FormEditora formEditora = new FormEditora();
            formEditora.ShowDialog();
            Close();
            }
            else
            {
                MessageBox.Show("senha ou login esta incorreto");
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            
        }
    }
}
