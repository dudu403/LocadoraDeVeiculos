using FluentResults;
using LocadoraDeVeiculos.Aplicacao.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.WinApp.ModuloFuncionario;

namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    public class ControladorCupom : ControladorBase
    {
       
        private IRepositorioParceiro repositorioParceiro;
        private IRepositorioCupom repositorioCupom;

        private TabelaCupomControl tabelaCupom;

        private ServicoCupom servicoCupom;  

        public ControladorCupom(IRepositorioCupom repositorioCupom, 
                                ServicoCupom servicoCupom,
                                IRepositorioParceiro repositorioParceiro)
        {
            this.repositorioCupom = repositorioCupom;
            this.repositorioParceiro = repositorioParceiro;
            this.servicoCupom = servicoCupom;
        }

        public override void Inserir()
        {
            TelaCupomForm tela = new(repositorioParceiro.SelecionarTodos());

            tela.onGravarRegistro += servicoCupom.Inserir;

            tela.ConfigurarTela(new Cupom());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarCupons();
            }
        }

        public override void Editar()
        {
            Guid id = tabelaCupom.ObterIdSelecionado();

            Cupom cupomSelecionado = repositorioCupom.SelecionarPorId(id);

            if (cupomSelecionado == null)
            {
                MessageBox.Show("Selecione um cupom primeiro",
                "Edição de Cupom",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaCupomForm tela = new TelaCupomForm(repositorioParceiro.SelecionarTodos());

            tela.onGravarRegistro += servicoCupom.Editar;

            tela.ConfigurarTela(cupomSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarCupons();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaCupom.ObterIdSelecionado();

            Cupom cupomSelecionado = repositorioCupom.SelecionarPorId(id);

            if (cupomSelecionado == null)
            {
                MessageBox.Show("Selecione um cupom primeiro",
                "Exclusão de Cupom",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
               MessageBox.Show($"Deseja realmente excluir um cupom \"{cupomSelecionado}\"?",
               "Exclusão de Cupom",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoCupom.Excluir(cupomSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Cupom",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                CarregarCupons();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxCupom();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCupom == null)
                tabelaCupom = new TabelaCupomControl();

            CarregarCupons();

            return tabelaCupom;
        }

        private void CarregarCupons()
        {
            List<Cupom> cupom = repositorioCupom.SelecionarTodos();

            tabelaCupom.AtualizarRegistros(cupom);

            mensagemRodape = string.Format("Visualizando {0} cupons{1}", cupom.Count, cupom.Count == 1 ? "" : "s");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }
    }
}
