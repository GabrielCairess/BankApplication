using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta = new Conta();
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Number = Convert.ToInt32(textoNumero.Text);
            formPrincipal.AdicionaConta(novaConta);

            textoNumero.Clear();
            textoTitular.Clear();
            MessageBox.Show("Cadastro feito com sucesso!");
        }
    }
}
