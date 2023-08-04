using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloTaxaEServico;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaEServico
{
    public class ControladorTaxaEServico : ControladorBase
    {
        private IRepositorioTaxaEServico repositorioTaxaEServico;

        private TabelaTaxaEServicoControl tabelaTaxaEServico;

        private ServicoTaxaEServico servicoTaxaEServico;

        public ControladorTaxaEServico(IRepositorioTaxaEServico repositorioTaxaEServico, ServicoTaxaEServico servicoTaxaEServico)
        {
            this.repositorioTaxaEServico = repositorioTaxaEServico;
            this.servicoTaxaEServico = servicoTaxaEServico;
        }

        public override void Inserir()
        {
            TelaTaxaEServicoForm tela = new();

            tela.onGravarRegistro += servicoTaxaEServico.Inserir;

            tela.ConfigurarTaxaEServico(new TaxaEServico());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTaxasEServicos();
            }
        }

        public override void Editar()
        {
            Guid id = tabelaTaxaEServico.ObterIdSelecionado();

            TaxaEServico taxaEServicoSelecionado = repositorioTaxaEServico.SelecionarPorId(id);

            if (taxaEServicoSelecionado == null)
            {
                MessageBox.Show("Selecione taxa/serviço primeiro",
                "Edição de Taxas e Serviços",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaTaxaEServicoForm tela = new TelaTaxaEServicoForm();

            tela.onGravarRegistro += servicoTaxaEServico.Editar;

            tela.ConfigurarTaxaEServico(taxaEServicoSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTaxasEServicos();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaTaxaEServico.ObterIdSelecionado();

            TaxaEServico taxaEServicoSelecionado = repositorioTaxaEServico.SelecionarPorId(id);

            if (taxaEServicoSelecionado == null)
            {
                MessageBox.Show("Selecione uma taxa/serviço primeiro",
                "Exclusão de Taxas e Serviços",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
               MessageBox.Show($"Deseja realmente excluir a taxa/serviço \"{taxaEServicoSelecionado}\"?",
               "Exclusão de Taxas e Serviços",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoTaxaEServico.Excluir(taxaEServicoSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Taxas ou Serviços",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                CarregarTaxasEServicos();
            }
        }

        private void CarregarTaxasEServicos()
        {
            List<TaxaEServico> taxasEServicos = repositorioTaxaEServico.SelecionarTodos();

            tabelaTaxaEServico.AtualizarRegistros(taxasEServicos);

            mensagemRodape = string.Format("Visualizando {0} taxa{1} ou serviço{2}", taxasEServicos.Count, taxasEServicos.Count == 1 ? "" : "s", taxasEServicos.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxTaxaEServico();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTaxaEServico == null)
                tabelaTaxaEServico = new TabelaTaxaEServicoControl();

            CarregarTaxasEServicos();

            return tabelaTaxaEServico;
        }
    }
}
