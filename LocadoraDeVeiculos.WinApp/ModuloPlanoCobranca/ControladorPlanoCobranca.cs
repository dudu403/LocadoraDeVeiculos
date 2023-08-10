using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Aplicacao.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca
{
    public class ControladorPlanoCobranca : ControladorBase
    {
        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        private IRepositorioPlanoCobranca repositorioPlanoCobranca;

        private TabelaPlanoCobrancaControl tabelaPlanoCobranca;

        private ServicoPlanoCobranca servicoPlanoCobranca;

        public ControladorPlanoCobranca(IRepositorioPlanoCobranca repositorioPlanoCobranca,
                                        ServicoPlanoCobranca servicoPlanoCobranca,
                                        IRepositorioGrupoAutomovel repositorioGrupoAutomovel)
        {
            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.servicoPlanoCobranca = servicoPlanoCobranca;
        }

        public override void Inserir()
        {
            if (repositorioGrupoAutomovel.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Grupo de Automovel para poder inserir seus planos de cobrança.",
                "Inserção de Plano de Cobrança",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaPlanoCobrancaForm tela = new(repositorioGrupoAutomovel.SelecionarTodos());

            tela.onGravarRegistro += servicoPlanoCobranca.Inserir;

            tela.ConfigurarTela(new PlanoCobranca());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarPlanoCobranca();
            }
        }

        public override void Editar()
        {
            Guid id = tabelaPlanoCobranca.ObterIdSelecionado();

            PlanoCobranca planoCobrancaSelecionado = repositorioPlanoCobranca.SelecionarPorId(id);

            if (planoCobrancaSelecionado == null)
            {
                MessageBox.Show("Selecione um Plano primeiro",
                "Edição de Plano",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaPlanoCobrancaForm tela = new TelaPlanoCobrancaForm(repositorioGrupoAutomovel.SelecionarTodos());

            tela.onGravarRegistro += servicoPlanoCobranca.Editar;

            tela.ConfigurarTela(planoCobrancaSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarPlanoCobranca();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaPlanoCobranca.ObterIdSelecionado();

            PlanoCobranca planoCobrancaSelecionado = repositorioPlanoCobranca.SelecionarPorId(id);

            if (planoCobrancaSelecionado == null)
            {
                MessageBox.Show("Selecione um plano primeiro",
                "Exclusão de Plano de Cobrança",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
               MessageBox.Show($"Deseja realmente excluir um plano \"{planoCobrancaSelecionado}\"?",
               "Exclusão de Plano",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoPlanoCobranca.Excluir(planoCobrancaSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Plano",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                CarregarPlanoCobranca();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxPlanoCobranca();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPlanoCobranca == null)
                tabelaPlanoCobranca = new TabelaPlanoCobrancaControl();

            CarregarPlanoCobranca();

            return tabelaPlanoCobranca;
        }

        private void CarregarPlanoCobranca()
        {
            List<PlanoCobranca> planoCobranca = repositorioPlanoCobranca.SelecionarTodos();

            tabelaPlanoCobranca.AtualizarRegistros(planoCobranca);

            mensagemRodape = string.Format("Visualizando {0} Plano{1}", planoCobranca.Count, planoCobranca.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);

        }
    }
}
