namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public decimal edereco { get; set; }
        public decimal estado { get; set; }
        public decimal cidade { get; set; }
        public decimal bairro { get; set; }
        public decimal numero { get; set; }
        public string? cnpj { get; set; }
        public string email { get; set; }
        public decimal rua { get; set; }
        public string nome { get; set; }
        public string? cpf { get; set; }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
