using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using System.Globalization;

namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario
{
    public partial class TelaFuncionarioForm : Form
    {
        private Funcionario funcionario { get; set; }
        private Funcionario funcionarioSelecionado { get; set; }
        private List<Funcionario> funcionarios { get; set; }
        public TelaFuncionarioForm(List<Funcionario> funcionarios)
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }
        public void ConfigurarTela(Funcionario funcionarioSelecionado)
        {
            txtId.Text = funcionarioSelecionado.id.ToString().Trim();
            txtNome.Text = funcionarioSelecionado.nome;
            txtData.Value = funcionarioSelecionado.dataAdmissao;
            txtSalario.Text = funcionario.salario.ToString();
            //txtValorEntrada.Text = (String.Format("{0:0.00}", aluguel.pagamento.valorEntrada).ToString());

            this.funcionarioSelecionado = funcionarioSelecionado;

        }
        public Funcionario ObterFuncionario()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            DateOnly dataAdmissao = DateOnly.FromDateTime(txtData.Value);
            string salario = txtSalario.Text;

            return new Funcionario(nome, salario, dataAdmissao);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            funcionario.nome = txtNome.Text;
            funcionario.salario = (decimal)Convert.ToDouble(txtSalario.Text.Replace("R$", string.Empty).Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            funcionario.dataAdmissao = txtData.Value;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
        }
    }
}
