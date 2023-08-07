using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;

        private TabelaClienteControl tabelaCliente;

        private ServicoCliente servicoCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente, ServicoCliente servicoCliente)
        {
            this.repositorioCliente = repositorioCliente;
            this.servicoCliente = servicoCliente;
        }
        public override void Inserir()
        {
            TelaClienteForm tela = new();

            tela.onGravarRegistro += servicoCliente.Inserir;

            tela.ConfigurarTela(new Cliente());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }
        }
        public override void Editar()
        {
            Guid id = tabelaCliente.ObterIdSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(id);

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm tela = new TelaClienteForm();

            tela.onGravarRegistro += servicoCliente.Editar;

            tela.ConfigurarTela(clienteSelecionado);

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                CarregarClientes();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaCliente.ObterIdSelecionado();

            Cliente cliente = repositorioCliente.SelecionarPorId(id);

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um Cliente primeiro!",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida =
                MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?",
                "Exclusão de clientes",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCliente.Excluir(cliente);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                    "Exclusão de clientes",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                    return;
                }

                CarregarClientes();
            }
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);

            mensagemRodape = string.Format("Visualizando {0} clientes{1}", clientes.Count, clientes.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxCliente();
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }
    }
}
