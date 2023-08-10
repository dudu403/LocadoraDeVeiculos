using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel { get; set; }
        private List<Cupom> todosCupons { get; set; }
        private ConfiguracaoPreco configPreco { get; set; }
        private List<TaxaEServico> todasTaxasEServicos { get; set; }

        public event GravarRegistroDelegate<Aluguel> onGravarRegistro;

        public TelaAluguelForm(ConfiguracaoPreco configPreco, List<Funcionario> funcionarios, List<Cliente> clientes, List<GrupoAutomovel> gruposAutomovel, List<Cupom> cupons, List<TaxaEServico> taxasEServicos)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarComboboxesIniciais(funcionarios, clientes, gruposAutomovel);

            this.todosCupons = cupons;

            this.configPreco = configPreco;

            listBoxTaxasIniciais.DataSource = taxasEServicos;

            this.todasTaxasEServicos = taxasEServicos;
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            this.aluguel = aluguelSelecionado;

            if (aluguel.grupoAutomovel == null)
                return;

            txtCupom.Text = aluguel.cupom.ToString();
            txtKmAutomovel.Text = aluguel.ToString();
            cmbCliente.SelectedItem = aluguel.cliente;
            txtDataLocacao.Value = aluguel.dataLocacao;
            cmbCondutor.SelectedItem = aluguel.condutor;
            cmbAutomovel.SelectedItem = aluguel.automovel;
            txtValorTotalPrevisto.Text = aluguel.ToString();
            cmbPCobranca.SelectedItem = aluguel.planoCobranca;
            cmbFuncionario.SelectedItem = aluguel.funcionario;
            cmbGAutomovel.SelectedItem = aluguel.grupoAutomovel;
            txtDataPrevista.Value = aluguel.dataPrevistaDevolucao;

            ConfigurarListaComCheck();
        }

        public void ConfigurarTelaDevolucao(Aluguel aluguelSelecionado)
        {
            this.aluguel = aluguelSelecionado;

            txtCupom.Text = aluguel.cupom.ToString();
            txtKmAutomovel.Text = aluguel.automovel.quilometragem.ToString();
            cmbCliente.SelectedItem = aluguel.cliente;
            txtDataLocacao.Value = aluguel.dataLocacao;
            cmbCondutor.SelectedItem = aluguel.condutor;
            cmbAutomovel.SelectedItem = aluguel.automovel;
            txtValorTotalPrevisto.Text = CalcularValorTotal().ToString();
            cmbPCobranca.SelectedItem = aluguel.planoCobranca;
            cmbFuncionario.SelectedItem = aluguel.funcionario;
            cmbGAutomovel.SelectedItem = aluguel.grupoAutomovel;
            txtDataPrevista.Value = aluguel.dataPrevistaDevolucao;

            ConfigurarListaComCheck();
            CarregarListaTaxasExtras();
        }

        private void ConfigurarListaComCheck()
        {
            for (int i = 0; i < todasTaxasEServicos.Count(); i++)
            {
                var item = listBoxTaxasIniciais.Items[i];

                if (aluguel.taxas.Contains(item))
                    listBoxTaxasIniciais.SetItemChecked(i, true);
                else
                    listBoxTaxasIniciais.SetItemChecked(i, false);
            }
        }

        public Aluguel ObterCadastroAluguel()
        {
            aluguel.cliente = (Cliente)cmbCliente.SelectedItem;
            aluguel.condutor = (Condutor)cmbCondutor.SelectedItem;
            aluguel.kmInicial = Convert.ToDecimal(txtKmAutomovel.Text);
            aluguel.automovel = (Automovel)cmbAutomovel.SelectedItem;
            aluguel.funcionario = (Funcionario)cmbFuncionario.SelectedItem;
            aluguel.planoCobranca = (PlanoCobranca)cmbPCobranca.SelectedItem;
            aluguel.grupoAutomovel = (GrupoAutomovel)cmbGAutomovel.SelectedItem;

            foreach (TaxaEServico tx in listBoxTaxasIniciais.CheckedItems)
            {
                aluguel.taxas.Add(tx);
            }

            aluguel.valorTotalPrevisto = CalcularValorTotal();

            return aluguel;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.aluguel = ObterCadastroAluguel();

            Result resultado = onGravarRegistro(aluguel);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnAplicarCupom_Click(object sender, EventArgs e)
        {
            if (todosCupons.Any(c => c.nome == txtCupom.Text))
            {
                aluguel.cupom = todosCupons.FirstOrDefault(c => c.nome == txtCupom.Text);

                TelaPrincipalForm.Tela.AtualizarRodape($"Seu cupom é valido e o valor de R$ {aluguel.cupom.valor} será aplicado no valor final do aluguel.");
            }
            else
            {
                TelaPrincipalForm.Tela.AtualizarRodape("Esse cupom não existe.");

                txtCupom.Text = string.Empty;
            }
        }

        public void ObterDevolucaoAluguel()
        {
            listBoxTaxasIniciais.Enabled = false;
            ConfigurarVisibilidade();
            ConfigurarDesabilitacao();
            CarregarNivelTanqueEnum();

            aluguel.kmPercorrido = Convert.ToDecimal(txtKmPercorrido.Text);

            aluguel.kmFinal = aluguel.kmPercorrido + aluguel.kmInicial;

            cmbNivelTanque.SelectedItem = aluguel.nivelTanque;

            aluguel.automovel.quilometragem = Convert.ToDecimal(aluguel.kmFinal);

            aluguel.valorTotalFinal = CalcularValorTotal();
        }

        private decimal CalcularValorTotal()
        {
            if (aluguel.planoCobranca.tipoPlano == TipoPlanoEnum.Cobrança_Diária)
            {
                int time = 1;//Convert.ToInt32(aluguel.dataPrevistaDevolucao - aluguel.dataLocacao);

                decimal valorComKm = Convert.ToDecimal(aluguel.planoCobranca.precoPorKm * aluguel.kmPercorrido);

                decimal valorgasolina = 0;

                return (time * aluguel.planoCobranca.precoDiaria) + valorComKm - aluguel.cupom.valor + valorgasolina;
            }
            if (aluguel.planoCobranca.tipoPlano == TipoPlanoEnum.Cobrança_Controlada)
            {
                int time = 1;//Convert.ToInt32(aluguel.dataPrevistaDevolucao - aluguel.dataLocacao);

                decimal valorExtrapolado = 0;

                if (aluguel.kmPercorrido > aluguel.planoCobranca.kmDisponiveis)
                {
                    valorExtrapolado = Convert.ToDecimal(aluguel.planoCobranca.precoPorKmExtrapolado * (aluguel.planoCobranca.kmDisponiveis - aluguel.kmPercorrido));
                }

                decimal valorgasolina = 0;

                return (time * aluguel.planoCobranca.precoDiaria) + valorExtrapolado - aluguel.cupom.valor + valorgasolina;
            }
            if (aluguel.planoCobranca.tipoPlano == TipoPlanoEnum.Cobrança_Km_Livre)
            {
                int time = 1;//Convert.ToInt32(aluguel.dataPrevistaDevolucao - aluguel.dataLocacao);

                decimal valorgasolina = 0;

                return (time * aluguel.planoCobranca.precoDiaria) - aluguel.cupom.valor + valorgasolina;
            }

            return 0;
        }

        private void ConfigurarDesabilitacao()
        {
            txtCupom.Enabled = false;
            cmbCliente.Enabled = false;
            cmbCondutor.Enabled = false;
            cmbPCobranca.Enabled = false;
            cmbAutomovel.Enabled = false;
            cmbGAutomovel.Enabled = false;
            txtDataLocacao.Enabled = false;
            txtKmAutomovel.Enabled = false;
            cmbFuncionario.Enabled = false;
            txtDataPrevista.Enabled = false;
            lblValorPrevisto.Visible = false;
            txtValorTotalPrevisto.Enabled = false;
            txtValorTotalPrevisto.Enabled = false;
            txtValorTotalPrevisto.Visible = false;
        }

        private void ConfigurarVisibilidade()
        {
            tabPage2.Visible = true;
            lblKmFinal.Visible = true;
            txtKmFinal.Visible = true;
            lblValorFinal.Visible = true;
            lblNivelTanque.Visible = true;
            cmbNivelTanque.Enabled = true;
            cmbNivelTanque.Visible = true;
            lblKmPercorrido.Visible = true;
            txtKmPercorrido.Enabled = true;
            txtKmPercorrido.Visible = true;
            lblDataDevolucao.Visible = true;
            txtDataDevolucao.Enabled = true;
            txtDataDevolucao.Visible = true;
            txtValorTotalFinal.Visible = true;
        }

        private void cmbAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAutomovel.SelectedItem != null)
            {
                aluguel.automovel = (Automovel)cmbAutomovel.SelectedItem;

                txtKmAutomovel.Text = aluguel.automovel.quilometragem.ToString();
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem != null && aluguel != null)
            {
                aluguel.cliente = (Cliente)cmbCliente.SelectedItem;

                cmbCondutor.Enabled = true;

                CarregarCondutores(aluguel.cliente.condutores);
            }
        }

        private void cmbGAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGAutomovel.SelectedItem != null && aluguel != null)
            {
                aluguel.grupoAutomovel = (GrupoAutomovel)cmbGAutomovel.SelectedItem;

                cmbAutomovel.Enabled = true;

                CarregarAutomoveis(aluguel.grupoAutomovel.automoveis);

                cmbPCobranca.Enabled = true;

                CarregarPlanosCobranca(aluguel.grupoAutomovel.planosCobranca);
            }
        }

        private void CarregarComboboxesIniciais(List<Funcionario> funcionarios, List<Cliente> clientes, List<GrupoAutomovel> gruposAutomovel)
        {
            CarregarFuncionarios(funcionarios);
            CarregarClientes(clientes);
            CarregarGruposAutomovel(gruposAutomovel);
        }

        private void CarregarListaTaxasExtras()
        {
            foreach (TaxaEServico tx in todasTaxasEServicos)
            {
                if (!listBoxTaxasIniciais.SelectedItems.Contains(tx))
                {
                    listBoxTaxasExtras.Items.Add(tx);
                }
            }
        }

        private void CarregarNivelTanqueEnum()
        {
            cmbAutomovel.DataSource = Enum.GetValues<NivelTanqueEnum>();
            cmbAutomovel.SelectedItem = null;
        }

        private void CarregarAutomoveis(List<Automovel> automoveis)
        {
            cmbAutomovel.DataSource = automoveis;
            cmbAutomovel.SelectedItem = null;
        }

        private void CarregarCondutores(List<Condutor> condutores)
        {
            cmbCondutor.DataSource = condutores;
            cmbCondutor.SelectedItem = null;
        }

        private void CarregarPlanosCobranca(List<PlanoCobranca> planosCobranca)
        {
            cmbPCobranca.DataSource = planosCobranca;
            cmbPCobranca.SelectedItem = null;
        }

        private void CarregarGruposAutomovel(List<GrupoAutomovel> gruposAuto)
        {
            cmbGAutomovel.DataSource = gruposAuto;
            cmbGAutomovel.SelectedItem = null;
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            cmbCliente.DataSource = clientes;
            cmbCliente.SelectedItem = null;
        }

        private void CarregarFuncionarios(List<Funcionario> funcionarios)
        {
            cmbFuncionario.DataSource = funcionarios;
            cmbFuncionario.SelectedItem = null;
        }

        private void txtCupom_TextChanged(object sender, EventArgs e)
        {
            btnAplicarCupom.Enabled = true;
        }

        private void txtKmPercorrido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string s = Regex.Replace(t.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                t.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
