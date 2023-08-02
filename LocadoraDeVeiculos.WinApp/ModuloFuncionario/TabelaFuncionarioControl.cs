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
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id", Visible = false},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Salario", HeaderText = "Salario"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data Admissão", HeaderText = "Data Admissão"}
            };

            return colunas;
        }

        public int ObterNumeroFuncionarioSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            grid.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {
                grid.Rows.Add(funcionario.id,
                              funcionario.nome,
                      "R$ " + funcionario.salario,
                              funcionario.dataAdimissao.ToString("dd/MM/yyyy"));
            }      
        }
    }
}
