using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;

namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca
{
    public partial class TabelaPlanoCobrancaControl : UserControl
    {
        public TabelaPlanoCobrancaControl()
        {
            InitializeComponent();

            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());

            TelaPrincipalForm.Tela.AtualizarRodape("");
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id", Visible = false},

                new DataGridViewTextBoxColumn { DataPropertyName = "Grupo de Automovel", HeaderText = "Grupo de Automovel"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Tipo do Plano", HeaderText = "Tipo do Plano"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor por dia", HeaderText = "Valor por dia"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Km livre", HeaderText = "Km livre"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor km rodado", HeaderText = "Valor km rodado"}
            };

            return colunas;
        }

        public Guid ObterIdSelecionado()
        {
            return grid.SelecionarId();
        }

        internal void AtualizarRegistros(List<PlanoCobranca> planoCobrancas)
        {
            grid.Rows.Clear();

            foreach (PlanoCobranca var in planoCobrancas)
            {
                grid.Rows.Add(var.id,
                              var.grupoAutomovel.nome,
                              var.tipoPlano,
                      "R$ " + var.precoDiaria,
                      "R$ " + var?.precoPorKmExtrapolado,
                      "R$ " + var?.precoPorKm);
            }
        }
    }
}
