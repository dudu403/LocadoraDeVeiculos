using System.Text.Json;
using System.Text.Json.Serialization;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;

namespace LocadoraDeVeiculos.Infra.Json.ModuloConfigPreco
{
    public class RepositorioConfigPrecoEmJson : IRepositorioConfiguracaoPreco
    {

        private const string NOME_ARQUIVO = "Compartilhado//ConfigConfiguracaoPreco.json";

        public ConfiguracaoPreco configuracaoPreco { get; set; }

        public RepositorioConfigPrecoEmJson(bool carregarDados)
        {
            if(carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarConfiguracaoPrecoEmArquivoJson(ConfiguracaoPreco novoConfiguracaoPreco)
        {
            configuracaoPreco = novoConfiguracaoPreco;

            File.WriteAllText(NOME_ARQUIVO, JsonSerializer.Serialize(novoConfiguracaoPreco, ObterConfiguracoes()));
        }

        public ConfiguracaoPreco ObterConfiguracaoPreco()
        {
            return configuracaoPreco;
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO) && File.ReadAllText(NOME_ARQUIVO).Length > 0)
                configuracaoPreco = JsonSerializer.Deserialize<ConfiguracaoPreco>(File.ReadAllText(NOME_ARQUIVO), config);
            else
                configuracaoPreco = new ConfiguracaoPreco();
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
