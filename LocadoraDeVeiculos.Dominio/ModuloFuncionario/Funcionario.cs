
namespace LocadoraDeVeiculos.Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public string nome { get; set; }
        public DateTime dataAdimissao { get; set; }
        public decimal salario { get; set; }

        public Funcionario() 
        {
        }
        public Funcionario(string nome, string salario, DateOnly dataAdmissao) 
        {
            nome = nome;
            salario = salario;
            dataAdmissao = dataAdmissao;
         
        }
        public override void AtualizarInformacoes(Funcionario registroAtualizado)
        {
            nome = registroAtualizado.nome;
            salario = registroAtualizado.salario;
            dataAdimissao = registroAtualizado.dataAdimissao;
        }
    }
}
