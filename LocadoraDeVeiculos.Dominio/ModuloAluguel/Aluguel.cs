using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;
using System.Numerics;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public DateTime dataPrevistaDevolucao { get; set; }
        public GrupoAutomovel grupoAutomovel { get; set; }
        public PlanoCobranca planoCobranca { get; set; } 
        public NivelTanqueEnum nivelTanque { get; set; }
        public decimal valorTotalPrevisto { get; set; }
        public List<TaxaEServico>? taxas { get; set; }
        public decimal ?valorTotalFinal { get; set; }
        public DateTime ?dataDevolucao { get; set; }
        public Funcionario funcionario { get; set; }
        public decimal ?kmPercorrido { get; set; } 
        public DateTime dataLocacao { get; set; }
        public Automovel automovel { get; set; }
        public decimal kmInicial { get; set; } 
        public Condutor condutor { get; set; }
        public decimal ?kmFinal { get; set; }
        public Cliente cliente { get; set; }
        public Cupom? cupom { get; set; }  

        public Aluguel()
        {

        }
        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}