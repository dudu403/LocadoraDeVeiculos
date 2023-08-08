using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class FormatoCepValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "FormatoCpfValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve estar no formato '00000-000' ";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string cpf)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            Regex rgx = new Regex(@"^\d{5}-\d{3}$");

            if (rgx.IsMatch(cpf))
                return true;
            else
                return false;
        }
    }
}