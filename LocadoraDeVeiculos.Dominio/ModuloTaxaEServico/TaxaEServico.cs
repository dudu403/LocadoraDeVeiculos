namespace LocadoraDeVeiculos.Dominio.ModuloTaxaEServico
{
    public class TaxaEServico : EntidadeBase<TaxaEServico>
    {
        public string nome { get; set; }
        public decimal preco { get; set; }
        public TipoCustoEnum tipoDoCusto { get; set; }

        public TaxaEServico()
        {
            tipoDoCusto = TipoCustoEnum.Nenhum;
        }

        public TaxaEServico(string nome, decimal preco, TipoCustoEnum tipoDoCusto)
        {
            this.nome = nome; 
            this.preco = preco;
            this.tipoDoCusto = tipoDoCusto;
        }

        public override void AtualizarInformacoes(TaxaEServico registroAtualizado)
        {
            nome = registroAtualizado.nome;
            preco = registroAtualizado.preco;
            tipoDoCusto = registroAtualizado.tipoDoCusto;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
