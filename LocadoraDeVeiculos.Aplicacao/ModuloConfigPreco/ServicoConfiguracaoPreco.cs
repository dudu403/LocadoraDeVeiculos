using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;

namespace LocadoraDeVeiculos.Aplicacao.ModuloConfigPreco
{
    public class ServicoConfiguracaoPreco
    {
        private IRepositorioConfiguracaoPreco repositorioConfiguracaoPreco;
        private IValidadorConfiguracaoPreco validadorConfiguracaoPreco;

        public ServicoConfiguracaoPreco(IRepositorioConfiguracaoPreco repositorioConfiguracaoPreco, IValidadorConfiguracaoPreco validadorConfiguracaoPreco)
        {
            this.repositorioConfiguracaoPreco = repositorioConfiguracaoPreco;
            this.validadorConfiguracaoPreco = validadorConfiguracaoPreco;
        }

        public Result Inserir(ConfiguracaoPreco configuracaoPreco)
        {
            Log.Debug("Tentando inserir um grupo de automovel...{@d}", configuracaoPreco);

            List<string> erros = ValidarConfiguracaoPreco(configuracaoPreco);

            repositorioConfiguracaoPreco.ObterConfiguracaoPreco();

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioConfiguracaoPreco.GravarConfiguracaoPrecoEmArquivoJson(configuracaoPreco);

                Log.Debug("Grupo de automovel {ConfiguracaoPrecoId} inserido com sucesso", configuracaoPreco.id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir um grupo de automovel.";

                Log.Error(exc, msgErro + "{@d}", configuracaoPreco);

                return Result.Fail(msgErro); //cenário 3
            }
        }
        
        private List<string> ValidarConfiguracaoPreco(ConfiguracaoPreco configuracaoPreco)
        {
            var resultadoValidacao = validadorConfiguracaoPreco.Validate(configuracaoPreco);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
