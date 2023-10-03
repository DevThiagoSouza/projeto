namespace ProjetoEditora
{
    partial class FormEditora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLivros = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.Panel();
            this.btnAddAutor = new System.Windows.Forms.Button();
            this.btnAddEditora = new System.Windows.Forms.Button();
            this.btnAddLivro = new System.Windows.Forms.Button();
            this.btnCadatro = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.CadastroTImer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseHome = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseHome)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.Container);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 603);
            this.sidebar.MinimumSize = new System.Drawing.Size(78, 603);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(78, 603);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::ProjetoEditora.Properties.Resources.hambuger;
            this.btnMenu.Location = new System.Drawing.Point(27, 30);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 32);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::ProjetoEditora.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(197, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLivros);
            this.panel3.Location = new System.Drawing.Point(3, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 47);
            this.panel3.TabIndex = 2;
            // 
            // btnLivros
            // 
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Image = global::ProjetoEditora.Properties.Resources.books;
            this.btnLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.Location = new System.Drawing.Point(0, 3);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLivros.Size = new System.Drawing.Size(197, 40);
            this.btnLivros.TabIndex = 0;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // Container
            // 
            this.Container.Controls.Add(this.btnAddAutor);
            this.Container.Controls.Add(this.btnAddEditora);
            this.Container.Controls.Add(this.btnAddLivro);
            this.Container.Controls.Add(this.btnCadatro);
            this.Container.Location = new System.Drawing.Point(3, 215);
            this.Container.MaximumSize = new System.Drawing.Size(197, 186);
            this.Container.MinimumSize = new System.Drawing.Size(197, 47);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(197, 48);
            this.Container.TabIndex = 1;
            // 
            // btnAddAutor
            // 
            this.btnAddAutor.FlatAppearance.BorderSize = 0;
            this.btnAddAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAutor.ForeColor = System.Drawing.Color.White;
            this.btnAddAutor.Image = global::ProjetoEditora.Properties.Resources.addAutor;
            this.btnAddAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAutor.Location = new System.Drawing.Point(-3, 141);
            this.btnAddAutor.Name = "btnAddAutor";
            this.btnAddAutor.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddAutor.Size = new System.Drawing.Size(197, 40);
            this.btnAddAutor.TabIndex = 3;
            this.btnAddAutor.Text = "Autor";
            this.btnAddAutor.UseVisualStyleBackColor = true;
            this.btnAddAutor.Click += new System.EventHandler(this.btnAddAutor_Click);
            // 
            // btnAddEditora
            // 
            this.btnAddEditora.FlatAppearance.BorderSize = 0;
            this.btnAddEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditora.ForeColor = System.Drawing.Color.White;
            this.btnAddEditora.Image = global::ProjetoEditora.Properties.Resources.addEditor;
            this.btnAddEditora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEditora.Location = new System.Drawing.Point(-3, 95);
            this.btnAddEditora.Name = "btnAddEditora";
            this.btnAddEditora.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAddEditora.Size = new System.Drawing.Size(197, 40);
            this.btnAddEditora.TabIndex = 2;
            this.btnAddEditora.Text = " Editora";
            this.btnAddEditora.UseVisualStyleBackColor = true;
            this.btnAddEditora.Click += new System.EventHandler(this.btnAddEditora_Click);
            // 
            // btnAddLivro
            // 
            this.btnAddLivro.FlatAppearance.BorderSize = 0;
            this.btnAddLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLivro.ForeColor = System.Drawing.Color.White;
            this.btnAddLivro.Image = global::ProjetoEditora.Properties.Resources.addLivro;
            this.btnAddLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLivro.Location = new System.Drawing.Point(-3, 49);
            this.btnAddLivro.Name = "btnAddLivro";
            this.btnAddLivro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddLivro.Size = new System.Drawing.Size(197, 40);
            this.btnAddLivro.TabIndex = 1;
            this.btnAddLivro.Text = " Livro";
            this.btnAddLivro.UseVisualStyleBackColor = true;
            this.btnAddLivro.Click += new System.EventHandler(this.btnAddLivro_Click);
            // 
            // btnCadatro
            // 
            this.btnCadatro.FlatAppearance.BorderSize = 0;
            this.btnCadatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadatro.ForeColor = System.Drawing.Color.White;
            this.btnCadatro.Image = global::ProjetoEditora.Properties.Resources.mais;
            this.btnCadatro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadatro.Location = new System.Drawing.Point(-3, 3);
            this.btnCadatro.MaximumSize = new System.Drawing.Size(197, 40);
            this.btnCadatro.Name = "btnCadatro";
            this.btnCadatro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCadatro.Size = new System.Drawing.Size(197, 40);
            this.btnCadatro.TabIndex = 0;
            this.btnCadatro.Text = "      Cadastro";
            this.btnCadatro.UseVisualStyleBackColor = true;
            this.btnCadatro.Click += new System.EventHandler(this.btnCadatro_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // CadastroTImer
            // 
            this.CadastroTImer.Interval = 10;
            this.CadastroTImer.Tick += new System.EventHandler(this.CadastroTImer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoEditora.Properties.Resources.fundoLeitura;
            this.pictureBox1.Location = new System.Drawing.Point(394, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseHome
            // 
            this.btnCloseHome.Image = global::ProjetoEditora.Properties.Resources.fechar_janela;
            this.btnCloseHome.Location = new System.Drawing.Point(1095, 3);
            this.btnCloseHome.Name = "btnCloseHome";
            this.btnCloseHome.Size = new System.Drawing.Size(30, 25);
            this.btnCloseHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseHome.TabIndex = 1;
            this.btnCloseHome.TabStop = false;
            this.btnCloseHome.Click += new System.EventHandler(this.btnCloseHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome: Thiago Soares de Souza RA:N302941";
            // 
            // FormEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1137, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCloseHome);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnCadatro;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Button btnAddLivro;
        private System.Windows.Forms.Timer CadastroTImer;
        private System.Windows.Forms.Button btnAddAutor;
        private System.Windows.Forms.Button btnAddEditora;
        private System.Windows.Forms.PictureBox btnCloseHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

