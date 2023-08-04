
namespace LocadoraDeVeiculos.Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public string nome { get; set; }
        public DateTime dataAdmissao { get; set; }
        public decimal salario { get; set; }

        public Funcionario() 
        {
            dataAdmissao = DateTime.Now;
        }

        public Funcionario(string nome, decimal salario, DateTime dataAdmissao) 
        {
            this.nome = nome;
            this.salario = salario;
            this.dataAdmissao = dataAdmissao;
        }

        public override void AtualizarInformacoes(Funcionario registroAtualizado)
        {
            nome = registroAtualizado.nome;
            salario = registroAtualizado.salario;
            dataAdmissao = registroAtualizado.dataAdmissao;
        }
    }
}
