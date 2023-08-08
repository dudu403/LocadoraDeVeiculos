using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel
{
    public class ControladorAutomovel : ControladorBase
    {
        private IRepositorioAutomovel repositorioAutomovel;

        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;

        private TabelaAutomovelControl tabelaAutomovel;

        private ServicoAutomovel servicoAutomovel;

        public ControladorAutomovel(IRepositorioAutomovel repositorioAutomovel, IRepositorioGrupoAutomovel repositorioGrupoAutomovel, ServicoAutomovel servicoAutomovel)
        {
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.servicoAutomovel = servicoAutomovel;
        }

        public override void Inserir()
        {
            if (repositorioGrupoAutomovel.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Grupo de Automovel para poder inserir o cadastro de um automovel.",
                "Inserção de Automovel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaAutomovelForm tela = new(repositorioGrupoAutomovel.SelecionarTodos());

            tela.onGravarRegistro += servicoAutomovel.Inserir;

            tela.ConfigurarAutomovel(new Automovel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarAutomoveis();
            }
        }

        public override void Editar()
        {
            Guid id = tabelaAutomovel.ObterIdSelecionado();

            Automovel automovelSelecionado = repositorioAutomovel.SelecionarPorId(id);

            if (automovelSelecionado == null)
            {
                MessageBox.Show("Selecione um automovel primeiro",
                "Edição de Automovel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaAutomovelForm tela = new (repositorioGrupoAutomovel.SelecionarTodos());

            tela.onGravarRegistro += servicoAutomovel.Editar;

            tela.ConfigurarAutomovel(automovelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarAutomoveis();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaAutomovel.ObterIdSelecionado();

            Automovel automovelSelecionado = repositorioAutomovel.SelecionarPorId(id);

            if (automovelSelecionado == null)
            {
                MessageBox.Show("Selecione um automovel primeiro",
                "Exclusão de Automovel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
               MessageBox.Show($"Deseja realmente excluir o automovel \"{automovelSelecionado}\"?",
               "Exclusão de Automovel",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoAutomovel.Excluir(automovelSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Automovel",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                CarregarAutomoveis();
            }
        }

        private void CarregarAutomoveis()
        {
            List<Automovel> automoveis = repositorioAutomovel.SelecionarTodos();

            tabelaAutomovel.AtualizarRegistros(automoveis);

            mensagemRodape = string.Format("Visualizando {0} automove{1}", automoveis.Count, automoveis.Count == 1 ? "l" : "is");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxAutomovel();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAutomovel == null)
                tabelaAutomovel = new TabelaAutomovelControl();

            CarregarAutomoveis();

            return tabelaAutomovel;
        }
    }
}
