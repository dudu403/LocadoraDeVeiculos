namespace LocadoraDeVeiculos.Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public string nome { get; set; }
        public DateTime dataAdmissao { get; set; }
        public decimal salario { get; set; }

        public override void AtualizarInformacoes(Funcionario registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
