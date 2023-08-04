using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            RuleFor(x => x.cep)
                .NotEmpty()
                .NotNull()
                .MinimumLength(8);

            RuleFor(x => x.email)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.telefone)
                .NotEmpty()
                .NotNull()
                .MinimumLength(8);

            When(x => x.tipoPessoa == "Pessoa Física", () =>
            {
                RuleFor(x => x.cpf)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(8);

                RuleFor(x => x.cnpj)
                    .Empty(); 
            });

            When(x => x.tipoPessoa == "Pessoa Jurídica", () =>
            {
                RuleFor(x => x.cnpj)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(5);

                RuleFor(x => x.cpf)
                    .Empty(); 
            });

            RuleFor(x => x.estado)
                .NotEmpty()
                .NotNull()
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.cidade)
                .NotEmpty()
                .NotNull()
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.bairro)
                .NotEmpty()
                .NotNull()
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.rua)
                .NotEmpty()
                .NotNull()
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.numero)
                .NotEmpty()
                .NotNull();
        }
    }
}
