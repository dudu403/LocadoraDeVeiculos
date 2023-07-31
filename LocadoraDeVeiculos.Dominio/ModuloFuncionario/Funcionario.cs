using Microsoft.VisualBasic.Logging;

namespace LocadoraDeVeiculos.Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public string nome { get; set; }
        public DateTime dataAdmissao { get; set; }
        public decimal salario { get; set; }

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
            dataAdmissao = registroAtualizado.dataAdmissao;
        }
    }
}
