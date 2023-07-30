namespace LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro
{
    public class Cupom : EntidadeBase<Cupom>
    {
        public Parceiro parceiro { get; set; }
        public DateTime validade { get; set; }
        public decimal valor { get; set; }
        public string nome { get; set; }

        public override void AtualizarInformacoes(Cupom registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
