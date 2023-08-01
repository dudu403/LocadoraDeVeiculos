using SequentialGuid;

namespace LocadoraDeVeiculos.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public Guid id { get; set; }
        public EntidadeBase() { id = SequentialGuidGenerator.Instance.NewGuid(); }
        public abstract void AtualizarInformacoes(T registroAtualizado);
    }
}
