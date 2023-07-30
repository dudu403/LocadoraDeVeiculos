using LocadoraDeVeiculos.WinApp.ModuloAluguel;

namespace LocadoraDeVeiculos.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Tela { get; private set; }
        private ControladorBase controlador { get; set; }   

        public TelaPrincipalForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            Tela = this;
        }

        public void AtualizarRodape(string status)
        {
            lableRodape.Text = status;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoDoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            btnRemoverItens.ToolTipText = controlador.ToolTipRemoverItens;
            btnFinalizarPgto.ToolTipText = controlador.ToolTipFinalizarPagamento;
            btnConfigurar.ToolTipText = controlador.ToolTipConfigDesconto;
            btnVisualizar.ToolTipText = controlador.ToolTipVisualizar;
            btnVisualizar.ToolTipText = controlador.ToolTipVisualizar;
            btnVisualizarGabarito.ToolTipText = controlador.ToolTipVisualizarGabarito;
            btnGerarPdf.ToolTipText = controlador.ToolTipGerarPdf;
            btnHome.ToolTipText = controlador.ToolTipHome;

            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnHome.Enabled = controlador.HomeHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionarItens.Enabled = controlador.AdicionarItensHabilitado;
            btnRemoverItens.Enabled = controlador.RemoverItensHabilitado;
            btnFinalizarPgto.Enabled = controlador.FinalizarPagamentoHabilitado;
            btnConfigurar.Enabled = controlador.ConfigDescontoHabilitado;
            btnVisualizar.Enabled = controlador.VisualizarHabilitado;
            btnVisualizarGabarito.Enabled = controlador.VisualizarGabaritoHabilitado;
            btnGerarPdf.Enabled = controlador.GerarPdfHabilitado;

            btnInserir.Visible = controlador.InserirVisivel;
            btnEditar.Visible = controlador.EditarVisivel;
            btnExcluir.Visible = controlador.ExcluirVisivel;
            btnHome.Visible = controlador.HomeVisivel;
            btnFiltrar.Visible = controlador.FiltrarVisivel;
            btnAdicionarItens.Visible = controlador.AdicionarItensVisivel;
            btnRemoverItens.Visible = controlador.RemoverItensVisivel;
            btnFinalizarPgto.Visible = controlador.FinalizarPagamentoVisivel;
            btnConfigurar.Visible = controlador.ConfigDescontoVisivel;
            btnVisualizar.Visible = controlador.VisualizarVisivel;
            btnVisualizarGabarito.Visible = controlador.VisualizarGabaritoVisivel;
            btnGerarPdf.Visible = controlador.GerarPdfVisivel;

            toolStripSeparator0.Visible = controlador.SeparadorVisivel0;
            toolStripSeparator1.Visible = controlador.SeparadorVisivel1;
            toolStripSeparator2.Visible = controlador.SeparadorVisivel2;
            toolStripSeparator3.Visible = controlador.SeparadorVisivel3;
            toolStripSeparator4.Visible = controlador.SeparadorVisivel4;
            toolStripSeparator5.Visible = controlador.SeparadorVisivel5;
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorFuncionario();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void grupoDeAutomoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorGrupoAutomovel();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void planosDeCobrancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorPlanoCobranca();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void automoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorAutomovel();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorCliente();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void condutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorCondutor();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void taxasEServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorTaxaESerico();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void cuponsEParceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorCupomEParceiro();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void configuracaoDePrecosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorConfiguracaoPreco();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void alugueisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //controlador = new ControladorAluguel();

            //ConfigurarTelaPrincipal(controlador);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            controlador.Configurar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }
    }
}