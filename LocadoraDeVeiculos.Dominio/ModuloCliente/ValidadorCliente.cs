using LocadoraDeVeiculos.Dominio.Compartilhado.Validators;

namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class ValidadorCliente : AbstractValidator<Cliente>, IValidadorCliente
    {
        public ValidadorCliente()
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.email)
                .NotEmpty()
                .NotNull()
                .VerificaFormatoEmail();

            RuleFor(x => x.telefone)
                .VerificaFormatoTelefone();

            RuleFor(x => x.tipoPessoa)
                .NotEmpty()
                .NotNull();

            When(x => x.tipoPessoa == "Pessoa Física", () =>
            {
                RuleFor(x => x.cpf)
                    .NotEmpty()
                    .NotNull()
                    .VerificaFormatoCpf();

                RuleFor(x => x.cnpj)
                    .Empty(); 
            });

            When(x => x.tipoPessoa == "Pessoa Jurídica", () =>
            {
                RuleFor(x => x.cnpj)
                    .NotEmpty()
                    .NotNull()
                    .VerificaFormatoCnpj();

                RuleFor(x => x.cpf)
                    .Empty(); 
            });

            RuleFor(x => x.cep)
                .NotEmpty()
                .NotNull()
                .VerificaFormatoCep();

            RuleFor(x => x.estado)
                .VerificaSePreencheu();

            RuleFor(x => x.numero)
                .NotEmpty()
                .NotNull();
        }
    }
}
