using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class FormatoTelefoneValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "FormatoTelefoneValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve estar no formato '(XX)9XXXX-XXXX' ";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string texto)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            Regex rgx = new(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");

            if (rgx.IsMatch(texto))
                return true;
            else
                return false;
        }
    }
}