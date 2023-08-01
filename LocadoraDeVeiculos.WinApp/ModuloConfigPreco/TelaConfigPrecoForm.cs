using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;

namespace LocadoraDeVeiculos.WinApp.ModuloConfigPreco
{
    public partial class TelaConfigPrecoForm : Form
    {
        ConfiguracaoPreco configPreco { get; set; }

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
            numPrecoGasolina.Value = configPreco.precoGasolina;
            numPrecoAlcool.Value = configPreco.precoAlcool;
            numPrecoDisel.Value = configPreco.precoDisel;
            numPrecoGas.Value = configPreco.precoGas;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void numPrecoGasolina_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
