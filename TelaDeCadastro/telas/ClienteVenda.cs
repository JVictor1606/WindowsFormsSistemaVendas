using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeCadastro.model;
using TelaDeCadastro.repositorio;

namespace TelaDeCadastro.telas
{
    public partial class ClienteVenda : Form
    {
        public Cliente _cliente;
        public Venda _venda;
        public ClienteVenda()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void txtNomeDados_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtCpfDados_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtCpfDados.Text = _cliente.cpf;
        }
        private void txtDataNascimentoDados_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtDataNascimentoDados.Text = _cliente.dataNascimento.ToString("dd/MM/yyyy");
        }
        private void rdbSexoDados_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSexoDados.Checked )
            {
                _cliente.sexo = 'M';
            }
            else
            {
                _cliente.sexo = 'F';
            }

        }
        public void PreencherCliente(Cliente cliente)
        {
            txtNomeDados.Text = cliente.nome;
            txtCpfDados.Text = cliente.cpf.ToString();
            txtDataNascimentoDados.Text = cliente.dataNascimento.ToString("dd/MM/yyyy");
            rdbSexoDados.Checked = (cliente.sexo == 'M');
            rdbFemininoDados.Checked = (cliente.sexo == 'F');
        }
        public void PreencherGrid(List<Venda> vendas)
        {
            listViewClienteVenda.Items.Clear();

            foreach (var item in vendas)
            {
                ListViewItem it = new ListViewItem();
                it.Tag = item;
                it.Text = item.id.ToString();
                it.SubItems.Add(item.nomeProduto);
                it.SubItems.Add(item.unidade);
                it.SubItems.Add(item.quantidade);
                it.SubItems.Add(item.precoUnitario);
                it.SubItems.Add(item.valorTotal);
                listViewClienteVenda.Items.Add(it);
            }
        }
        private void ClienteVenda_Load(object sender, EventArgs e)
        {
            if (_cliente == null)
            {
                _cliente = new Cliente();
            }
            else
            {
                PreencherCliente(_cliente);
                List<Venda> lista = new VendaRepositorio().SelecionarTodos();
                PreencherGrid(lista);
            }
        }
        private void btnAdicionarVenda_Click(object sender, EventArgs e)
        {
            CadastroVendaTela tela = new CadastroVendaTela();
            tela.ShowDialog();
        }
    }
}
