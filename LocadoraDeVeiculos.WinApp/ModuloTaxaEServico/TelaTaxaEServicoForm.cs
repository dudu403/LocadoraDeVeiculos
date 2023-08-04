using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaEServico
{
    public partial class TelaTaxaEServicoForm : Form
    {
        TaxaEServico taxaEServico { get; set; }

        public event GravarRegistroDelegate<TaxaEServico> onGravarRegistro;

        public TelaTaxaEServicoForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarTiposDeCusto();
        }

        public TaxaEServico ObterTaxaEServico()
        {
            taxaEServico.nome = txtNome.Text;
            taxaEServico.preco = Convert.ToDecimal(txtPreco.Text);
            taxaEServico.tipoDoCusto = (TipoCustoEnum)cmbTipoCusto.SelectedItem;

            return taxaEServico;
        }

        public void ConfigurarTaxaEServico(TaxaEServico taxaEServico)
        {
            this.taxaEServico = taxaEServico;

            txtNome.Text = taxaEServico.nome;
            txtPreco.Text = Convert.ToString(taxaEServico.preco);
            cmbTipoCusto.SelectedItem = taxaEServico.tipoDoCusto;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.taxaEServico = ObterTaxaEServico();

            Result resultado = onGravarRegistro(taxaEServico);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void CarregarTiposDeCusto()
        {
            cmbTipoCusto.Items.Clear();

            cmbTipoCusto.Items.Add(TipoCustoEnum.Nenhum);
            cmbTipoCusto.Items.Add(TipoCustoEnum.Cobrança_Diária);
            cmbTipoCusto.Items.Add(TipoCustoEnum.Preço_Fixo);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
