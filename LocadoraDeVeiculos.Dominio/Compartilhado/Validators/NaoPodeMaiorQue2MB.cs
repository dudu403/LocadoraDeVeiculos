using FluentValidation;
using FluentValidation.Validators;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class NaoPodeMaiorQue2MB<T> : PropertyValidator<T, byte[]>
    {
        public override string Name => "NaoPodeMaiorQue2MB";

        private string nomePropriedade;


        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve ser de até 2MB.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, byte[] imagem)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            long imageSizeEmBytes = imagem.Length;
            long maxSizeEmBytes = 2 * 1024 * 1024; // 2MB

            if (imageSizeEmBytes > maxSizeEmBytes)
                return false;
            else
                return true;
        }
    }
}
