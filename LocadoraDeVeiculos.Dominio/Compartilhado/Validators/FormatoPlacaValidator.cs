using FluentValidation.Validators;
using System.Numerics;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class FormatoPlacaValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "FormatoPlacaValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve estar no formato 'AAA-9999' ou 'LLLNLNN'";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string placa)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            Regex rgxPlacaAntiga = new Regex(@"^[A-Z]{3}-\d{4}$");

            Regex rgxPlacaNova = new Regex(@"^[A-Z]{3}\d[A-Z0-9]\d{2}$");

            if (rgxPlacaAntiga.IsMatch(placa) || rgxPlacaNova.IsMatch(placa))
                return true;
            else
                return false;
        }
    }
}