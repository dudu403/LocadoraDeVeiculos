using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using System.Globalization;

namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario
{
    public partial class TelaFuncionarioForm : Form
    {
        private Funcionario funcionario { get; set; }

        public event GravarRegistroDelegate<Funcionario> onGravarRegistro;

        public TelaFuncionarioForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public void ConfigurarTela(Funcionario funcionarioSelecionado)
        {
            txtNome.Text = funcionarioSelecionado.nome;
         //   txtData.Text = funcionarioSelecionado.dataAdimissao.ToString();
            txtSalario.Text = funcionario.salario.ToString();
            //txtValorEntrada.Text = (String.Format("{0:0.00}", aluguel.pagamento.valorEntrada).ToString());

        }
        public Funcionario ObterFuncionario()
        {
            string nome = txtNome.Text;
            DateOnly dataAdmissao = DateOnly.FromDateTime(txtData.Value);
            string salario = txtSalario.Text;

            if (funcionario.dataAdimissao > DateTimePicker.MinimumDateTime)
            {
                txtData.Value = funcionario.dataAdimissao;
            }
            else
                txtData.Value = DateTime.Now;


            return funcionario;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.funcionario = ObterFuncionario();

            Result resultado = onGravarRegistro(funcionario);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}

