using LocadoraDeVeiculos.Dominio.ModuloCliente;
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor da Diária", HeaderText = "Valor da Diária"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor por Km", HeaderText = "Valor por Km"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor por Km Extrapolado", HeaderText = "Valor por Km Extrapolado"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quilometragem Disponível", HeaderText = "Quilometragem Disponível"}
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
                              var.grupoAutomovel,
                              var.tipoPlano,
                      "R$ " + var.precoDiaria,
                              var?.precoPorKm == null ? "R$ 0,00" : "R$ " + var?.precoPorKm,
                              var?.precoPorKmExtrapolado == null ? "R$ 0,00" : "R$ " + var?.precoPorKmExtrapolado,
                              var?.kmDisponiveis == null ? "  -  " : var?.kmDisponiveis);
            }
        }
    }
}
