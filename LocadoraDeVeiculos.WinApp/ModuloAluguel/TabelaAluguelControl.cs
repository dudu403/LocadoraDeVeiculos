
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"}

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
                grid.Rows.Add(aluguel.id,aluguel.condutor,
                            aluguel.automovel,aluguel.dataLocacao,
                            aluguel.dataPrevistaDevolucao,aluguel.dataDevolucao,
                            aluguel.valorTotalFinal);
                //Aqui falta o tipo de plano, tem que arrumar na entidade ou ver como foi pensada a entidade
            }
        }
    }
}
