namespace LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro
{
    public class Cupom : EntidadeBase<Cupom>
    {
        public Parceiro parceiro { get; set; }
        public DateTime validade { get; set; }
        public decimal valor { get; set; }
        public string nome { get; set; }

        public Cupom(Parceiro parceiro, DateTime validade, decimal valor, string nome)
        {
            this.parceiro = parceiro;
            this.validade = validade;
            this.valor = valor;
            this.nome = nome;
        }

        public override void AtualizarInformacoes(Cupom registroAtualizado)
        {
            nome = registroAtualizado.nome;
            valor = registroAtualizado.valor;
            parceiro = registroAtualizado.parceiro;
            validade = registroAtualizado.validade;
        }
    }
}
