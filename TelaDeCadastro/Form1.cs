using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeCadastro.model;
using TelaDeCadastro.repositorio;
using TelaDeCadastro.telas;

namespace TelaDeCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoPesquisa.SelectedIndex = 0;
            List<Cliente> lista = new ClienteRepositorio().SelecionarTodos();
            PreencherGrid(lista);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja exluir mesmo esse registro? ", "Exluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Cliente cliente = (Cliente)listView1.SelectedItems[0].Tag;
                    new ClienteRepositorio().Delete(cliente.id);
                    List<Cliente> lista = new ClienteRepositorio().SelecionarTodos();
                    PreencherGrid(lista);
                }

            }
            else
            {
                MessageBox.Show("Selecione um item para excluir");
            }
        }
        private void PreencherGrid(List<Cliente> clientes)
        {
            listView1.Items.Clear();
      
            foreach (var item in clientes)
            {
                ListViewItem it = new ListViewItem();
                it.Tag = item;
                it.Text = item.nome;
                it.SubItems.Add(item.cpf);
                it.SubItems.Add(item.dataNascimento.ToString("dd/MM/yyyy"));
                it.SubItems.Add(item.sexo.ToString());
                listView1.Items.Add(it);
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            ClienteTela tela = new ClienteTela();
            tela.ShowDialog();
            List<Cliente> lista = new ClienteRepositorio().SelecionarTodos();
            PreencherGrid(lista);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Cliente cliente = (Cliente)listView1.SelectedItems[0].Tag;
                ClienteTela tela = new ClienteTela();
                tela._cliente = cliente;
                tela.ShowDialog();
                List<Cliente> lista = new ClienteRepositorio().SelecionarTodos();
                PreencherGrid(lista);
            }
        }

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            if(txtProcurarCliente.Text == string.Empty)
            {
                MessageBox.Show("Informe algo na pesquisa");
                return;
            }
            int tipoPesquisa = cmbTipoPesquisa.SelectedIndex;
            List<Cliente> lista = new ClienteRepositorio().Pesquisar(tipoPesquisa, txtProcurarCliente.Text.Trim());
            PreencherGrid(lista);
        }

        private void cmbTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Cliente cliente = (Cliente)listView1.SelectedItems[0].Tag;
                    ClienteVenda tela = new ClienteVenda();
                    tela._cliente = cliente;
                    tela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Você não escolheu o cliente\n Escolha o cliente para prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
