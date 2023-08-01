using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;
using System.Text.RegularExpressions;


namespace LocadoraDeVeiculos.WinApp.ModuloConfigPreco
{
    public partial class TelaConfigPrecoForm : Form
    {
        ConfiguracaoPreco configPreco { get; set; }

        public event GravarRegistroDelegate<ConfiguracaoPreco> onGravarRegistro;

        public TelaConfigPrecoForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public ConfiguracaoPreco ObterConfiguracaoPreco()
        {
            configPreco.precoGasolina = numPrecoGasolina.Value;
            configPreco.precoAlcool = numPrecoAlcool.Value;
            configPreco.precoDisel = numPrecoDisel.Value;
            configPreco.precoGas = numPrecoGas.Value;

            return configPreco;
        }

        public void ConfigurarTela(ConfiguracaoPreco configPreco)
        {
            this.configPreco = configPreco;

            numPrecoGasolina.Value = configPreco.precoGasolina;
            numPrecoAlcool.Value = configPreco.precoAlcool;
            numPrecoDisel.Value = configPreco.precoDisel;
            numPrecoGas.Value = configPreco.precoGas;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.configPreco = ObterConfiguracaoPreco();

            Result resultado = onGravarRegistro(configPreco);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void numPrecos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfigurarBoxNumUpDown(sender, e);
        }

        private void ConfigurarBoxNumUpDown(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                NumericUpDown num = (NumericUpDown)sender;
                string s = Regex.Replace(num.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                num.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                num.Select(num.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
