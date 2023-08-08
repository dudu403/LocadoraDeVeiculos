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

        public PlanoCobranca()
        {
          
        }

        public override void AtualizarInformacoes(PlanoCobranca registroAtualizado)
        {
            grupoAutomovel = registroAtualizado.grupoAutomovel;
            tipoPlano = registroAtualizado.tipoPlano;
            precoDiaria = registroAtualizado.precoDiaria;
            precoPorKm = registroAtualizado.precoPorKm;
            precoPorKmExtrapolado = registroAtualizado.precoPorKmExtrapolado;
            kmDisponiveis = registroAtualizado.kmDisponiveis;
                
        }

        public override string ToString()
        {
            return $"{tipoPlano} do Grupo de Automovel {grupoAutomovel}";
        }
    }
}
