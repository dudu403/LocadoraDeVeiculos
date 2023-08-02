using FluentValidation;
using FluentValidation.Validators;

namespace LocadoraDeVeiculos.Dominio.Compartilhado
{
    public class NaoPodeValoresNegativosValidator<T> : PropertyValidator<T, decimal>
    {
        public override string Name => "NaoPodeValoresNegativos";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {            
            return $"'{nomePropriedade}' deve ser composto por apenas letras.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, decimal numero)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            if (numero <= 0)
                return false;
            else
                return true;
        }        
    }
}
