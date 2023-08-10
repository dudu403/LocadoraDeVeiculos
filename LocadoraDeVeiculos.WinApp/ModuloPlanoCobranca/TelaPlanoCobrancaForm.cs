using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca
{
    public partial class TelaPlanoCobrancaForm : Form
    {
        private PlanoCobranca planoCobranca { get; set; }

        public event GravarRegistroDelegate<PlanoCobranca> onGravarRegistro;

        public TelaPlanoCobrancaForm(List<GrupoAutomovel> grupoAutomovels)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarGrupoAutomoveis(grupoAutomovels);

            CarregarOpcoesDePlano();

            cmbGrpAutomoveis.Focus();
        }

        public void ConfigurarTela(PlanoCobranca planoCobranca)
        {
            this.planoCobranca = planoCobranca;

            cmbGrpAutomoveis.SelectedItem = planoCobranca.grupoAutomovel;
            cmbTipoPlano.SelectedItem = planoCobranca.tipoPlano;

            ConfigurarAparicaoTextBoxes();

            if ((TipoPlanoEnum)cmbTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Diária)
            {
                txtKmDisponivel.Text = "";
                txtKmExcedente.Text = "";
                txtKm.Text = planoCobranca?.precoPorKm.ToString();
                txtPrecoDiaria.Text = planoCobranca.precoDiaria.ToString();
            }

            if ((TipoPlanoEnum)cmbTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Controlada)
            {
                txtKm.Text = "";
                txtPrecoDiaria.Text = planoCobranca.precoDiaria.ToString();
                txtKmDisponivel.Text = planoCobranca?.kmDisponiveis.ToString();
                txtKmExcedente.Text = planoCobranca?.precoPorKmExtrapolado.ToString();
            }

            if ((TipoPlanoEnum)cmbTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Km_Livre)
            {
                txtKm.Text = "";
                txtKmDisponivel.Text = "";
                txtKmExcedente.Text = "";
                txtPrecoDiaria.Text = planoCobranca.precoDiaria.ToString();
            }
        }

        public PlanoCobranca ObterPlanoCobranca()
        {
            planoCobranca.grupoAutomovel = (GrupoAutomovel)cmbGrpAutomoveis.SelectedItem;
            planoCobranca.tipoPlano = (TipoPlanoEnum)cmbTipoPlano.SelectedItem;

            if (txtPrecoDiaria.Text != "")
                planoCobranca.precoDiaria = Convert.ToDecimal(txtPrecoDiaria.Text);
            if (txtKm.Text != "")
                planoCobranca.precoPorKm = Convert.ToDecimal(txtKm.Text);
            if (txtKmExcedente.Text != "")
                planoCobranca.precoPorKmExtrapolado = Convert.ToDecimal(txtKmExcedente.Text);
            if (txtKmDisponivel.Text != "")
                planoCobranca.kmDisponiveis = Convert.ToDecimal(txtKmDisponivel.Text);

            if (txtPrecoDiaria.Text == "")
                planoCobranca.precoDiaria = 0;
            if (txtKm.Text == "")
                planoCobranca.precoPorKm = null;
            if (txtKmExcedente.Text == "")
                planoCobranca.precoPorKmExtrapolado = null;
            if (txtKmDisponivel.Text == "")
                planoCobranca.kmDisponiveis = null;

            return planoCobranca;
        }

        private void CarregarGrupoAutomoveis(List<GrupoAutomovel> grupoAutomoveis)
        {
            cmbGrpAutomoveis.DataSource = grupoAutomoveis;
        }

        private void CarregarOpcoesDePlano()
        {
            cmbTipoPlano.DataSource = Enum.GetValues<TipoPlanoEnum>();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.planoCobranca = ObterPlanoCobranca();

            Result resultado = onGravarRegistro(planoCobranca);

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

        private void cmbGrpAutomoveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrpAutomoveis.SelectedItem != null)
                cmbTipoPlano.Enabled = true;
        }

        private void cbmTipoPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipoPlano.Focus();

            ConfigurarAparicaoTextBoxes();
        }

        private void ConfigurarAparicaoTextBoxes()
        {
            if ((TipoPlanoEnum)cmbTipoPlano.SelectedItem == TipoPlanoEnum.Nenhum)
            {
                lblPrecoPorKm.Visible = false;
                lblPrecoDiaria.Visible = false;
                lblKmDisponiveis.Visible = false;
                lblPrecoKmExedente.Visible = false;

                txtKm.Enabled = false;
                txtKm.Visible = false;
                txtKm.Text = string.Empty;
                txtPrecoDiaria.Enabled = false;
                txtPrecoDiaria.Visible = false;
                txtPrecoDiaria.Text = string.Empty;
                txtKmExcedente.Enabled = false;
                txtKmExcedente.Visible = false;
                txtKmExcedente.Text = string.Empty;
                txtKmDisponivel.Enabled = false;
                txtKmDisponivel.Visible = false;
                txtKmDisponivel.Text = string.Empty;
            }

            if ((TipoPlanoEnum)cmbTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Diária)
            {
                lblPrecoPorKm.Visible = true;
                lblPrecoDiaria.Visible = true;
                lblKmDisponiveis.Visible = false;
                lblPrecoKmExedente.Visible = false;

                txtKm.Enabled = true;
                txtKm.Visible = true;
                txtPrecoDiaria.Enabled = true;
                txtPrecoDiaria.Visible = true;
                txtKmExcedente.Enabled = false;
                txtKmExcedente.Visible = false;
                txtKmExcedente.Text = string.Empty;
                txtKmDisponivel.Enabled = false;
                txtKmDisponivel.Visible = false;
                txtKmDisponivel.Text = string.Empty;
            }

            if ((TipoPlanoEnum)cmbTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Controlada)
            {
                lblPrecoPorKm.Visible = false;
                lblPrecoDiaria.Visible = true;
                lblKmDisponiveis.Visible = true;
                lblPrecoKmExedente.Visible = true;

                txtKm.Enabled = false;
                txtKm.Visible = false;
                txtKm.Text = string.Empty;
                txtPrecoDiaria.Enabled = true;
                txtPrecoDiaria.Visible = true;
                txtKmExcedente.Enabled = true;
                txtKmExcedente.Visible = true;
                txtKmDisponivel.Enabled = true;
                txtKmDisponivel.Visible = true;
            }

            if ((TipoPlanoEnum)cmbTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Km_Livre)
            {
                lblPrecoPorKm.Visible = false;
                lblPrecoDiaria.Visible = true;
                lblKmDisponiveis.Visible = false;
                lblPrecoKmExedente.Visible = false;

                txtKm.Enabled = false;
                txtKm.Visible = false;
                txtKm.Text = string.Empty;
                txtPrecoDiaria.Enabled = true;
                txtPrecoDiaria.Visible = true;
                txtKmExcedente.Enabled = false;
                txtKmExcedente.Visible = false;
                txtKmExcedente.Text = string.Empty;
                txtKmDisponivel.Enabled = false;
                txtKmDisponivel.Visible = false;
                txtKmDisponivel.Text = string.Empty;
            }
        }

        private void txtPrecosLocacao_KeyPress(object sender, KeyPressEventArgs e)
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
