using LocadoraDeVeiculos.Dominio.ModuloAutomovel;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel
{
    public partial class TabelaAutomovelControl : UserControl
    {
        public TabelaAutomovelControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Modelo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cor", HeaderText = "Cor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quilometragem", HeaderText = "Quilometragem"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Combustível", HeaderText = "Combustível"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Capacidade Do Tanque (L)", HeaderText = "Capacidade Do Tanque (L)"}
            };

            return colunas;
        }

        public Guid ObterIdSelecionado()
        {
            return grid.SelecionarId();
        }

        public void AtualizarRegistros(List<Automovel> automoveis)
        {
            grid.Rows.Clear();

            foreach (Automovel automovel in automoveis)
            {
                grid.Rows.Add(automovel.id,
                              automovel.marca,
                              automovel.modelo,
                              automovel.cor,
                              automovel.quilometragem,
                              automovel.tipoCombustivel,
                              automovel.capacidadeTanqueLitros);
            }
        }
    }
}
