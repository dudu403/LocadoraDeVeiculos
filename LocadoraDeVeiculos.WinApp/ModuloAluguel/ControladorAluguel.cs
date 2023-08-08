using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;
using LocadoraDeVeiculos.Aplicacao.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Infra.Orm.ModuloAluguel;
using LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro;
using LocadoraDeVeiculos.WinApp.ModuloFuncionario;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioCondutor repositorioCondutor;
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        private IRepositorioPlanoCobranca repositorioPlanoCobranca;

        private IRepositorioAluguel repositorioAluguel;

        private TabelaAluguelControl tabelaAluguel;

        private ServicoAluguel servicoAluguel;


        public ControladorAluguel(IRepositorioAluguel repositorioAluguel,
                                   IRepositorioFuncionario repositorioFuncionario,
                                   IRepositorioCliente repositorioCliente,
                                   IRepositorioCondutor repositorioCondutor,
                                   IRepositorioAutomovel repositorioAutomovel,
                                   IRepositorioGrupoAutomovel repositorioGrupoAutomovel,
                                   IRepositorioPlanoCobranca repositorioPlanoCobranca)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioCliente = repositorioCliente;
            this.repositorioCondutor = repositorioCondutor;
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
    }


        public override void Inserir()
        {
            //TelaCupomForm tela = new();
            //tela.onGravarRegistro += servicoAluguel.Inserir;
            //tela.ConfigurarTela(new Aluguel());
            //DialogResult resultado = tela.ShowDialog();

            //if (resultado == DialogResult.OK)
            //{
            //    CarregarAluguel();
            //}

        }

        public override void Editar()
        {
            Guid id = tabelaAluguel.ObterIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Edição de Alguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            //TelaCadastroAluguelForm tela = new TelaCadastroAluguelForm(repositorioAluguel.SelecionarTodos());

            //tela.onGravarRegistro += servicoAluguel.Editar;

            //tela.ConfigurarTela(aluguelSelecionado);

            //DialogResult resultado = tela.ShowDialog();

            //if (resultado == DialogResult.OK)
            //{
            //    CarregarAluguel();
            //}
        }

        public override void Excluir()
        {
            Guid id = tabelaAluguel.ObterIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Exclusão de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
               MessageBox.Show($"Deseja realmente excluir um aluguel \"{aluguelSelecionado}\"?",
               "Exclusão de Aluguel",
               MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            //if (opcaoEscolhida == DialogResult.OK)
            //{
            //    Result resultado = servicoAluguel.Excluir(aluguelSelecionado);

            //    if (resultado.IsFailed)
            //    {
            //        MessageBox.Show(resultado.Errors[0].Message,
            //            "Exclusão de Aluguel",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Error);

            //        return;
            //    }

            //    CarregarAluguel();
            //}
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxAluguel();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAluguel();

            return tabelaAluguel;
        }
    
        public void CarregarAluguel()
        {
            List<Aluguel> aluguels = repositorioAluguel.SelecionarTodos();
            tabelaAluguel.AtualizarRegistros(aluguels);
            mensagemRodape = string.Format("Visualizando {0} alugueis{1}", aluguels.Count, aluguels.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
    }
}
