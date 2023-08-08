
using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel
{
    public class ControladorGrupoAutomovel : ControladorBase
    {
        private IRepositorioGrupoAutomovel repositorioGrupoAutomoveis;

        private TabelaGrupoAutomovelControl tabelaGrupoAutomovel;

        private ServicoGrupoAutomovel servicoGrupoAutomoveis;

        public ControladorGrupoAutomovel(IRepositorioGrupoAutomovel repositorioGrupoAutomoveis, ServicoGrupoAutomovel servicoGrupoAutomoveis)
        {
            this.repositorioGrupoAutomoveis = repositorioGrupoAutomoveis;
            this.servicoGrupoAutomoveis = servicoGrupoAutomoveis;
        }

        public override void Inserir()
        {
            TelaGrupoAutomovelForm tela = new();

            tela.onGravarRegistro += servicoGrupoAutomoveis.Inserir;

            tela.ConfigurarGrupoAutomovel(new GrupoAutomovel());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarGrupoAutomoveis();
            }
        }

        public override void Editar()
        {
            Guid id = tabelaGrupoAutomovel.ObterIdSelecionado();

            GrupoAutomovel grupoAutomovelSelecionado = repositorioGrupoAutomoveis.SelecionarPorId(id);

            if (grupoAutomovelSelecionado == null)
            {
                MessageBox.Show("Selecione um grupo de automovel primeiro",
                "Edição de Grupo De GrupoAutomovel", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaGrupoAutomovelForm tela = new TelaGrupoAutomovelForm();

            tela.onGravarRegistro += servicoGrupoAutomoveis.Editar;

            tela.ConfigurarGrupoAutomovel(grupoAutomovelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarGrupoAutomoveis();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaGrupoAutomovel.ObterIdSelecionado();

            GrupoAutomovel grupoAutomovelSelecionado = repositorioGrupoAutomoveis.SelecionarPorId(id);

            if (grupoAutomovelSelecionado == null)
            {
                MessageBox.Show("Selecione um grupo de automovel primeiro",
                "Exclusão de Grupo de GrupoAutomovel", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = 
               MessageBox.Show($"Deseja realmente excluir o grupo de automovel \"{grupoAutomovelSelecionado}\"?",
               "Exclusão de Grupo de GrupoAutomovel",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoGrupoAutomoveis.Excluir(grupoAutomovelSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Grupo de GrupoAutomovel",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);

                    return;
                }

                CarregarGrupoAutomoveis();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaGrupoAutomovel == null)
                tabelaGrupoAutomovel = new TabelaGrupoAutomovelControl();

            CarregarGrupoAutomoveis();

            return tabelaGrupoAutomovel;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxGrupoAutomovel();
        }

        private void CarregarGrupoAutomoveis()
        {
            List<GrupoAutomovel> grupoAutomoveis = repositorioGrupoAutomoveis.SelecionarTodos();

            tabelaGrupoAutomovel.AtualizarRegistros(grupoAutomoveis);

            mensagemRodape = string.Format("Visualizando {0} grupo{1} de automoveis", grupoAutomoveis.Count, grupoAutomoveis.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
    }
}
