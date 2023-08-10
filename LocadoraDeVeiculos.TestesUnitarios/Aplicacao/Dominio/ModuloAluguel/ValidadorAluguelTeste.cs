using FluentAssertions;
using FluentValidation.Results;
using FluentValidation.TestHelper;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;

namespace LocadoraDeVeiculos.TestesUnitarios.Dominio.ModuloAluguel
{
    [TestClass]
    public class AluguelTest
    {
        private Aluguel aluguel;
        private ValidadorAluguel validadorAluguel;

        public AluguelTest()
        {
            aluguel = new Aluguel
            {

            };

            validadorAluguel = new ValidadorAluguel();
        }

        [TestMethod]
        public void Deve_validar_aluguel_com_propriedades_corretas()
        {
            ValidationResult result = validadorAluguel.Validate(aluguel);

            result.IsValid.Should().BeTrue();
        }

        [TestMethod]
        public void Deve_invalidar_aluguel_com_valor_total_previsto_negativo()
        {
            aluguel.valorTotalPrevisto = -200;

            var result = validadorAluguel.TestValidate(aluguel);

            result.ShouldHaveValidationErrorFor(a => a.valorTotalPrevisto);
        }

        public void Deve_invalidar_aluguel_com_condutor_nulo()
        {
            aluguel.condutor = null;

            var result = validadorAluguel.TestValidate(aluguel);

            result.ShouldHaveValidationErrorFor(a => a.condutor);
        }


    }
}
