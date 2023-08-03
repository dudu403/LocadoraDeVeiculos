using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    public partial class TelaCupomForm : Form
    {
        private Cupom cupom;

        public event GravarRegistroDelegate<Cupom> onGravarRegistro;

        public TelaCupomForm(List<Parceiro> parceiros)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarParceiros(parceiros);
        }

        public void ConfigurarTela(Cupom cupomSelecionado)
        {
            this.cupom = cupomSelecionado;

            txtNome.Text = cupomSelecionado.nome;
            txtValor.Text = cupomSelecionado.valor.ToString();
            txtData.Value = cupomSelecionado.validade;
            cmbParceiro.SelectedItem = cupomSelecionado.parceiro;
        }

        public Cupom ObterCupom()
        {
            cupom.nome = txtNome.Text;
            cupom.valor = Convert.ToDecimal(txtValor.Text);
            cupom.validade = (txtData.Value);
            cupom.parceiro = (Parceiro)cmbParceiro.SelectedItem;

            return cupom;
        }

        private void CarregarParceiros(List<Parceiro> parceiros)
        {
            cmbParceiro.Items.Clear();
            
            foreach (Parceiro parceiro in parceiros)
            {
                cmbParceiro.Items.Add(parceiro);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.cupom = ObterCupom();

            Result resultado = onGravarRegistro(cupom);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Tela.AtualizarRodape("");
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
