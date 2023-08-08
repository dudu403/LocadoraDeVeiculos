using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloCondutor;
using LocadoraDeVeiculos.Aplicacao.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.WinApp.ModuloCondutor
{
    public class ControladorCondutor : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioCondutor repositorioCondutor;

        private TabelaCondutorControl tabelaCondutor;

        private ServicoCondutor servicoCondutor;

        public ControladorCondutor(IRepositorioCondutor repositorioCondutor, ServicoCondutor servicoCondutor, IRepositorioCliente repositorioCliente)
        {
            this.repositorioCondutor = repositorioCondutor;
            this.repositorioCliente = repositorioCliente;
            this.servicoCondutor = servicoCondutor;
        }

        public override void Inserir()
        {
            TelaCondutorForm tela = new(repositorioCliente.SelecionarTodos());

            tela.onGravarRegistro += servicoCondutor.Inserir;

            tela.ConfigurarTela(new Condutor());

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                CarregarCondutores();
            }
        }

        public override void Editar()
        {
            Guid id = tabelaCondutor.ObterIdSelecionado();

            Condutor condutorSelecionado = repositorioCondutor.SelecionarPorId(id);

            if (condutorSelecionado == null)
            {
                MessageBox.Show("Selecione um condutor primeiro",
                "Edição de Condutor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaCondutorForm tela = new TelaCondutorForm(repositorioCliente.SelecionarTodos());

            tela.onGravarRegistro += servicoCondutor.Editar;

            tela.ConfigurarTela(condutorSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarCondutores();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaCondutor.ObterIdSelecionado();

            Condutor condutorSelecionado = repositorioCondutor.SelecionarPorId(id);

            if (condutorSelecionado == null)
            {
                MessageBox.Show("Selecione um condutor primeiro",
                "Exclusão de Condutor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
               MessageBox.Show($"Deseja realmente excluir um condutor \"{condutorSelecionado}\"?",
               "Exclusão de Cupom",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCondutor.Excluir(condutorSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Condutor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                CarregarCondutores();
            }
        }

        private void CarregarCondutores()
        {
            List<Condutor> condutor = repositorioCondutor.SelecionarTodos();

            tabelaCondutor.AtualizarRegistros(condutor);

            mensagemRodape = string.Format("Visualizando {0} condutores{1}", condutor.Count, condutor.Count == 1 ? "" : "res");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }


        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxCondutor();
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCondutor == null)
                tabelaCondutor = new TabelaCondutorControl();

            CarregarCondutores();

            return tabelaCondutor;
            
        }
    }
}
