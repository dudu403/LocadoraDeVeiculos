using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.ModuloConfigPreco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            carregarOpcoesDePlano();

            cbmTipoPlano.Enabled = txtPrecoDiaria.Enabled = txtKm.Enabled = txtKmExcedente.Enabled = txtKmDisponivel.Enabled = false;

            cmbGAutomoveis.Focus();
        }

        public void ConfigurarTela(PlanoCobranca planoCobranca)
        {
            this.planoCobranca = planoCobranca;

            cmbGAutomoveis.SelectedItem = planoCobranca.grupoAutomovel;
            cbmTipoPlano.SelectedItem = planoCobranca.tipoPlano;
            txtPrecoDiaria.Text = planoCobranca.precoDiaria.ToString();
            txtKm.Text = planoCobranca?.precoPorKm.ToString();
            txtKmExcedente.Text = planoCobranca?.precoPorKmExtrapolado.ToString();
            txtKmDisponivel.Text = planoCobranca?.kmDisponiveis.ToString();
        }

        public PlanoCobranca ObterPlanoCobranca()
        {
            planoCobranca.grupoAutomovel = (GrupoAutomovel)cmbGAutomoveis.SelectedItem;
            planoCobranca.tipoPlano = (TipoPlanoEnum)cbmTipoPlano.SelectedItem;
            planoCobranca.precoDiaria = Convert.ToDecimal(txtPrecoDiaria.Text);
            
            if(planoCobranca.precoPorKm != null)    
                planoCobranca.precoPorKm = Convert.ToDecimal(txtKm.Text);
            if(planoCobranca.precoPorKmExtrapolado != null)
                planoCobranca.precoPorKmExtrapolado = Convert.ToDecimal(txtKmExcedente.Text);
            if(planoCobranca.kmDisponiveis != null)
                planoCobranca.kmDisponiveis = Convert.ToDecimal(txtKmDisponivel.Text);

            return planoCobranca;
        }

        private void CarregarGrupoAutomoveis(List<GrupoAutomovel> grupoAutomovels)
        {
            cmbGAutomoveis.Items.Clear();

            foreach (GrupoAutomovel grupoAutomovel in grupoAutomovels)
            {
                cmbGAutomoveis.Items.Add(grupoAutomovel);
            }
        }

        private void carregarOpcoesDePlano()
        {
            TipoPlanoEnum[] plano = Enum.GetValues<TipoPlanoEnum>();

            foreach (TipoPlanoEnum opcaoPlano in plano)
            {
                cbmTipoPlano.Items.Add(opcaoPlano);
            }
            cbmTipoPlano.SelectedIndex = 0;
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

        private void cbmTipoPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmTipoPlano.Enabled = true;
            cbmTipoPlano.Focus();

            if ((TipoPlanoEnum)cbmTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Diária)
            {
                txtPrecoDiaria.Enabled = true;
                txtKm.Enabled = true;
                txtKmExcedente.Enabled = false;
                txtKmDisponivel.Enabled = false;
            }

            if ((TipoPlanoEnum)cbmTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Controlada)
            {
                txtPrecoDiaria.Enabled = true;
                txtKm.Enabled = false;
                txtKmExcedente.Enabled = true;
                txtKmDisponivel.Enabled = true;
            }

            if ((TipoPlanoEnum)cbmTipoPlano.SelectedItem == TipoPlanoEnum.Cobrança_Km_Livre)
            {
                txtPrecoDiaria.Enabled = true;
                txtKm.Enabled = false;
                txtKmExcedente.Enabled = false;
                txtKmDisponivel.Enabled = false;
            }
        }

        private void txtPrecoLocacao_KeyPress(object sender, KeyPressEventArgs e)
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
