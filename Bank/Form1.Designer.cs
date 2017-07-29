namespace Bank
{
    partial class Form1
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
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.textValue = new System.Windows.Forms.TextBox();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.titular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_account = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(157, 19);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(100, 20);
            this.textTitular.TabIndex = 0;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(157, 45);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(100, 20);
            this.textNumber.TabIndex = 1;
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(157, 71);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(100, 20);
            this.textBalance.TabIndex = 2;
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(157, 113);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(100, 20);
            this.textValue.TabIndex = 3;
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(157, 148);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(75, 23);
            this.deposit.TabIndex = 4;
            this.deposit.Text = "Deposito";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(67, 148);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(75, 23);
            this.withdraw.TabIndex = 5;
            this.withdraw.Text = "Saque";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // titular
            // 
            this.titular.AutoSize = true;
            this.titular.Location = new System.Drawing.Point(64, 26);
            this.titular.Name = "titular";
            this.titular.Size = new System.Drawing.Size(36, 13);
            this.titular.TabIndex = 6;
            this.titular.Text = "Titular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor";
            // 
            // new_account
            // 
            this.new_account.Location = new System.Drawing.Point(109, 203);
            this.new_account.Name = "new_account";
            this.new_account.Size = new System.Drawing.Size(75, 23);
            this.new_account.TabIndex = 10;
            this.new_account.Text = "Criar Conta";
            this.new_account.UseVisualStyleBackColor = true;
            this.new_account.Click += new System.EventHandler(this.new_account_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTitular);
            this.groupBox1.Controls.Add(this.deposit);
            this.groupBox1.Controls.Add(this.withdraw);
            this.groupBox1.Controls.Add(this.textNumber);
            this.groupBox1.Controls.Add(this.new_account);
            this.groupBox1.Controls.Add(this.textBalance);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.titular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(177, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 244);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(177, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 56);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(100, 19);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 3;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Conta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Label titular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button new_account;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboContas;
    }
}

