using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using System.Globalization;
using System.Text.RegularExpressions;

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
            this.funcionario = funcionarioSelecionado;

            txtNome.Text = funcionarioSelecionado.nome;
            txtData.Value = funcionarioSelecionado.dataAdimissao;
            txtSalario.Text = funcionarioSelecionado.salario.ToString();
        }

        public Funcionario ObterFuncionario()
        {
            funcionario.nome = txtNome.Text;
            funcionario.dataAdimissao = (txtData.Value);
            funcionario.salario = Convert.ToDecimal(txtSalario.Text);

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

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string s = Regex.Replace(t.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                t.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}

