namespace Bank
{
    partial class FormCadastroConta
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
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(147, 67);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(147, 104);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(48, 73);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(47, 13);
            this.Numero.TabIndex = 2;
            this.Numero.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titular: ";
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Location = new System.Drawing.Point(147, 166);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastro.TabIndex = 4;
            this.buttonCadastro.Text = "Cadastrar";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.textoNumero);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCadastro;
    }
}