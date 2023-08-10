
using LocadoraDeVeiculos.Dominio.ModuloAluguel;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Automovel", HeaderText = "Automovel"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Plano", HeaderText = "Plano"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data da Locação", HeaderText = "Data da Locação"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data Prevista Devolução", HeaderText = "Data Prevista Devolução"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data Devolução", HeaderText = "Data Devolução"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total Previsto", HeaderText = "Valor Total Previsto"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor Total Final", HeaderText = "Valor Total Final"}
            };

            return colunas;
        }

        public Guid ObterIdSelecionado()
        {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Aluguel> aluguels)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in aluguels)
            {
                grid.Rows.Add(aluguel.id, aluguel.cliente, aluguel.condutor,
                            aluguel.automovel.modelo, aluguel.planoCobranca.tipoPlano, aluguel.dataLocacao.ToString("dd/MM/yyyy"),
                            aluguel.dataPrevistaDevolucao.ToString("dd/MM/yyyy"), aluguel?.dataDevolucao?.ToString("dd/MM/yyyy"),
                            aluguel.valorTotalPrevisto, aluguel.valorTotalFinal);
            }
        }
    }
}
