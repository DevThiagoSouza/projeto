namespace ProjetoEditora.Forms
{
    partial class frmLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivros));
            this.dgLivros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbnFechar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLivros
            // 
            this.dgLivros.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgLivros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            this.dgLivros.Location = new System.Drawing.Point(12, 93);
            this.dgLivros.Name = "dgLivros";
            this.dgLivros.RowHeadersWidth = 15;
            this.dgLivros.Size = new System.Drawing.Size(776, 345);
            this.dgLivros.TabIndex = 1;
            this.dgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLivros_CellContentClick);
            this.dgLivros.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgLivros_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Livros";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pesquisa
            // 
            this.pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pesquisa.Location = new System.Drawing.Point(490, 25);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(204, 20);
            this.pesquisa.TabIndex = 7;
            this.pesquisa.Text = "Pesquisar";
            this.pesquisa.TextChanged += new System.EventHandler(this.pesquisa_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::ProjetoEditora.Properties.Resources.editar_48;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Click aqui para Editar";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Column1";
            this.dataGridViewImageColumn2.Image = global::ProjetoEditora.Properties.Resources.excluir_16;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Click aqui para excluir";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // tbnFechar
            // 
            this.tbnFechar.Image = global::ProjetoEditora.Properties.Resources.fechar_janela;
            this.tbnFechar.Location = new System.Drawing.Point(759, 12);
            this.tbnFechar.Name = "tbnFechar";
            this.tbnFechar.Size = new System.Drawing.Size(29, 25);
            this.tbnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tbnFechar.TabIndex = 2;
            this.tbnFechar.TabStop = false;
            this.tbnFechar.Click += new System.EventHandler(this.tbnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = global::ProjetoEditora.Properties.Resources.editar_24;
            this.editar.Name = "editar";
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.editar.ToolTipText = "Click aqui para Editar";
            this.editar.Width = 50;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Image = global::ProjetoEditora.Properties.Resources.excluir_16;
            this.excluir.Name = "excluir";
            this.excluir.ToolTipText = "Click aqui para excluir";
            this.excluir.Width = 50;
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnFechar);
            this.Controls.Add(this.dgLivros);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLivros";
            this.Load += new System.EventHandler(this.frmLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgLivros;
        private System.Windows.Forms.PictureBox tbnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
    }
}