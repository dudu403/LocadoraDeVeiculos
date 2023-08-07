using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;

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

        private void CarregarClientes(List<Cliente> clientes)
        {
            cmbCliente.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                //string exibicao = $"{cliente.nome} ({cliente.tipoPessoa})";
                cmbCliente.Items.Add(cliente);
            }
        }


        public void ConfigurarTela(Condutor condutorSelecionado)
        {
            this.condutor = condutorSelecionado;

            cmbCliente.SelectedItem = condutorSelecionado.cliente;
            txtNome.Text = condutorSelecionado.nome;
            txtEmail.Text = condutorSelecionado.email;
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
            condutor.validadeCnh = (txtData.Value);

            return condutor;
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
                        TelaPrincipalForm.Tela.AtualizarRodape("Pessoa Jurídica não pode ser condutora, selecione uma Pessoa Física");
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
            else
            {
                //DesabilitarCampos();
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
    }
}
