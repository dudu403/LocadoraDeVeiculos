using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class FormatoCnhValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "FormatoCnhValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve estar no formato '0000000000'";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string texto)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            Regex rgx = new Regex(@"^(?=.*[1-9])\d{10}$");

            if (rgx.IsMatch(texto))
                return true;
            else
                return false;
        }
    }
}