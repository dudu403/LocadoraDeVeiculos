namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel
{ 
    public class GrupoAutomovel : EntidadeBase<GrupoAutomovel>
    {
        public string nome { get; set; }

        public override void AtualizarInformacoes(GrupoAutomovel registroAtualizado)
        {
            nome = registroAtualizado.nome;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
