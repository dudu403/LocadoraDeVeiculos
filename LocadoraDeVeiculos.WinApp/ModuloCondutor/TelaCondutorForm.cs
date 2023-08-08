using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloCondutor
{
    public partial class TelaCondutorForm : Form
    {
        private Condutor condutor;

        public event GravarRegistroDelegate<Condutor> onGravarRegistro;

        public TelaCondutorForm(List<Cliente> clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarClientes(clientes);
        }

        public void ConfigurarTela(Condutor condutorSelecionado)
        {
            this.condutor = condutorSelecionado;

            cmbCliente.SelectedItem = condutorSelecionado.cliente;
            txtNome.Text = condutorSelecionado.nome;
            txtEmail.Text = condutorSelecionado.email;
            txtTelefone.Text = condutorSelecionado.telefone;
            txtCpf.Text = condutorSelecionado.cpf;
            txtCnh.Text = condutorSelecionado.cnh;
            txtData.Value = condutorSelecionado.validadeCnh;
        }

        public Condutor ObterCondutor()
        {
            condutor.cliente = (Cliente)cmbCliente.SelectedItem;
            condutor.nome = txtNome.Text;
            condutor.email = txtEmail.Text;
            condutor.telefone = txtTelefone.Text;
            condutor.cpf = txtCpf.Text;
            condutor.cnh = txtCnh.Text;
            condutor.validadeCnh = Convert.ToDateTime(txtData.Value);

            return condutor;
        }

        private void checkClienteCondutor_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem is Cliente clienteSelecionado)
            {
                if (checkClienteCondutor.Checked)
                {
                    if (clienteSelecionado.tipoPessoa == "Pessoa Física")
                    {
                        DesabilitarCampos();

                        txtNome.Text = clienteSelecionado.nome;
                        txtEmail.Text = clienteSelecionado.email;
                        txtCpf.Text = clienteSelecionado.cpf;
                        txtTelefone.Text = clienteSelecionado.telefone;
                    }
                    else if (clienteSelecionado.tipoPessoa == "Pessoa Jurídica")
                    {
                        TelaPrincipalForm.Tela.AtualizarRodape("Pessoa Jurídica não pode ser condutora, selecione uma Pessoa Física ou cadastre um condutor para essa Pessoa Jurídica.");
                        checkClienteCondutor.Checked = false;
                        LimparCampos();
                        HabilitarCampos();
                    }
                }
                else
                {
                    LimparCampos();
                    HabilitarCampos();
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem is Cliente clienteSelecionado)
            {
                if (checkClienteCondutor.Checked && clienteSelecionado.tipoPessoa == "Pessoa Física")
                {
                    DesabilitarCampos();

                    txtNome.Text = clienteSelecionado.nome;
                    txtEmail.Text = clienteSelecionado.email;
                    txtCpf.Text = clienteSelecionado.cpf;
                    txtTelefone.Text = clienteSelecionado.telefone;

                    checkClienteCondutor.Checked = true;
                }
                else if (checkClienteCondutor.Checked == true && clienteSelecionado.tipoPessoa == "Pessoa Jurídica")
                {
                    checkClienteCondutor.Checked = false;
                    LimparCampos();
                    HabilitarCampos();
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.condutor = ObterCondutor();

            Result resultado = onGravarRegistro(condutor);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            cmbCliente.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                cmbCliente.Items.Add(cliente);
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtCpf.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtCpf.Enabled = true;
            txtTelefone.Enabled = true;
        }

        private void txtCnh_KeyPress(object sender, KeyPressEventArgs e)
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
