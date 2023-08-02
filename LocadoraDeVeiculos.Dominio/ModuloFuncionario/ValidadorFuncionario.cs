namespace LocadoraDeVeiculos.Dominio.ModuloFuncionario
{
    public class ValidadorFuncionario : AbstractValidator<Funcionario>, IValidadorFuncionario
    {
        public ValidadorFuncionario()
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.dataAdmissao)
                .NotEmpty()
                .NotNull()
                .LessThan(DateTime.Today);

            RuleFor(x => x.salario)
                .NotEmpty()
                .NotNull();
        }
    }
}
