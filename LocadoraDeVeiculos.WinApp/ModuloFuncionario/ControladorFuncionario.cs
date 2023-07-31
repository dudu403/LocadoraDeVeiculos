using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.WinApp.ModuloCliente;

namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase
    {
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        private IRepositorioFuncionario repositorioFuncionario;
        private TabelaFuncionarioControl tabelaFuncionario;
        private ServicoFuncionario servicoFuncionario;

        public ControladorFuncionario(IRepositorioFuncionario repositorioFuncionario, ServicoFuncionario servicoFuncionario)
        {
            this.servicoFuncionario = servicoFuncionario;
            this.repositorioFuncionario = repositorioFuncionario;
        }

        public override string ToolTipInserir => "Inserir novo Funcionario";
        public override string ToolTipEditar => "Editar Funcionario existente";
        public override string ToolTipExcluir => "Excluir Funcionario Selecionado";
        public override string ToolTipHome => "Home";

        public override bool InserirHabilitado => true;
        public override bool EditarHabilitado => true;
        public override bool ExcluirHabilitado => true;

        public override void Inserir()
        {
            TelaFuncionarioForm telaFuncionario = new (repositorioFuncionario.SelecionarTodos());

            DialogResult opcaoEscolhida = telaFuncionario.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Funcionario funcionario = telaFuncionario.ObterFuncionario();
                repositorioFuncionario.Inserir(funcionario);

                CarregarFuncionarios();
            }
        }

        public override void Editar()
        {
            Funcionario funcionarioSelecionado = ObterFuncionarioSelecionado();

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show($"Selecione um funcionario primeiro!",
                    "Edição de funcionarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaFuncionarioForm tela = new(repositorioFuncionario.SelecionarTodos());

            tela.ConfigurarTela(funcionarioSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Funcionario funcionario = tela.ObterFuncionario();

                repositorioFuncionario.Editar(funcionarioSelecionado);

                CarregarFuncionarios();
            }
        }


        public override void Excluir()
        {
            Funcionario funcionario = ObterFuncionarioSelecionado();

            if (funcionario == null)
            {
                MessageBox.Show($"Selecione um Funcionario primeiro!",
                    "Exclusão de Funcionarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            //if (repositorioAluguel.SelecionarTodos().Any(x => x.funcionario == funcionario))
            //{
            //    MessageBox.Show($"Não é possivel remover esse funcionario pois ele possuí vinculo com ao menos um Aluguel!",
            //        "Exclusão de funcionarios",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Exclamation);

            //    return;
            //}

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o funcionario {funcionario.nome}?", "Exclusão de funcionarios",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioFuncionario.Excluir(funcionario);

                CarregarFuncionarios();
            }
        }

        private Funcionario ObterFuncionarioSelecionado()
        {
            int id = tabelaFuncionario.ObterNumeroTesteSelecionado();

            return repositorioFuncionario.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            return new ConfiguracaoToolboxFuncionario();
            if (tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabelaFuncionario;
        }

        private void CarregarFuncionarios()
        {
            List<Funcionario> funcionarios = repositorioFuncionario.SelecionarTodos();
            tabelaFuncionario.AtualizarRegistros(funcionarios);
        }

        public override UserControl ObterListagem()
        {
            return "Cadastro de Funcionario";
        }
    }
}
