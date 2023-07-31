namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string edereco { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string? cnpj { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string? cpf { get; set; }
        public int numero { get; set; }
        public string rua { get; set; }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
