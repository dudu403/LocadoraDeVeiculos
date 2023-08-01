
using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel
{
    public class ControladorGrupoAutomovel : ControladorBase
    {
        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;

        private TabelaGrupoAutomovelControl tabelaGrupoAutomovel;

        private ServicoGrupoAutomovel servicoGrupoAutomovel;

        public ControladorGrupoAutomovel(IRepositorioGrupoAutomovel repositorioGrupoAutomovel, ServicoGrupoAutomovel servicoGrupoAutomovel)
        {
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.servicoGrupoAutomovel = servicoGrupoAutomovel;
        }

        public override void Inserir()
        {
            TelaGrupoAutomovelForm tela = new();

            tela.onGravarRegistro += servicoGrupoAutomovel.Inserir;

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

            GrupoAutomovel grupoAutomovelSelecionado = repositorioGrupoAutomovel.SelecionarPorId(id);

            if (grupoAutomovelSelecionado == null)
            {
                MessageBox.Show("Selecione um grupo de automovel primeiro",
                "Edição de Grupo De Automovel", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaGrupoAutomovelForm tela = new TelaGrupoAutomovelForm();

            tela.onGravarRegistro += servicoGrupoAutomovel.Editar;

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

            GrupoAutomovel grupoAutomovelSelecionado = repositorioGrupoAutomovel.SelecionarPorId(id);

            if (grupoAutomovelSelecionado == null)
            {
                MessageBox.Show("Selecione um grupo de automovel primeiro",
                "Exclusão de Grupo de Automovel", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = 
               MessageBox.Show($"Deseja realmente excluir o grupo de automovel \"{grupoAutomovelSelecionado}\"?",
               "Exclusão de Grupo de Automovel",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoGrupoAutomovel.Excluir(grupoAutomovelSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Grupo de Automovel",
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
            List<GrupoAutomovel> grupoAutomoveis = repositorioGrupoAutomovel.SelecionarTodos();

            tabelaGrupoAutomovel.AtualizarRegistros(grupoAutomoveis);

            mensagemRodape = string.Format("Visualizando {0} grupo{1} de automoveis", grupoAutomoveis.Count, grupoAutomoveis.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
    }
}
