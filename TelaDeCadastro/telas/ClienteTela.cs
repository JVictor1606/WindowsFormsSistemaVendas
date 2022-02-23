using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeCadastro.model;
using TelaDeCadastro.repositorio;

namespace TelaDeCadastro.telas
{
    public partial class ClienteTela : Form
    {
        public Cliente _cliente { get; set; }
        public ClienteTela()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtNascimento;
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    throw new Exception("Informe o nome do cliente");
                }
                if (!DateTime.TryParseExact(txtDataNascimento.Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out dtNascimento))
                {
                    throw new Exception("A data informada é invalida");
                }
                Cliente cliente = new Cliente();
                cliente.nome = txtNome.Text.Trim();
                cliente.cpf = txtCpf.Text.Trim();
                cliente.dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                cliente.sexo = rdbSexo.Checked ? 'M' : 'F';
                if (rdbSexo.Checked)
                {
                    cliente.sexo = 'M';
                }
                else
                {
                    cliente.sexo = 'F';
                }

                ClienteRepositorio repositorio = new ClienteRepositorio();
                if(_cliente.id < 1)
                {
                    repositorio.Insert(cliente);
                }
                else
                {
                    cliente.id = _cliente.id;
                    repositorio.Atualizar(cliente);
                }
                

                MessageBox.Show("O registro foi salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClienteTela_Load(object sender, EventArgs e)
        {
            if(_cliente == null)
            {
                _cliente = new Cliente();
            }
            else
            {
                PreencherCliente(_cliente);
            } 
        }
        
        public void PreencherCliente(Cliente cliente)
        {
            txtNome.Text = cliente.nome;
            txtCpf.Text = cliente.cpf;
            txtDataNascimento.Text = cliente.dataNascimento.ToString("dd/MM/yyyy");
            rdbSexo.Checked = (cliente.sexo == 'M');
            rdbFeminino.Checked = (cliente.sexo == 'F');
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
