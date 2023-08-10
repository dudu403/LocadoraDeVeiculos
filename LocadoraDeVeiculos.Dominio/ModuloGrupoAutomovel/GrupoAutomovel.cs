using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel
{ 
    public class GrupoAutomovel : EntidadeBase<GrupoAutomovel>
    {
        public string nome { get; set; }
        public List<PlanoCobranca> planosCobranca { get; set; }    
        public List<Automovel> automoveis { get; set; }

        public GrupoAutomovel()
        {
            
        }

        public GrupoAutomovel(string nome) 
        {
            this.nome = nome;
        }

        public GrupoAutomovel(Guid id, string nome) : this(nome)        
        {
            this.id = id;
        }

        public override void AtualizarInformacoes(GrupoAutomovel registroAtualizado)
        {
            nome = registroAtualizado.nome;
        }

        public override string ToString()
        {
            return nome;
        }

        public override bool Equals(object obj)
        {
            return obj is GrupoAutomovel grupoAutomovel &&
                   id == grupoAutomovel.id &&
                   nome == grupoAutomovel.nome;
        }
    }
}
