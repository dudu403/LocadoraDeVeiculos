namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel
{
    public partial class TabelaGrupoAutomovelControl : UserControl
    {
        public TabelaGrupoAutomovelControl()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"}

            };

            return colunas;
        }

        public int ObterNumeroTesteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        //public void AtualizarRegistros(List<var> vars)
        //{
        //    grid.Rows.Clear();

        //    foreach (var var in vars)
        //    {
        //        grid.Rows.Add(var.id, var.nome,...................);
        //    }
        //}
    }
}
