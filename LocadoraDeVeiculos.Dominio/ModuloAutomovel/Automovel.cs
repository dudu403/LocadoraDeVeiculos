using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public class Automovel : EntidadeBase<Automovel>
    {
        public TipoCombustivelEnum tipoCombustivel { get; set; }
        public decimal capacidadeTanqueLitros { get; set; }
        public GrupoAutomovel grupoAutomovel { get; set; }
        public decimal quilometragem { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public byte[] foto { get; set; }
        public string cor { get; set; }

        public Automovel()
        {
            tipoCombustivel = TipoCombustivelEnum.Nenhum;
        }

        public override void AtualizarInformacoes(Automovel registroAtualizado)
        {

        }
    }
}
