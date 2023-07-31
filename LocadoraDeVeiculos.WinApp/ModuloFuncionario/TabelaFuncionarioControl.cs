using LocadoraDeVeiculos.Dominio.ModuloFuncionario;

namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                 new DataGridViewTextBoxColumn { DataPropertyName = "Data Admissão", HeaderText = "Data Admissão"},

                new DataGridViewTextBoxColumn { DataPropertyName = "salario", HeaderText = "Salario"},

            };

            return colunas;
        }

        public int ObterNumeroTesteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            grid.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {
                grid.Rows.Add(funcionario.nome,
                    "R$ " + funcionario.salario,
                    funcionario.dataAdmissao);
            }
        }
    }
}
