using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class FormatoCnpjValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "FormatoCnpjValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve estar no formato '00.000.000/0000-00' ";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string texto)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            Regex rgx = new Regex(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$");

            if (rgx.IsMatch(texto))
                return true;
            else
                return false;
        }
    }
}