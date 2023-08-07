using FluentValidation.Validators;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    internal class ClickBtnBuscaValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "ClickBtnBuscaValidator";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"Voce deve clicar no botão consultar para encontar seu enereço com base no seu CEP.";
        }

        public override bool IsValid(ValidationContext<T> context, string @string)
        {
            if (@string != "")
                return true;
            else
                return false;
        }
    }
}