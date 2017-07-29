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
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroContas;
        public Conta account, accountPoupanca;
        public Cliente client, clientPoupanca;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];

            Conta c1 = new Conta();
            c1.Titular = new Cliente("victor");
            c1.Number = 1;
            AdicionaConta(c1);
            Conta c2 = new Conta();
            c2.Titular = new Cliente("mauricio");
            c2.Number = 2;
            AdicionaConta(c2);
            Conta c3 = new Conta();
            c3.Titular = new Cliente("osni");
            c3.Number = 3;
            AdicionaConta(c3);
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            int i = comboContas.SelectedIndex;
            Conta selected = contas[i];
            string value = textValue.Text;
            double valueOperation = Convert.ToDouble(value);
            selected.Deposit(valueOperation);
            //accountPoupanca.Deposit(valueOperation);
            textValue.Clear();
            textBalance.Text = Convert.ToString(selected.Balance);
            //textBalance.Text = Convert.ToString(accountPoupanca.Balance);
            MessageBox.Show("Depósito realizado com sucesso!");
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            int i = comboContas.SelectedIndex;
            Conta selected = contas[i];
            string value = textValue.Text;
            double valueOperation = Convert.ToDouble(value);
            selected.Withdraw(valueOperation);
            //accountPoupanca.Withdraw(valueOperation);
            textValue.Clear();
            textBalance.Text = Convert.ToString(selected.Balance);
            //textBalance.Text = Convert.ToString(accountPoupanca.Balance);
            MessageBox.Show("Saque realizado com sucesso!");

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboContas.SelectedIndex;
            Conta selected = contas[i];

            textTitular.Text = selected.Titular.Name;
            textNumber.Text = Convert.ToString(selected.Number);
            textBalance.Text = Convert.ToString(selected.Balance);
        }

        private void new_account_Click(object sender, EventArgs e)
        {
            FormCadastroConta formCadastro = new FormCadastroConta(this);
            formCadastro.ShowDialog();
        }

        public void AdicionaConta (Conta conta)
        {
            contas[this.numeroContas] = conta;
            numeroContas++;
            comboContas.Items.Add(conta.Titular.Name);
        }
    }
}
