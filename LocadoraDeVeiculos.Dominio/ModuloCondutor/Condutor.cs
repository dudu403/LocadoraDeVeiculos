using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor
{
    public class Condutor : EntidadeBase<Condutor>
    {
        public Cliente cliente { get; set; }
        public DateTime validadeCnh { get; set; }
        public string telefone { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string cnh { get; set; }

        public Condutor() 
        {
            validadeCnh = DateTime.Now;
        }

        public Condutor(Cliente cliente, DateTime validadeCnh, string telefone, string nome, string email, string cpf, string cnh )
        {
            this.cliente = cliente;
            this.validadeCnh = validadeCnh;
            this.telefone = telefone;
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.cnh = cnh;
        }

        public override void AtualizarInformacoes(Condutor registroAtualizado)
        {
            cliente = registroAtualizado.cliente;
            validadeCnh = registroAtualizado.validadeCnh;
            telefone = registroAtualizado.telefone;
            nome = registroAtualizado.nome;
            email = registroAtualizado.email;
            cpf = registroAtualizado.cpf;
            cnh = registroAtualizado.cnh;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
