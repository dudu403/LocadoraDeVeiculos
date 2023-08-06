using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string tipoPessoa { get; set; }
        public string? cpf { get; set; }
        public string? cnpj { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        public Cliente(Guid id, string nome) : this(nome)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return nome;
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                id == cliente.id &&
                nome == cliente.nome &&
                telefone == cliente.telefone &&
                tipoPessoa == cliente.tipoPessoa &&
                email == cliente.email &&
                cpf == cliente.cpf &&
                cnpj == cliente.cnpj &&
                estado == cliente.estado &&
                cidade == cliente.cidade &&
                bairro == cliente.bairro &&
                rua == cliente.rua &&
                numero == cliente.numero &&
                cep == cliente.cep;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            nome = registroAtualizado.nome;
        }
    }
}
