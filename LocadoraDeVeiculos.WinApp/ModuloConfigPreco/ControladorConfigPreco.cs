using LocadoraDeVeiculos.Aplicacao.ModuloConfigPreco;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;

namespace LocadoraDeVeiculos.WinApp.ModuloConfigPreco
{
    public class ControladorConfigPreco : ControladorBase
    {
        private IRepositorioConfiguracaoPreco repositorioConfiguracaoPreco;

        private TabelaConfigPrecoControl tabelaConfigPreco;

        private ServicoConfiguracaoPreco servicoConfiguracaoPreco;

        public ControladorConfigPreco(IRepositorioConfiguracaoPreco repositorioConfiguracaoPreco, ServicoConfiguracaoPreco servicoConfiguracaoPreco)
        {
            this.repositorioConfiguracaoPreco = repositorioConfiguracaoPreco;
            this.servicoConfiguracaoPreco = servicoConfiguracaoPreco;
        }

        public override void Configurar()
        {
            TelaConfigPrecoForm tela = new();

            ConfiguracaoPreco config = repositorioConfiguracaoPreco.ObterConfiguracaoPreco();

            tela.onGravarRegistro += servicoConfiguracaoPreco.Configurar;

            tela.ConfigurarTela(config);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioConfiguracaoPreco.GravarConfiguracaoPrecoEmArquivoJson(config);
                
                CarregarConfiguracoes();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxConfigPreco();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaConfigPreco == null)
                tabelaConfigPreco = new TabelaConfigPrecoControl();

            CarregarConfiguracoes();

            return tabelaConfigPreco;
        }

        private void CarregarConfiguracoes()
        {
            ConfiguracaoPreco configPreco = repositorioConfiguracaoPreco.ObterConfiguracaoPreco();

            tabelaConfigPreco.AtualizarRegistros(configPreco);

            mensagemRodape = string.Format("Visualizando preços configurados...");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
    }
}
