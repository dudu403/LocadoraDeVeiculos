using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;

namespace LocadoraDeVeiculos.WinApp.ModuloConfigPreco
{
    public partial class TabelaConfigPrecoControl : UserControl
    {
        public TabelaConfigPrecoControl()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Preço da Gasolina", HeaderText = "Preço da Gasolina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Preço do Álcool", HeaderText = "Preço do Álcool"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Preço do Disel", HeaderText = "Preço do Disel"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Preço do Gás", HeaderText = "Preço do Gás"}

            };

            return colunas;
        }

        public int ObterIdSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(ConfiguracaoPreco configPreco)
        {
            grid.Rows.Clear();

            grid.Rows.Add(configPreco.precoGasolina, configPreco.precoAlcool, configPreco.precoDisel, configPreco.precoGas);
            
        }
    }
}
