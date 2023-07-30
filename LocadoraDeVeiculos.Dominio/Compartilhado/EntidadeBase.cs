namespace LocadoraDeVeiculos.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public int id { get; set; }
        public abstract void AtualizarInformacoes(T registroAtualizado);
    }
}
