using Correios.NET.Models;
using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente { get; set; }

        private bool permitirDigitar = false;

        public event GravarRegistroDelegate<Cliente> onGravarRegistro;

        public TelaClienteForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            this.cliente = clienteSelecionado;

            txtNome.Text = clienteSelecionado.nome;
            txtEmail.Text = clienteSelecionado.email;
            txtTelefone.Text = clienteSelecionado.telefone;

            txtRadioPessoaFisica.Checked = clienteSelecionado.tipoPessoa == "Pessoa Física";
            txtRadioPessoaJuridica.Checked = clienteSelecionado.tipoPessoa == "Pessoa Jurídica";

            txtCpf.Text = clienteSelecionado.cpf;
            txtCnpj.Text = clienteSelecionado.cnpj;

            txtCep.Text = clienteSelecionado.cep;
            txtEstado.Text = clienteSelecionado.estado;
            txtCidade.Text = clienteSelecionado.cidade;
            txtBairro.Text = clienteSelecionado.bairro;
            txtRua.Text = clienteSelecionado.rua;
            txtNumero.Text = clienteSelecionado.numero.ToString();
        }

        public Cliente ObterCliente()
        {
            cliente.nome = txtNome.Text;
            cliente.email = txtEmail.Text;
            cliente.telefone = txtTelefone.Text;

            if (txtRadioPessoaFisica.Checked)
            {
                cliente.tipoPessoa = "Pessoa Física";
                cliente.cpf = txtCpf.Text;
                cliente.cnpj = null;
            }
            else if (txtRadioPessoaJuridica.Checked)
            {
                cliente.tipoPessoa = "Pessoa Jurídica";
                cliente.cpf = null;
                cliente.cnpj = txtCnpj.Text;
            }

            cliente.cep = txtCep.Text;
            cliente.estado = txtEstado.Text;
            cliente.cidade = txtCidade.Text;
            cliente.bairro = txtBairro.Text;
            cliente.rua = txtRua.Text;
            cliente.numero = Convert.ToInt32(txtNumero.Text);

            return cliente;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.cliente = ObterCliente();

            Result resultado = onGravarRegistro(cliente);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void txtRadioPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (txtRadioPessoaFisica.Checked)
            {
                txtCpf.Enabled = true;
                txtCnpj.Enabled = false;
                txtCnpj.Text = null;
            }
            else
            {
                txtCpf.Enabled = false;
            }
        }

        private void txtRadioPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (txtRadioPessoaJuridica.Checked)
            {
                txtCnpj.Enabled = true;
                txtCpf.Enabled = false;
                txtCpf.Text = null;
            }
            else
            {
                txtCnpj.Enabled = false;
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCep.Text))
            {
                MessageBox.Show("O campo de CEP está vazio",
                    "Atenção!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                var CorreioService = new Correios.NET.CorreiosService();

                var retorno = await CorreioService.GetAddressesAsync(txtCep.Text);

                Address endereco = retorno.FirstOrDefault();

                if (endereco is null)
                {
                    MessageBox.Show("CEP não encontrado",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
                }

                txtEstado.Text = endereco.State;
                txtCidade.Text = endereco.City;
                txtRua.Text = endereco.Street;
                txtBairro.Text = endereco.District;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string s = Regex.Replace(t.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "0";

                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                t.Text = string.Format("{0:#,##0}", double.Parse(s));

                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
