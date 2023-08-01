using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.ModuloCliente;
using LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase
    {
        private IRepositorioFuncionario repositorioFuncionario;

        private TabelaFuncionarioControl tabelaFuncionario;

        private readonly ServicoFuncionario servicoFuncionario;

       
        public ControladorFuncionario(IRepositorioFuncionario repositorioFuncionario,
                                        ServicoFuncionario servicoFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.servicoFuncionario = servicoFuncionario;
        }

        public override void Inserir()
        {
            TelaFuncionarioForm tela = new();

            tela.onGravarRegistro += servicoFuncionario.Inserir;

            tela.ConfigurarTela(new Funcionario());

            DialogResult resultado = tela.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                CarregarFuncionarios();
            }
        }

        public override void Editar()
        {
            Funcionario funcionarioSelecionado = ObterIdFuncionarioSelecionado();

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show($"Selecione um funcionario primeiro!",
                    "Edição de funcionarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaFuncionarioForm tela = new TelaFuncionarioForm ();

            tela.onGravarRegistro += servicoFuncionario.Editar;

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
            Funcionario funcionario = ObterIdFuncionarioSelecionado();

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

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxFuncionario();
        }

        private Funcionario ObterIdFuncionarioSelecionado()
        {
            int id = tabelaFuncionario.ObterNumeroFuncionarioSelecionado();

            return repositorioFuncionario.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabelaFuncionario;
        }
        private void CarregarFuncionarios()
        {
            List<Funcionario> funcionarios = repositorioFuncionario.SelecionarTodos();
            tabelaFuncionario.AtualizarRegistros(funcionarios);

            mensagemRodape = string.Format("Visualizando {0} funcionarios{1}", funcionarios.Count, funcionarios.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
    }
}
