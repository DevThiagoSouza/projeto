namespace ProjetoEditora.Forms
{
    partial class frmAddEditoras
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.sigla = new System.Windows.Forms.TextBox();
            this.txtObsEdit = new System.Windows.Forms.Label();
            this.txtsigla = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.Label();
            this.Obs = new System.Windows.Forms.RichTextBox();
            this.NomeEditora = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(252, 416);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // sigla
            // 
            this.sigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sigla.Location = new System.Drawing.Point(25, 112);
            this.sigla.Name = "sigla";
            this.sigla.Size = new System.Drawing.Size(50, 20);
            this.sigla.TabIndex = 20;
            // 
            // txtObsEdit
            // 
            this.txtObsEdit.AutoSize = true;
            this.txtObsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsEdit.Location = new System.Drawing.Point(33, 164);
            this.txtObsEdit.Name = "txtObsEdit";
            this.txtObsEdit.Size = new System.Drawing.Size(128, 24);
            this.txtObsEdit.TabIndex = 19;
            this.txtObsEdit.Text = "Observação:";
            // 
            // txtsigla
            // 
            this.txtsigla.AutoSize = true;
            this.txtsigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsigla.Location = new System.Drawing.Point(21, 91);
            this.txtsigla.Name = "txtsigla";
            this.txtsigla.Size = new System.Drawing.Size(50, 18);
            this.txtsigla.TabIndex = 17;
            this.txtsigla.Text = "Sigla:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.AutoSize = true;
            this.txtNomeEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEditora.Location = new System.Drawing.Point(21, 29);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(148, 20);
            this.txtNomeEditora.TabIndex = 16;
            this.txtNomeEditora.Text = "Nome da Editora:";
            // 
            // Obs
            // 
            this.Obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Obs.Location = new System.Drawing.Point(36, 191);
            this.Obs.Name = "Obs";
            this.Obs.Size = new System.Drawing.Size(358, 174);
            this.Obs.TabIndex = 15;
            this.Obs.Text = "";
            // 
            // NomeEditora
            // 
            this.NomeEditora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NomeEditora.Location = new System.Drawing.Point(24, 54);
            this.NomeEditora.Name = "NomeEditora";
            this.NomeEditora.Size = new System.Drawing.Size(370, 20);
            this.NomeEditora.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(342, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAddEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.sigla);
            this.Controls.Add(this.txtObsEdit);
            this.Controls.Add(this.txtsigla);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.Obs);
            this.Controls.Add(this.NomeEditora);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEditoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox sigla;
        private System.Windows.Forms.Label txtObsEdit;
        private System.Windows.Forms.Label txtsigla;
        private System.Windows.Forms.Label txtNomeEditora;
        private System.Windows.Forms.RichTextBox Obs;
        private System.Windows.Forms.TextBox NomeEditora;
        private System.Windows.Forms.Button button2;
    }
}