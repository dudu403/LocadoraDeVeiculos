using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;
using static System.Net.Mime.MediaTypeNames;

namespace LocadoraDeVeiculos.WinApp.ModuloTaxaEServico
{
    public partial class TabelaTaxaEServicoControl : UserControl
    {
        public TabelaTaxaEServicoControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Tipo Do Custo", HeaderText = "Tipo Do Custo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Preço", HeaderText = "Preço"}
            };

            return colunas;
        }

        public Guid ObterIdSelecionado()
        {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<TaxaEServico> taxaEServicos)
        {
            grid.Rows.Clear();

            foreach (var taxaEServico in taxaEServicos)
            {
                grid.Rows.Add(taxaEServico.id, taxaEServico.nome, taxaEServico.tipoDoCusto, taxaEServico.preco);
            }
        }
    }
}
