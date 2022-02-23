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
    public partial class CadastroVendaTela : Form
    {
        public Cliente _cliente;
        public Venda _venda;
        public CadastroVendaTela()
        {
            InitializeComponent();
        }

        private void CadastroVendaTela_Load(object sender, EventArgs e)
        {
            if (_venda == null)
            {
                _venda = new Venda();
            }
            if(_venda.nomeVendedor == null)
            {
                _cliente = new Cliente();
            }
            if(_cliente.nome == _venda.nomeVendedor)
            {
                PreencherVendaCliente(_venda);
            }
            else
            {
                PreencherVenda(_venda);
            }
        }

        private void btnSalvarCadastroVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeProduto.Text))
                {
                    throw new Exception("Informe o nome do produto");
                }
                if (string.IsNullOrEmpty(txtNomeVendedor.Text))
                {
                    throw new Exception("Informe o nome do vendedor");
                }
                //else
                //{
                //    _cliente = new Cliente();
                //}

                Venda venda = new Venda();
                //venda.id = venda._id.id;
                venda.nomeProduto = txtNomeProduto.Text.Trim();
                venda.nomeVendedor = txtNomeVendedor.Text.Trim();
                venda.unidade = cmbUnidade.SelectedIndex.ToString();
                venda.quantidade = Convert.ToString(txtQuantidade.Text.Trim());
                venda.precoUnitario = Convert.ToString(txtPrecoUnitario.Text.Trim());
                venda.valorTotal = Convert.ToString(txtValorTotal.Text.Trim());

                VendaRepositorio repositorio = new VendaRepositorio();
                if (_venda.id < 1)
                {
                    repositorio.Insert(venda);
                }

                DialogResult yes = MessageBox.Show("Você tem certeza que deseja salvar essa venda?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == yes)
                {
                    MessageBox.Show("Parabéns, sua venda foi registrada", "Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PreencherVenda(Venda venda)
        {
            txtNomeProduto.Text = venda.nomeProduto;
            txtNomeVendedor.Text = venda.nomeVendedor;
            cmbUnidade.Text = venda.unidade;
            txtPrecoUnitario.Text = venda.precoUnitario;
            txtValorTotal.Text = venda.valorTotal;

            venda.nomeVendedor = _cliente.nome;
        }

        public void PreencherVendaCliente(Venda venda)
        {
             venda.nomeProduto = txtNomeProduto.Text ;
             venda.nomeVendedor = txtNomeVendedor.Text ;
             venda.unidade = cmbUnidade.Text ;
             venda.precoUnitario = txtPrecoUnitario.Text ;
            venda.valorTotal = txtValorTotal.Text;

            venda.nomeVendedor = _cliente.nome;
            venda.id = _cliente.id;
        }

        private void btnVerValorTotal_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = (Convert.ToDouble(txtQuantidade.Text) * Convert.ToDouble(txtPrecoUnitario.Text));
                txtValorTotal.Text = Convert.ToString("R$ " + resultado);

            }
            catch (Exception)
            {
                MessageBox.Show("Informe a quatidade do produto e o preço unitario", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
