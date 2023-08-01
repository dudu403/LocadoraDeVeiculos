using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro
{
    public class Parceiro : EntidadeBase<Parceiro>
    {
        public string nome { get; set; }

        public Parceiro()
        {
            
        }

        public Parceiro(string nome)
        {
            this.nome = nome;
        }

        public Parceiro(Guid id, string nome) : this(nome)
        {
            this.id = id;
        }

        public override void AtualizarInformacoes(Parceiro registroAtualizado)
        {
            nome = registroAtualizado.nome;
        }

        public override string ToString()
        {
            return nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Parceiro parceiro &&
                   id == parceiro.id &&
                   nome == parceiro.nome;
        }
    }
}
