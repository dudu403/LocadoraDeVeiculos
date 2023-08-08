using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.WinApp.ModuloCondutor
{
    public partial class TabelaCondutorControl : UserControl
    {
        public TabelaCondutorControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CNH", HeaderText = "CNH"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Validade", HeaderText = "Validade"}
            };

            return colunas;
        }

        public Guid ObterIdSelecionado()
        {
            return grid.SelecionarId();
        }
        public void AtualizarRegistros(List<Condutor> condutores)
        {
            grid.Rows.Clear();

            foreach (Condutor condutor in condutores)
            {
                grid.Rows.Add(condutor.id,
                              condutor.nome,
                              condutor.cliente,
                              condutor.cpf,
                              condutor.cnh,
                              condutor.validadeCnh.ToString("dd/MM/yyyy"));
            }
        }
    }
}
