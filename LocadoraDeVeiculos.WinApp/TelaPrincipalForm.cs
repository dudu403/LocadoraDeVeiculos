using LocadoraDeVeiculos.Aplicacao.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Aplicacao.ModuloConfigPreco;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Aplicacao.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Infra.Json.ModuloConfigPreco;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using LocadoraDeVeiculos.Infra.Orm.ModuloAluguel;
using LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel;
using LocadoraDeVeiculos.Infra.Orm.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Infra.Orm.ModuloConfigPreco;
using LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario;
using LocadoraDeVeiculos.WinApp.ModuloAluguel;
using LocadoraDeVeiculos.WinApp.ModuloConfigPreco;
using LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro;
using LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.ModuloAutomovel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;
using LocadoraDeVeiculos.WinApp.ModuloFuncionario;
using LocadoraDeVeiculos.WinApp.ModuloTaxaEServico;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Infra.Orm.ModuloCliente;
using LocadoraDeVeiculos.Aplicacao.ModuloCliente;
using LocadoraDeVeiculos.WinApp.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;
using LocadoraDeVeiculos.Infra.Orm.ModuloTaxaEServico;
using LocadoraDeVeiculos.Aplicacao.ModuloTaxaEServico;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Infra.Orm.ModuloCondutor;
using LocadoraDeVeiculos.Aplicacao.ModuloCondutor;
using LocadoraDeVeiculos.WinApp.ModuloCondutor;
using LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Aplicacao.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;

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

            ValidadorGrupoAutomovel validadorGrupoAutomovel = new();

            ServicoGrupoAutomovel servicoGrupoAutomovel = new(repositorioGrupoAutomovel, validadorGrupoAutomovel);

            controladores.Add("ControladorGrupoAutomovel", new ControladorGrupoAutomovel(repositorioGrupoAutomovel, servicoGrupoAutomovel));

            IRepositorioAutomovel repositorioAutomovel = new RepositorioAutomovelEmOrm(dbContext);

            ValidadorAutomovel validadorAutomovel = new();

            ServicoAutomovel servicoAutomovel = new(repositorioAutomovel, validadorAutomovel);

            controladores.Add("ControladorAutomovel", new ControladorAutomovel(repositorioAutomovel, repositorioGrupoAutomovel, servicoAutomovel));

            IRepositorioConfiguracaoPreco repositorioConfiguracaoPreco = new RepositorioConfigPrecoEmJson(carregarDados: true);

            ValidadorConfiguracaoPreco validadorConfiguracaoPreco = new();

            ServicoConfiguracaoPreco servicoConfiguracaoPreco = new(repositorioConfiguracaoPreco, validadorConfiguracaoPreco);

            controladores.Add("ControladorConfigPreco", new ControladorConfigPreco(repositorioConfiguracaoPreco, servicoConfiguracaoPreco));

            IRepositorioTaxaEServico repositorioTaxaEServico = new RepositorioTaxaEServicoEmOrm(dbContext);

            ValidadorTaxaEServico validadorTaxaEServico = new();

            ServicoTaxaEServico servicoTaxaEServico = new(repositorioTaxaEServico, validadorTaxaEServico);

            controladores.Add("ControladorTaxaEServico", new ControladorTaxaEServico(repositorioTaxaEServico, servicoTaxaEServico));

            IRepositorioParceiro repositorioParceiro = new RepositorioParceiroEmOrm(dbContext);

            ValidadorParceiro validadorParceiro = new();

            ServicoParceiro servicoParceiro = new(repositorioParceiro, validadorParceiro);

            controladores.Add("ControladorParceiro", new ControladorParceiro(repositorioParceiro, servicoParceiro));

            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioEmOrm(dbContext);

            ValidadorFuncionario validadorFuncionario = new();

            ServicoFuncionario servicoFuncionario = new(repositorioFuncionario, validadorFuncionario);

            controladores.Add("ControladorFuncionario", new ControladorFuncionario(repositorioFuncionario, servicoFuncionario));

            IRepositorioCliente repositorioCliente = new RepositorioClienteEmOrm(dbContext);

            IRepositorioCondutor repositorioCondutor = new RepositorioCondutorEmOrm(dbContext);

            ValidadorCliente validadorCliente = new();

            ServicoCliente servicoCliente = new(repositorioCliente, validadorCliente, repositorioCondutor);

            controladores.Add("ControladorCliente", new ControladorCliente(repositorioCliente, servicoCliente, repositorioCondutor));

            IRepositorioCupom repositorioCupom = new RepositorioCupomEmOrm(dbContext);

            ValidadorCupom validadorCupom = new();

            ServicoCupom servicoCupom = new(repositorioCupom, validadorCupom);

            controladores.Add("ControladorCupom", new ControladorCupom(repositorioCupom, servicoCupom, repositorioParceiro));

            ValidadorCondutor validadorCondutor = new();

            ServicoCondutor servicoCondutor = new(repositorioCondutor, validadorCondutor);

            controladores.Add("ControladorCondutor", new ControladorCondutor(repositorioCondutor, servicoCondutor, repositorioCliente));

            IRepositorioPlanoCobranca repositorioPlanoCobranca = new RepositorioPlanoCobrancaEmOrm(dbContext);

            ValidadorPlanoCobranca validadorPlanoCobranca = new();

            ServicoPlanoCobranca servicoPlanoCobranca = new(repositorioPlanoCobranca, validadorPlanoCobranca);

            controladores.Add("ControladorPlanoCobranca", new ControladorPlanoCobranca(repositorioPlanoCobranca, servicoPlanoCobranca, repositorioGrupoAutomovel));

            IRepositorioAluguel repositorioAluguel = new RepositorioAluguelEmOrm(dbContext);

            ValidadorAluguel validadorAluguel = new();

            ServicoAluguel servicoAluguel = new(repositorioAluguel, validadorAluguel);

            controladores.Add("ControladorAluguel", new ControladorAluguel(repositorioFuncionario, repositorioTaxaEServico, repositorioCliente,
                repositorioCondutor, repositorioCupom, repositorioAutomovel, repositorioGrupoAutomovel, repositorioPlanoCobranca,
                repositorioAluguel, servicoAluguel, repositorioConfiguracaoPreco));
        }

        private void cuponsMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorParceiro"]);

            ConfigurarTelaPrincipal(controladores["ControladorCupom"]);
        }

        private void funcionariosMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorFuncionario"]);
        }

        private void grupoDeAutomoveisMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoAutomovel"]);
        }

        private void planosDeCobrancaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoAutomovel"]);

            ConfigurarTelaPrincipal(controladores["ControladorPlanoCobranca"]);
        }

        private void automoveisMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarListagem(controladores["ControladorGrupoAutomovel"]);

            ConfigurarTelaPrincipal(controladores["ControladorAutomovel"]);
        }

        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCliente"]);
        }

        private void condutoresMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCliente"]);

            ConfigurarTelaPrincipal(controladores["ControladorCondutor"]);
        }

        private void taxasEServiçosMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorTaxaEServico"]);
        }

        private void parceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorParceiro"]);
        }

        private void configuracaoDePrecosMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorConfigPreco"]);
        }

        private void alugueisMenuItem_Click(object sender, EventArgs e)
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

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
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
            btnConfigurar.ToolTipText = config.ToolTipConfig;
            btnVisualizar.ToolTipText = config.ToolTipVisualizar;
            btnVisualizar.ToolTipText = config.ToolTipVisualizar;
            btnVisualizarGabarito.ToolTipText = config.ToolTipVisualizarGabarito;
            btnGerarPdf.ToolTipText = config.ToolTipGerarPdf;
            btnHome.ToolTipText = config.ToolTipHome;
            btnDevolucao.ToolTipText = config.ToolTipDevolver;
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
            btnConfigurar.Enabled = config.ConfigHabilitado;
            btnVisualizar.Enabled = config.VisualizarHabilitado;
            btnVisualizarGabarito.Enabled = config.VisualizarGabaritoHabilitado;
            btnGerarPdf.Enabled = config.GerarPdfHabilitado;
            btnDevolucao.Enabled = config.DevolverHabilitado;
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
            btnConfigurar.Visible = config.ConfigVisivel;
            btnVisualizar.Visible = config.VisualizarVisivel;
            btnVisualizarGabarito.Visible = config.VisualizarGabaritoVisivel;
            btnGerarPdf.Visible = config.GerarPdfVisivel;
            btnDevolucao.Visible = config.DevolverVisivel;

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

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            controlador.Devolver();
        }
    }
}