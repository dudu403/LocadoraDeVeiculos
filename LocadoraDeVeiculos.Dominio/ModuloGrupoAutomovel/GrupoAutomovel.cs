namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel
{ 
    public class GrupoAutomovel : EntidadeBase<GrupoAutomovel>
    {
        public string nome { get; set; }

        public override void AtualizarInformacoes(GrupoAutomovel registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
