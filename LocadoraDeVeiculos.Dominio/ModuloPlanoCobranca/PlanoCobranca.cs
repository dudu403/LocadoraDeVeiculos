using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca
{
    public class PlanoCobranca : EntidadeBase<PlanoCobranca>
    {
        public GrupoAutomovel grupoAutomovel { get; set; }      
        public TipoPlanoEnum tipoPlano { get; set; }
        public decimal precoDiaria { get; set; }
        public decimal ?precoPorKm { get; set; }
        public decimal ?precoPorKmExtrapolado { get; set; }
        public decimal ?kmDisponiveis { get; set; }

        public override void AtualizarInformacoes(PlanoCobranca registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
