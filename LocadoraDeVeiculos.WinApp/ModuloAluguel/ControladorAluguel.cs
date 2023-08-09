using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;
using LocadoraDeVeiculos.Aplicacao.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Aplicacao.ModuloTaxaEServico;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;
using LocadoraDeVeiculos.Infra.Orm.ModuloAluguel;
using LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro;
using LocadoraDeVeiculos.WinApp.ModuloFuncionario;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IRepositorioTaxaEServico repositorioTaxaEServico;
        private IRepositorioCondutor repositorioCondutor;
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        private IRepositorioPlanoCobranca repositorioPlanoCobranca;

        private IRepositorioAluguel repositorioAluguel;

        private TabelaAluguelControl tabelaAluguel;

        private ServicoAluguel servicoAluguel;

        public ControladorAluguel( IRepositorioFuncionario repositorioFuncionario,
                                   IRepositorioTaxaEServico repositorioTaxaEServico,
                                   IRepositorioCondutor repositorioCondutor,
                                   IRepositorioAutomovel repositorioAutomovel,
                                   IRepositorioGrupoAutomovel repositorioGrupoAutomovel,
                                   IRepositorioPlanoCobranca repositorioPlanoCobranca,
                                   IRepositorioAluguel repositorioAluguel,
                                   ServicoAluguel servicoAluguel)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioTaxaEServico = repositorioTaxaEServico;
            this.repositorioCondutor = repositorioCondutor;
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
            this.servicoAluguel = servicoAluguel;
    }


        public override void Inserir()
        {
            if (repositorioFuncionario.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Funcionario para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioCondutor.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Condutor para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioAutomovel.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Automovel para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioTaxaEServico.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Condutor para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            //if (repositorioPlanoCobranca.SelecionarTodos().All(p => p.grupoAutomovel) == 0)
            //{
            //    MessageBox.Show("Você deve cadastrar ao menos um Condutor para poder cadastrar um Auguel.",
            //    "Cadastro de Aluguel",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);
            //    return;
            //}

            //TelaCadastroAluguelForm tela = new();

            //tela.onGravarRegistro += servicoTaxaEServico.Inserir;

            //tela.ConfigurarTaxaEServico(new TaxaEServico());

            //DialogResult resultado = tela.ShowDialog();

            //if (resultado == DialogResult.OK)
            //{
            //    carregarAlugueis();
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
            //    CarregarAlugueis();
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
               MessageBox.Show($"Deseja realmente excluir o aluguel \"{aluguelSelecionado}\"?",
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

            //    CarregarAlugueis();
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

            CarregarAlugueis();

            return tabelaAluguel;
        }
    
        public void CarregarAlugueis()
        {
            List<Aluguel> aluguels = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(aluguels);

            mensagemRodape = string.Format("Visualizando {0} alugue{1}", aluguels.Count, aluguels.Count == 1 ? "l" : "is");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
    }
}
