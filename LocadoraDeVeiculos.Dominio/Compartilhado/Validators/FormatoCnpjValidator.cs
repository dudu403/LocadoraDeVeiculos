﻿using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class FormatoCnpjValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "FormatoCnpjValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve estar no formato 'xxxxxxxx@xxxxx.xxx' ";
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