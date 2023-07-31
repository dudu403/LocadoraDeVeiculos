using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using LocadoraDeVeiculos.Infra.Orm.ModuloAluguel;
using LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel;
using LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;
using LocadoraDeVeiculos.WinApp.ModuloAluguel;
using LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraDeVeiculos.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private Dictionary<string, ControladorBase> controladores { get; set; }
        public static TelaPrincipalForm Tela { get; private set; }
        private ControladorBase controlador { get; set; }   

        public TelaPrincipalForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            Tela = this;

            lableRodape.Text = string.Empty;

            labelTipoDoCadastro.Text = string.Empty;

            controladores = new Dictionary<string, ControladorBase>();

            ConfigurarControladores();
        }

        private void ConfigurarControladores()
        {
            var configuracao = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeVeiculosDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeVeiculosDbContext(optionsBuilder.Options);

            var migracoesPendentes = dbContext.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0)
            {
                dbContext.Database.Migrate();
            }

            IRepositorioGrupoAutomovel repositorioGrupoAutomovel = new RepositorioGrupoAutomovelEmOrm(dbContext);

            ValidadorGrupoAutomovel validadorGrupoAutomovel = new ValidadorGrupoAutomovel();

            ServicoGrupoAutomovel servicoDisciplina = new ServicoGrupoAutomovel(repositorioGrupoAutomovel, validadorGrupoAutomovel);

            controladores.Add("ControladorGrupoAutomovel", new ControladorGrupoAutomovel());
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorFuncionario"]);
        }

        private void grupoDeAutomoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoAutomovel"]);
        }

        private void planosDeCobrancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorPlanoCobranca"]);
        }

        private void automoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorAutomovel"]);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCliente"]);
        }

        private void condutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCondutor"]);
        }

        private void taxasEServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorTaxaEServico"]);
        }

        private void cuponsEParceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCupomEParceiro"]);
        }

        private void configuracaoDePrecosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorConfigPreco"]);
        }

        private void alugueisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorAluguel"]);
        }

        #region atualizar rodape

        public void AtualizarRodape(string status)
        {
            lableRodape.Text = status;
        }

        public void AtualizarRodape()
        {
            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        #endregion

        #region configurar tela principal

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem(controlador);

            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                labelTipoDoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarToolTips(configuracao);

                ConfigurarEstadoBotoes(configuracao);

                ConfigurarVisibilidadeBotoes(configuracao);
            }
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            AtualizarRodape("");

            UserControl listagem = controladorBase.ObterListagem();

            panelRegistros.Controls.Clear();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ConfiguracaoToolboxBase config)
        {
            btnInserir.ToolTipText = config.ToolTipInserir;
            btnEditar.ToolTipText = config.ToolTipEditar;
            btnExcluir.ToolTipText = config.ToolTipExcluir;
            btnFiltrar.ToolTipText = config.ToolTipFiltrar;
            btnAdicionarItens.ToolTipText = config.ToolTipAdicionarItens;
            btnRemoverItens.ToolTipText = config.ToolTipRemoverItens;
            btnFinalizarPgto.ToolTipText = config.ToolTipFinalizarPagamento;
            btnConfigurar.ToolTipText = config.ToolTipConfigDesconto;
            btnVisualizar.ToolTipText = config.ToolTipVisualizar;
            btnVisualizar.ToolTipText = config.ToolTipVisualizar;
            btnVisualizarGabarito.ToolTipText = config.ToolTipVisualizarGabarito;
            btnGerarPdf.ToolTipText = config.ToolTipGerarPdf;
            btnHome.ToolTipText = config.ToolTipHome;
        }

        private void ConfigurarEstadoBotoes(ConfiguracaoToolboxBase config)
        {
            btnInserir.Enabled = config.InserirHabilitado;
            btnEditar.Enabled = config.EditarHabilitado;
            btnExcluir.Enabled = config.ExcluirHabilitado;
            btnHome.Enabled = config.HomeHabilitado;
            btnFiltrar.Enabled = config.FiltrarHabilitado;
            btnAdicionarItens.Enabled = config.AdicionarItensHabilitado;
            btnRemoverItens.Enabled = config.RemoverItensHabilitado;
            btnFinalizarPgto.Enabled = config.FinalizarPagamentoHabilitado;
            btnConfigurar.Enabled = config.ConfigDescontoHabilitado;
            btnVisualizar.Enabled = config.VisualizarHabilitado;
            btnVisualizarGabarito.Enabled = config.VisualizarGabaritoHabilitado;
            btnGerarPdf.Enabled = config.GerarPdfHabilitado;
        }

        private void ConfigurarVisibilidadeBotoes(ConfiguracaoToolboxBase config)
        {
            btnInserir.Visible = config.InserirVisivel;
            btnEditar.Visible = config.EditarVisivel;
            btnExcluir.Visible = config.ExcluirVisivel;
            btnHome.Visible = config.HomeVisivel;
            btnFiltrar.Visible = config.FiltrarVisivel;
            btnAdicionarItens.Visible = config.AdicionarItensVisivel;
            btnRemoverItens.Visible = config.RemoverItensVisivel;
            btnFinalizarPgto.Visible = config.FinalizarPagamentoVisivel;
            btnConfigurar.Visible = config.ConfigDescontoVisivel;
            btnVisualizar.Visible = config.VisualizarVisivel;
            btnVisualizarGabarito.Visible = config.VisualizarGabaritoVisivel;
            btnGerarPdf.Visible = config.GerarPdfVisivel;

            toolStripSeparator0.Visible = config.SeparadorVisivel0;
            toolStripSeparator1.Visible = config.SeparadorVisivel1;
            toolStripSeparator2.Visible = config.SeparadorVisivel2;
            toolStripSeparator3.Visible = config.SeparadorVisivel3;
            toolStripSeparator4.Visible = config.SeparadorVisivel4;
            toolStripSeparator5.Visible = config.SeparadorVisivel5;
        }

        #endregion

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