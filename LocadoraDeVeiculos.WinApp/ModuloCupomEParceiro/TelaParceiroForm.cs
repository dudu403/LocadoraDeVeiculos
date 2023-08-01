using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    public partial class TelaParceiroForm : Form
    {
        private Parceiro parceiro;

        public event GravarRegistroDelegate<Parceiro> onGravarRegistro;

        public TelaParceiroForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Parceiro ObterParceiro()
        {
            parceiro.nome = txtNomeParceiro.Text;

            return parceiro;
        }

        public void ConfigurarParceiro(Parceiro parceiro)
        {
            this.parceiro = parceiro;

            txtNomeParceiro.Text = parceiro.nome;
        }

        private void btnGravarParceiro_Click(object sender, EventArgs e)
        {
            this.parceiro = ObterParceiro();

            Result resultado = onGravarRegistro(parceiro);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
