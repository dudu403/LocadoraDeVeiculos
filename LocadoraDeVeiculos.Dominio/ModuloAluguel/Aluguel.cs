using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public List<TaxaEServico> taxasSelecionadas { get; set; }  //seta no cadastro e ja vem preenchidas na devolução, não podem ser alteradas 
        public List<TaxaEServico> taxasAdicionais { get; set; }
        public DateTime dataPrevistaDevolucao { get; set; }
        public GrupoAutomovel grupoAutomovel { get; set; }
        public decimal valorTotalPrevisto { get; set; }
        public decimal nivelTanqueLitros { get; set; }
        public List<TaxaEServico> taxas { get; set; }
        public Funcionario funcionario { get; set; }
        public decimal valorTotalFinal { get; set; }
        public DateTime dataDevolucao { get; set; }
        public DateTime dataLocacao { get; set; }
        public decimal kmPercorrido { get; set; } // faz a conta dele atomatico quando a pessoa preenche o km final 
        public Automovel automovel { get; set; }
        public decimal kmInicial { get; set; } // puxa o km do automovel
        public Condutor condutor { get; set; }
        public decimal kmFinal { get; set; } // sempre q add o km final na devolução, seta ele como o km do automovel 
        public Cliente cliente { get; set; }
        public Cupom? cupom { get; set; }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}