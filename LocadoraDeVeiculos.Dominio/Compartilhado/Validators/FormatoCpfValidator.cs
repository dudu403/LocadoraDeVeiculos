using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class FormatoCpfValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "FormatoCpfValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve estar no formato '000.000.000-00' ";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string placa)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            Regex rgx = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

            if (rgx.IsMatch(placa))
                return true;
            else
                return false;
        }
    }
}