using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor
{
    public class Condutor : EntidadeBase<Condutor>
    {
        public DateTime validadeCnh { get; set; }
        public Cliente cliente { get; set; }
        public string telefone { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string cnh { get; set; }

        public override void AtualizarInformacoes(Condutor registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
