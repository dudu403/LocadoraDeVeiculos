using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel
{
    public partial class TelaGrupoAutomovelForm : Form
    {
        private GrupoAutomovel grupoAutomovel;

        public event GravarRegistroDelegate<GrupoAutomovel> onGravarRegistro;

        public TelaGrupoAutomovelForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public GrupoAutomovel ObterGrupoAutomovel()
        {
            grupoAutomovel.nome = txtNome.Text;

            return grupoAutomovel;
        }

        public void ConfigurarGrupoAutomovel(GrupoAutomovel grupoAutomovel)
        {
            this.grupoAutomovel = grupoAutomovel;

            txtNome.Text = grupoAutomovel.nome;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.grupoAutomovel = ObterGrupoAutomovel();

            Result resultado = onGravarRegistro(grupoAutomovel);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
